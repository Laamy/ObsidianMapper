using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MemoryReaderExample
{
    public class MMR
    {
        // Declare a variable to store the process and a variable to store the handle to the process
        static Process proc;

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
        }

        /// <summary>
        /// Reads memory from the target process and returns the value of type T at the specified offset.
        /// </summary>
        /// <typeparam name="T">The type of the value to be read from memory.</typeparam>
        /// <param name="offset">The offset in the target process's memory to read from.</param>
        /// <returns>The value read from memory of type T.</returns>
        public static T ReadMemory<T>(long offset) where T : struct
        {
            CheckInject();

            // Get the size of the data to be read
            int size = Marshal.SizeOf<T>();

            // Allocate memory for the buffer
            IntPtr buffer = Marshal.AllocHGlobal(size);

            // Read the data from memory
            ReadProcessMemory(proc.Handle, proc.MainModule.BaseAddress.ToInt64() + offset, buffer, size, out _);

            // Convert the data to the desired type
            T result = Marshal.PtrToStructure<T>(buffer);

            // Free the allocated memory
            Marshal.FreeHGlobal(buffer);

            // Return the result
            return result;
        }

        /// <summary>
        /// Writes the specified value of type T to memory in the target process at the specified offset.
        /// </summary>
        /// <typeparam name="T">The type of the value to be written to memory.</typeparam>
        /// <param name="offset">The offset in the target process's memory to write to.</param>
        /// <param name="value">The value to be written to memory of type T.</param>
        public static void WriteMemory<T>(long offset, T value) where T : struct
        {
            CheckInject();

            // Get the size of the data to be written
            int size = Marshal.SizeOf<T>();

            // Allocate memory for the buffer
            IntPtr buffer = Marshal.AllocHGlobal(size);

            // Copy the value to be written into the buffer in the correct format
            Marshal.StructureToPtr(value, buffer, true);

            // Write the data to memory
            WriteProcessMemory(proc.Handle, proc.MainModule.BaseAddress.ToInt64() + offset, buffer, size, out _);

            // Free the allocated memory
            Marshal.FreeHGlobal(buffer);
        }

        #region DllImport

        [DllImport("kernel32.dll")]
        static extern bool ReadProcessMemory(IntPtr hProcess, long lpBaseAddress, [Out] IntPtr lpBuffer, int dwSize, out IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(IntPtr hProcess, long lpBaseAddress, IntPtr lpBuffer, int nSize, out IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        #endregion
    }
}