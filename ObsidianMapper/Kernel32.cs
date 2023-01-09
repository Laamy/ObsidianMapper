using System.Runtime.InteropServices;
using System;

namespace ObsidianMapper
{
    public class Kernel32
    {
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(
            UIntPtr hProcess,
            IntPtr lpBaseAddress,
            byte[] lpBuffer,
            int dwSize,
            ref int lpNumberOfBytesRead
        );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern UIntPtr OpenProcess(
            ProcessAccessFlags dwDesiredAccess,
            bool bInheritHandle,
            uint dwProcessId
        );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CloseHandle(
            UIntPtr hObject
        );

        [Flags]
        public enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VMOperation = 0x00000008,
            VMRead = 0x00000010,
            VMWrite = 0x00000020,
            DupHandle = 0x00000040,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            Synchronize = 0x00100000
        }
    }
}
