namespace PixelArtTool {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblResult = new System.Windows.Forms.Label();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.lblSource = new System.Windows.Forms.Label();
            this.btnPaste = new System.Windows.Forms.Button();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.dgvColors = new System.Windows.Forms.DataGridView();
            this.ColorColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.RGBColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofdLoad = new System.Windows.Forms.OpenFileDialog();
            this.cdChooseColor = new System.Windows.Forms.ColorDialog();
            this.interpolatedPictureBox1 = new PixelArtTool.Controls.InterpolatedPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interpolatedPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(471, 51);
            this.lblResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(76, 18);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "プレビュー";
            // 
            // tbxPath
            // 
            this.tbxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPath.Location = new System.Drawing.Point(20, 17);
            this.tbxPath.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(664, 25);
            this.tbxPath.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(697, 15);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(50, 32);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.LoadImage);
            // 
            // ofdOpen
            // 
            this.ofdOpen.Filter = "PNG files|*.png";
            this.ofdOpen.Title = "Select an image...";
            // 
            // lblSource
            // 
            this.lblSource.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(236, 51);
            this.lblSource.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(62, 18);
            this.lblSource.TabIndex = 1;
            this.lblSource.Text = "元画像";
            // 
            // btnPaste
            // 
            this.btnPaste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaste.Enabled = false;
            this.btnPaste.Location = new System.Drawing.Point(19, 267);
            this.btnPaste.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(728, 32);
            this.btnPaste.TabIndex = 4;
            this.btnPaste.Text = "送信";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.ConvertImage);
            // 
            // IPBox
            // 
            this.IPBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPBox.Location = new System.Drawing.Point(20, 312);
            this.IPBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(562, 25);
            this.IPBox.TabIndex = 2;
            this.IPBox.Text = "192.168.";
            this.IPBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(592, 312);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(152, 30);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "接続";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.Connect);
            // 
            // dgvColors
            // 
            this.dgvColors.AllowUserToAddRows = false;
            this.dgvColors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColorColumn,
            this.RGBColumn,
            this.BlockColumn,
            this.DataColumn});
            this.dgvColors.Location = new System.Drawing.Point(697, 111);
            this.dgvColors.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvColors.Name = "dgvColors";
            this.dgvColors.RowHeadersWidth = 62;
            this.dgvColors.Size = new System.Drawing.Size(10, 85);
            this.dgvColors.TabIndex = 11;
            this.dgvColors.Visible = false;
            // 
            // ColorColumn
            // 
            this.ColorColumn.FillWeight = 30F;
            this.ColorColumn.HeaderText = "";
            this.ColorColumn.MinimumWidth = 8;
            this.ColorColumn.Name = "ColorColumn";
            this.ColorColumn.ReadOnly = true;
            this.ColorColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColorColumn.Width = 30;
            // 
            // RGBColumn
            // 
            this.RGBColumn.HeaderText = "RGB";
            this.RGBColumn.MinimumWidth = 8;
            this.RGBColumn.Name = "RGBColumn";
            this.RGBColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RGBColumn.Width = 150;
            // 
            // BlockColumn
            // 
            this.BlockColumn.HeaderText = "Block ID";
            this.BlockColumn.MinimumWidth = 8;
            this.BlockColumn.Name = "BlockColumn";
            this.BlockColumn.ReadOnly = true;
            this.BlockColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BlockColumn.Width = 150;
            // 
            // DataColumn
            // 
            this.DataColumn.HeaderText = "Block Data ID";
            this.DataColumn.MinimumWidth = 8;
            this.DataColumn.Name = "DataColumn";
            this.DataColumn.ReadOnly = true;
            this.DataColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataColumn.Width = 150;
            // 
            // ofdLoad
            // 
            this.ofdLoad.Filter = "Color Configurations|*.pxl";
            this.ofdLoad.Title = "Where is your color configuration located?";
            // 
            // interpolatedPictureBox1
            // 
            this.interpolatedPictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
            this.interpolatedPictureBox1.Location = new System.Drawing.Point(239, 100);
            this.interpolatedPictureBox1.Name = "interpolatedPictureBox1";
            this.interpolatedPictureBox1.Size = new System.Drawing.Size(100, 50);
            this.interpolatedPictureBox1.TabIndex = 0;
            this.interpolatedPictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 350);
            this.Controls.Add(this.interpolatedPictureBox1);
            this.Controls.Add(this.dgvColors);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.IPBox);
            this.Controls.Add(this.tbxPath);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.lblResult);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Main";
            this.Text = "シンプルドット絵ツール";
            this.Load += new System.EventHandler(this.FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interpolatedPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbxPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.Button btnConnect;
        private PixelArtTool.Controls.InterpolatedPictureBox imgSource;
        private PixelArtTool.Controls.InterpolatedPictureBox imgResult;
        private System.Windows.Forms.DataGridView dgvColors;
        private System.Windows.Forms.OpenFileDialog ofdLoad;
        private System.Windows.Forms.DataGridViewImageColumn ColorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RGBColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataColumn;
        private System.Windows.Forms.ColorDialog cdChooseColor;
        private Controls.InterpolatedPictureBox interpolatedPictureBox1;
    }
}

