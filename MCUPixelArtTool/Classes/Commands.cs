﻿internal class Class10
{
	public enum Enum0
	{
		COMMAND_WRITE_8 = 1,
		COMMAND_WRITE_16,
		COMMAND_WRITE_32,
		COMMAND_READ_MEMORY,
		COMMAND_READ_MEMORY_KERNEL,
		COMMAND_VALIDATE_ADDRESS_RANGE,
		COMMAND_MEMORY_DISASSEMBLE = 8,
		COMMAND_KERNEL_WRITE = 11,
		COMMAND_KERNEL_READ,
		COMMAND_TAKE_SCREEN_SHOT,
		COMMAND_UPLOAD_MEMORY = 65,
		COMMAND_SERVER_STATUS = 80,
		COMMAND_GET_DATA_BUFFER_SIZE,
		COMMAND_READ_FILE,
		COMMAND_READ_DIRECTORY,
		COMMAND_REPLACE_FILE,
		COMMAND_GET_CODE_HANDLER_ADDRESS,
		COMMAND_READ_THREADS,
		COMMAND_ACCOUNT_IDENTIFIER,
		COMMAND_FOLLOW_POINTER = 96,
		COMMAND_REMOTE_PROCEDURE_CALL = 112,
		COMMAND_GET_SYMBOL,
		COMMAND_MEMORY_SEARCH_32,
		COMMAND_ADVANCED_MEMORY_SEARCH,
		COMMAND_EXECUTE_ASSEMBLY = 129,
		COMMAND_PAUSE_CONSOLE,
		COMMAND_RESUME_CONSOLE,
		COMMAND_IS_CONSOLE_PAUSED,
		COMMAND_SERVER_VERSION = 153,
		COMMAND_GET_OS_VERSION,
		COMMAND_SET_DATA_BREAKPOINT = 160,
		COMMAND_SET_INSTRUCTION_BREAKPOINT = 162,
		COMMAND_TOGGLE_BREAKPOINT = 165,
		COMMAND_REMOVE_ALL_BREAKPOINTS,
		COMMAND_POKE_REGISTERS,
		COMMAND_GET_STACK_TRACE,
		COMMAND_GET_ENTRY_POINT_ADDRESS = 177,
		COMMAND_RUN_KERNEL_COPY_SERVICE = 205,
		COMMAND_GET_VERSION_HASH = 224,
		COMMAND_PERSIST_ASSEMBLY,
		COMMAND_CLEAR_ASSEMBLY
	}
}