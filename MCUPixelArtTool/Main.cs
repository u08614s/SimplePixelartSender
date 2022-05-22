using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace PixelArtTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public Gecko GeckoU;
        public static Dictionary<Color, int[]> customColourData = new Dictionary<Color, int[]>();

        public static Image ResizeImage(Image srcImg, Size newSize)
        {
            return new Bitmap(srcImg, newSize);
        }

        private void LoadImage(object sender, EventArgs e)
        {
            if (dgvColors.Rows.Count <= 1)
            {
                MessageBox.Show("Please provide at least two colors.", "Error", MessageBoxButtons.OK);
                return;
            }
            var dialogRes = ofdOpen.ShowDialog();
            if (dialogRes == DialogResult.OK)
            {
                customColourData.Clear();
                tbxPath.Text = ofdOpen.FileName;
                var image = Image.FromFile(ofdOpen.FileName);
                imgSource.Image = ResizeImage(image, new Size((int)128, (int)128));
                var colourList = new List<Color>();
                List<Color> sourceColours = new List<Color>();
                foreach (DataGridViewRow row in dgvColors.Rows)
                {
                    var grab = row.Cells[1].Value.ToString().Split(',');
                    sourceColours.Add(Color.FromArgb(int.Parse(grab[0]), int.Parse(grab[1]), int.Parse(grab[2])));
                    customColourData.Add(Color.FromArgb(int.Parse(grab[0]), int.Parse(grab[1]), int.Parse(grab[2])), new[] { int.Parse(row.Cells[2].Value.ToString()), int.Parse(row.Cells[3].Value.ToString()) });
                }
                var image2 = new Bitmap(imgSource.Image);
                for (int y = 0; y < (int)128; y++)
                {
                    for (int x = 0; x < (int)128; x++)
                    {
                        colourList.Add(GetClosestColor(sourceColours.ToArray(), image2.GetPixel(x, y)));
                    }
                }
                var result = GenerateImage((int)128, (int)128, colourList.ToArray());
                imgResult.Image = result;
                dgvColors.ReadOnly = true;
            }
        }

        private void ConvertImage(object sender, EventArgs e)
        {
            if (imgResult.Image == null)
            {
                MessageBox.Show("画像が選ばれていません", "シンプルドット絵ツール", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                var img = new Bitmap(imgResult.Image);

                var size = (int)128 * (int)128;
                var length = 0x3D000000 + ((size * 2) * 32);

                var x = 0;
                var y = 0;
                var z = 0;

                List<uint> blockList = new List<uint>();

                for (int nx = (int)128 - 1; nx > -1; nx--)
                {
                    y = 0;
                    for (int ny = 0; ny < 2; ny++)
                    {
                        z = 0;
                        for (int nz = (int)128 - 1; nz > -1; nz--)
                        {
                            if (y > 0)
                            {
                                blockList.AddRange(new List<uint>() { ReverseBytes((uint)x), ((uint)y), ReverseBytes((uint)z), 0, 0, 0, 0, 0 });
                            }
                            else
                            {
                                if (customColourData.TryGetValue(img.GetPixel(nx, nz), out int[] data))
                                {
                                    blockList.AddRange(new List<uint>() { ReverseBytes((uint)x), ReverseBytes((uint)y), ReverseBytes((uint)z), ReverseBytes((uint)data[0]), ReverseBytes((uint)data[1]), 0, 0, 0 });
                                }
                                else
                                {
                                    if (img.GetPixel(nx, nz) == Color.FromArgb(0, 0, 0, 0))
                                    {
                                        blockList.AddRange(new List<uint>() { ReverseBytes((uint)x), ReverseBytes((uint)y), ReverseBytes((uint)z), 0, 0, 0, 0, 0 });
                                    }
                                    else
                                    {
                                        blockList.AddRange(new List<uint>() { ReverseBytes((uint)x), ReverseBytes((uint)y), ReverseBytes((uint)z), ReverseBytes(251u), ReverseBytes(15), 0, 0, 0 });
                                    }
                                }
                            }
                            z++;
                        }
                        y++;
                    }
                    x++;
                }

                var newBlockList = blockList.ToArray();

                byte[] blockData = new byte[newBlockList.Length * 4];
                Buffer.BlockCopy(newBlockList, 0, blockData, 0, newBlockList.Length * 4);

                Console.WriteLine(BitConverter.ToString(blockData));

                GeckoU.PokeInt(0x3A100030, (int)GeckoU.PeekUInt(GeckoU.PeekUInt(GeckoU.PeekUInt(0x109CD8E4) + 0x34) + 0x54));
                GeckoU.PokeInt(0x3A100034, (int)GeckoU.PeekUInt(GeckoU.PeekUInt(GeckoU.PeekUInt(0x109CD8E4) + 0x34) + 0x58));
                GeckoU.PokeInt(0x3A100038, (int)GeckoU.PeekUInt(GeckoU.PeekUInt(GeckoU.PeekUInt(0x109CD8E4) + 0x34) + 0x5C));
                GeckoU.WriteBytes(0x3D000000, blockData);
                GeckoU.PokeUInt(0x12000000, (uint)length);
                GeckoU.WriteBytes(0x04000000, Data.set());
                GeckoU.CallFunction(0x04000000, new uint[1]);
                MessageBox.Show("送信しました", "シンプルドット絵ツール", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static UInt32 ReverseBytes(UInt32 value)
        {
            return (value & 0x000000FFU) << 24 | (value & 0x0000FF00U) << 8 |
                (value & 0x00FF0000U) >> 8 | (value & 0xFF000000U) >> 24;
        }

        public Bitmap GenerateImage(int width, int height, Color[] colours)
        {
            Bitmap image = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            var uindice = 0;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    image.SetPixel(x, y, colours[uindice]);
                    uindice++;
                }
            }

            return image;
        }

        private Color GetClosestColor(Color[] colors, Color c)
        {
            Color closestColour = new Color();
            double smallestDiff = double.MaxValue;
            double colourDiff;

            foreach (Color currentColour in colors)
            {
                colourDiff = Math.Abs(c.R - currentColour.R) + Math.Abs(c.G - currentColour.G) + Math.Abs(c.B - currentColour.B);
                if (colourDiff < smallestDiff)
                {
                    smallestDiff = colourDiff;
                    closestColour = currentColour;
                }
            }

            if (c.A == 0)
            {
                closestColour = Color.FromArgb(0, 0, 0, 0);
            }

            return closestColour;
        }

        private void Connect(object hass, EventArgs e)
        {
            GeckoU = new Gecko(IPBox.Text);
            try
            {
                GeckoU.tcpConn.Connect();
                btnConnect.Text = "接続済み";
                btnConnect.Enabled = false;
                string text = "9421FFF093E1000C3FE03B00813F00002C090001418200403D20025A7C0802A661291AD0900100147D2903A64E8004213D2002296129CFFC386000017D2903A64E8004218001001439200001913F00007C0803A683E1000C382100104E800020";
                GeckoU.WriteBytes(0x03900000, GeckoU.string2bytes(text));
                GeckoU.CallFunction(0x03900000, new uint[1]);
                btnPaste.Enabled = true;
            }
            catch (Exception value)
            {
                Console.WriteLine(value);
            }
        }

        private void FormLoad(object sender, EventArgs e)
        {
            //This is wool colors.
            AddColorEntry(ColorTranslator.FromHtml("#FFE4E4E4"), "35", "0");
            AddColorEntry(ColorTranslator.FromHtml("#FFEA7E35"), "35", "1");
            AddColorEntry(ColorTranslator.FromHtml("#FFBE49C9"), "35", "2");
            AddColorEntry(ColorTranslator.FromHtml("#FF6387D2"), "35", "3");
            AddColorEntry(ColorTranslator.FromHtml("#FFC2B51C"), "35", "4");
            AddColorEntry(ColorTranslator.FromHtml("#FF39BA2E"), "35", "5");
            AddColorEntry(ColorTranslator.FromHtml("#FFD98199"), "35", "6");
            AddColorEntry(ColorTranslator.FromHtml("#FF414141"), "35", "7");
            AddColorEntry(ColorTranslator.FromHtml("#FFA0A7A7"), "35", "8");
            AddColorEntry(ColorTranslator.FromHtml("#FF267191"), "35", "9");
            AddColorEntry(ColorTranslator.FromHtml("#FF7E34BF"), "35", "10");
            AddColorEntry(ColorTranslator.FromHtml("#FF253193"), "35", "11");
            AddColorEntry(ColorTranslator.FromHtml("#FF56331C"), "35", "12");
            AddColorEntry(ColorTranslator.FromHtml("#FF364B18"), "35", "13");
            AddColorEntry(ColorTranslator.FromHtml("#FF9E2B27"), "35", "14");
            AddColorEntry(ColorTranslator.FromHtml("#FF181414"), "35", "15");
        }

        private void AddColorEntry(Color color, string blockID, string blockData)
        {
            Bitmap bmp = new Bitmap(21, 21);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(color);
                dgvColors.Rows.Add(bmp, $"{color.R},{color.G},{color.B}", blockID, blockData);
            }
        }
    }
}
