using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MemoryReaderExample
{
    public class MMR
    {
        // Declare a variable to store the process and a variable to store the handle to the process
        static Process proc;
        static IntPtr hProcess;

        /// <summary>
        /// Check if the Minecraft process is running and open a handle to the process
        /// </summary>
        /// <exception cref="Exception">Failed to find the game window</exception>
        public static void CheckInject()
        {
            // Check if the Minecraft.Windows process is running
            if (Process.GetProcessesByName("Minecraft.Windows").Length == 0)
                throw new Exception("Please open the game window first");

            // Get the first instance of the running Minecraft.Windows process
            proc = Process.GetProcessesByName("Minecraft.Windows")[0];

            // Open a handle to the process with read access
            hProcess = OpenProcess(0x0010, false, proc.Id);
        }

        // int float IntPtr double short byte

        #region Int

        /// <summary>
        /// Read an integer value from a specified memory address in the Minecraft process's memory
        /// </summary>
        /// <param name="addr">memory address in the Minecraft process's memory</param>
        /// <returns>an integer value from a specified memory address</returns>
        public static int ReadInt(long addr)
        {
            // Check inject into the game
            CheckInject();

            // Create a buffer to store the data that is read from memory
            byte[] buffer = new byte[4];
            IntPtr bytesRead;

            //Read the memory at the address by adding the base address of the process's MainModule + addr to the address 
            ReadProcessMemory(hProcess, new IntPtr(proc.MainModule.BaseAddress.ToInt64() + addr), buffer, 4, out bytesRead);

            // Convert the bytes to an integer and return the result
            return BitConverter.ToInt32(buffer, 0);
        }

        /// <summary>
        /// Write an integer value to a specified memory address in the Minecraft process's memory
        /// </summary>
        /// <param name="addr">memory address in the Minecraft process's memory</param>
        /// <param name="value">integer value to be written</param>
        public static void WriteInt(long addr, int value)
        {
            // Check inject into the game
            CheckInject();

            // Convert the integer value to bytes
            byte[] buffer = BitConverter.GetBytes(value);
            IntPtr bytesWritten;

            // Write the value to the specified memory address
            WriteProcessMemory(hProcess, new IntPtr(proc.MainModule.BaseAddress.ToInt64() + addr), buffer, 4, out bytesWritten);
        }

        #endregion

        #region Float

        /// <summary>
        /// Read a float value from a specified memory address in the Minecraft process's memory
        /// </summary>
        /// <param name="addr">memory address in the Minecraft process's memory</param>
        /// <returns>a float value from a specified memory address</returns>
        public static float ReadFloat(long addr)
        {
            // Check inject into the game
            CheckInject();

            // Create a buffer to store the data that is read from memory
            byte[] buffer = new byte[4];
            IntPtr bytesRead;

            //Read the memory at the address by adding the base address of the process's MainModule + addr to the address 
            ReadProcessMemory(hProcess, new IntPtr(proc.MainModule.BaseAddress.ToInt64() + addr), buffer, 4, out bytesRead);

            // Convert the bytes to a float and return the result
            return BitConverter.ToSingle(buffer, 0);
        }

        /// <summary>
        /// Write a float value to a specified memory address in the Minecraft process's memory
        /// </summary>
        /// <param name="addr">memory address in the Minecraft process's memory</param>
        /// <param name="value">float value to be written</param>
        public static void WriteFloat(long addr, float value)
        {
            // Check inject into the game
            CheckInject();

            // Convert the float value to bytes
            byte[] buffer = BitConverter.GetBytes(value);
            IntPtr bytesWritten;

            // Write the value to the specified memory address
            WriteProcessMemory(hProcess, new IntPtr(proc.MainModule.BaseAddress.ToInt64() + addr), buffer, 4, out bytesWritten);
        }

        #endregion

        #region IntPtr

        /// <summary>
        /// Read an IntPtr value from a specified memory address in the Minecraft process's memory
        /// </summary>
        /// <param name="addr">memory address in the Minecraft process's memory</param>
        /// <returns>an IntPtr value from a specified memory address</returns>
        public static IntPtr ReadIntPtr(long addr)
        {
            // Check inject into the game
            CheckInject();

            // Create a buffer to store the data that is read from memory
            byte[] buffer = new byte[8];
            IntPtr bytesRead;

            // Read the memory at the address by adding the base address of the process's MainModule + addr to the address 
            ReadProcessMemory(hProcess, new IntPtr(proc.MainModule.BaseAddress.ToInt64() + addr), buffer, 8, out bytesRead);

            // Convert the bytes to an IntPtr and return the result
            return new IntPtr(BitConverter.ToInt64(buffer, 0));
        }

        /// <summary>
        /// Write an IntPtr value to a specified memory address in the Minecraft process's memory
        /// </summary>
        /// <param name="addr">memory address in the Minecraft process's memory</param>
        /// <param name="value">IntPtr value to be written</param>
        public static void WriteIntPtr(long addr, IntPtr value)
        {
            // Check inject into the game
            CheckInject();

            // Convert the IntPtr value to bytes
            byte[] buffer = BitConverter.GetBytes(value.ToInt64());
            IntPtr bytesWritten;

            // Write the value to the specified memory address
            WriteProcessMemory(hProcess, new IntPtr(proc.MainModule.BaseAddress.ToInt64() + addr), buffer, buffer.Length, out bytesWritten);
        }

        #endregion

        #region Double

        /// <summary>
        /// Read a double value from a specified memory address in the Minecraft process's memory
        /// </summary>
        /// <param name="addr">memory address in the Minecraft process's memory</param>
        /// <returns>a double value from a specified memory address</returns>
        public static double ReadDouble(long addr)
        {
            // Check inject into the game
            CheckInject();

            // Create a buffer to store the data that is read from memory
            byte[] buffer = new byte[8];
            IntPtr bytesRead;

            // Read the memory at the address by adding the base address of the process's MainModule + addr to the address 
            ReadProcessMemory(hProcess, new IntPtr(proc.MainModule.BaseAddress.ToInt64() + addr), buffer, 8, out bytesRead);

            // Convert the bytes to a double and return the result
            return BitConverter.ToDouble(buffer, 0);
        }

        /// <summary>
        /// Write a double value to a specified memory address in the Minecraft process's memory
        /// </summary>
        /// <param name="addr">memory address in the Minecraft process's memory</param>
        /// <param name="value">double value to be written</param>
        public static void WriteDouble(long addr, double value)
        {
            // Check inject into the game
            CheckInject();

            // Convert the double value to bytes
            byte[] buffer = BitConverter.GetBytes(value);
            IntPtr bytesWritten;

            // Write the value to the specified memory address
            WriteProcessMemory(hProcess, new IntPtr(proc.MainModule.BaseAddress.ToInt64() + addr), buffer, 8, out bytesWritten);
        }

        #endregion

        #region Short

        /// <summary>
        /// Read a short value from a specified memory address in the Minecraft process's memory
        /// </summary>
        /// <param name="addr">memory address in the Minecraft process's memory</param>
        /// <returns>a short value from a specified memory address</returns>
        public static short ReadShort(long addr)
        {
            // Check inject into the game
            CheckInject();

            // Create a buffer to store the data that is read from memory
            byte[] buffer = new byte[2];
            IntPtr bytesRead;

            // Read the memory at the address by adding the base address of the process's MainModule + addr to the address 
            ReadProcessMemory(hProcess, new IntPtr(proc.MainModule.BaseAddress.ToInt64() + addr), buffer, 2, out bytesRead);

            // Convert the bytes to a short and return the result
            return BitConverter.ToInt16(buffer, 0);
        }

        /// <summary>
        /// Write a short value to a specified memory address in the Minecraft process's memory
        /// </summary>
        /// <param name="addr">memory address in the Minecraft process's memory</param>
        /// <param name="value">short value to be written</param>
        public static void WriteShort(long addr, short value)
        {
            // Check inject into the game
            CheckInject();

            // Convert the short value to bytes
            byte[] buffer = BitConverter.GetBytes(value);
            IntPtr bytesWritten;

            // Write the value to the specified memory address
            WriteProcessMemory(hProcess, new IntPtr(proc.MainModule.BaseAddress.ToInt64() + addr), buffer, 2, out bytesWritten);
        }

        #endregion

        #region Byte

        /// <summary>
        /// Read a byte value from a specified memory address in the Minecraft process's memory
        /// </summary>
        /// <param name="addr">memory address in the Minecraft process's memory</param>
        /// <returns>a byte value from a specified memory address</returns>
        public static byte ReadByte(long addr)
        {
            // Check inject into the game
            CheckInject();

            // Create a buffer to store the data that is read from memory
            byte[] buffer = new byte[1];
            IntPtr bytesRead;

            // Read the memory at the address by adding the base address of the process's MainModule + addr to the address 
            ReadProcessMemory(hProcess, new IntPtr(proc.MainModule.BaseAddress.ToInt64() + addr), buffer, 1, out bytesRead);

            // Return the byte that was read
            return buffer[0];
        }

        /// <summary>
        /// Write a byte value to a specified memory address in the Minecraft process's memory
        /// </summary>
        /// <param name="addr">memory address in the Minecraft process's memory</param>
        /// <param name="value">byte value to be written</param>
        public static void WriteByte(long addr, byte value)
        {
            // Check inject into the game
            CheckInject();

            // Create a buffer to store the value
            byte[] buffer = new byte[1] { value };
            IntPtr bytesWritten;

            // Write the value to the specified memory address
            WriteProcessMemory(hProcess, new IntPtr(proc.MainModule.BaseAddress.ToInt64() + addr), buffer, 1, out bytesWritten);
        }

        #endregion

        #region DllImport

        [DllImport("kernel32.dll")]
        static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        #endregion
    }
}