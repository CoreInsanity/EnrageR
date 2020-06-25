using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using EnrageR.Models;

namespace EnrageR.Helpers
{
    class GTA
    {
        #region WIN32API stuff
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool ReadProcessMemory(IntPtr hProcess, Int64 lpBaseAddress, [In, Out] byte[] lpBuffer, UInt64 dwSize, out IntPtr lpNumberOfBytesRead);
        [DllImport("kernel32.dll")]
        private static extern bool WriteProcessMemory(IntPtr hProcess, Int64 lpBaseAddress, [In, Out] byte[] lpBuffer, UInt64 dwSize, out IntPtr lpNumberOfBytesWritten);
        #endregion

        public Process GtaProc { get; set; }
        public long CPedFactory { get; set; }

        public GTA()
        {
            GtaProc = GetProcess("GTA5");

            new Thread(new ThreadStart(CheckProcessAlive)).Start();

            GetWorldAddy();
        }
        

        private Process GetProcess(string procName)
        {
            var proc = Process.GetProcessesByName(procName);
            if (proc.Any()) return proc[0];
            else return null;
        }
        private void GetWorldAddy()
        {
            var fact = new CPedFactory(this);
            CPedFactory = ReadInt64((long)fact.Addy);
        }

        #region reading
        public long ReadInt64(long addr)
        {
            byte[] Buffer = new byte[8];
            IntPtr ByteRead;
            ReadProcessMemory(GtaProc.Handle, addr, Buffer, 8, out ByteRead);
            return BitConverter.ToInt64(Buffer, 0);
        }

        public Int32 ReadInt32(long addr)
        {
            byte[] Buffer = new byte[4];
            IntPtr ByteRead;
            ReadProcessMemory(GtaProc.Handle, addr, Buffer, 4, out ByteRead);
            return BitConverter.ToInt32(Buffer, 0);
        }

        public float ReadFloat(long addr)
        {
            byte[] Buffer = new byte[sizeof(float)];
            IntPtr ByteRead;
            ReadProcessMemory(GtaProc.Handle, addr, Buffer, sizeof(float), out ByteRead);
            return BitConverter.ToSingle(Buffer, 0);
        }
        public byte ReadByte(long addr)
        {
            byte[] Buffer = new byte[sizeof(byte)];
            IntPtr ByteRead;
            ReadProcessMemory(GtaProc.Handle, addr, Buffer, sizeof(byte), out ByteRead);
            return Buffer[0];
        }
        public byte[] ReadByteArray(long address, int length)
        {
            byte[] buffer = new byte[length];
            IntPtr ByteRead;
            ReadProcessMemory(GtaProc.Handle, address, buffer, (ulong)length, out ByteRead);
            return buffer;
        }
        public string ReadString(long addr)
        {
            byte[] buffer = new byte[512];
            IntPtr BytesRead;
            ReadProcessMemory(GtaProc.Handle, addr, buffer, 512, out BytesRead);
            return Encoding.ASCII.GetString(buffer).Split('\0')[0];
        }
        #endregion
        #region writing
        public bool WriteMemory(long addr, byte[] Buffer)
        {
            IntPtr ptrBytesWritten;
            WriteProcessMemory(GtaProc.Handle, addr, Buffer, (uint)Buffer.Length, out ptrBytesWritten);
            return ((IntPtr)Buffer.Length == ptrBytesWritten);
        }

        public bool WriteFloat(long addr, float _Value)
        {
            byte[] Buffer = BitConverter.GetBytes(_Value);
            return WriteMemory(addr, Buffer);
        }

        public bool WriteInt32(long addr, int _Value)
        {
            byte[] Buffer = BitConverter.GetBytes(_Value);
            return WriteMemory(addr, Buffer);
        }
        public bool WriteInt64(long addr, long _Value)
        {
            byte[] bytes = BitConverter.GetBytes(_Value);
            return WriteMemory(addr, bytes);
        }
        public bool WriteString(long addr, string _Value)
        {
            byte[] Buffer = Encoding.ASCII.GetBytes(_Value);
            return WriteMemory(addr, Buffer);
        }
        public bool WriteByte(long addr, byte _Value)
        {
            byte[] Buffer = BitConverter.GetBytes(_Value);
            return WriteMemory(addr, Buffer);
        }
        #endregion

        #region threads
        private void CheckProcessAlive()
        {
            if (GtaProc == null)
            {
                MessageBox.Show("Game module not found, exiting...");
                Environment.Exit(0);
            }
            while (true)
            {
                try
                {
                    Process.GetProcessById(GtaProc.Id);
                    Thread.Sleep(2500);
                }
                catch
                {
                    //Process ded
                    Environment.Exit(0);
                }
            }
        }
        #endregion
    }
}
