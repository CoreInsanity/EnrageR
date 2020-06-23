using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using EnrageR;

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
        public long XAxisAddy { get; set; }
        public long YAxisAddy { get; set; }
        public long ZAxisAddy { get; set; }
        public long HealthAddy { get; set; }

        public GTA()
        {
            GtaProc = GetProcess("GTA5");

            new Thread(new ThreadStart(CheckProcessAlive)).Start();

            ResolveAddies();
        }
        

        private Process GetProcess(string procName)
        {
            var proc = Process.GetProcessesByName(procName);
            if (proc.Any()) return proc[0];
            else return null;
        }
        private void ResolveAddies()
        {
            //Get XPos Addy
            XAxisAddy = (long)GtaProc.MainModule.BaseAddress + 0x024ACB48;
            XAxisAddy = ReadInt64(XAxisAddy) + 0x8;
            XAxisAddy = ReadInt64(XAxisAddy) + 0x30;
            XAxisAddy = ReadInt64(XAxisAddy) + 0x50;

            //Get YPos Addy
            YAxisAddy = (long)GtaProc.MainModule.BaseAddress + 0x02E00990;
            YAxisAddy = ReadInt64(YAxisAddy) + 0x10;
            YAxisAddy = ReadInt64(YAxisAddy) + 0x4F8;
            YAxisAddy = ReadInt64(YAxisAddy) + 0x5B0;
            YAxisAddy = ReadInt64(YAxisAddy) + 0x30;
            YAxisAddy = ReadInt64(YAxisAddy) + 0x54;

            //Get ZPos Addy
            ZAxisAddy = (long)GtaProc.MainModule.BaseAddress + 0x024AC5A8;
            ZAxisAddy = ReadInt64(ZAxisAddy) + 0x0;
            ZAxisAddy = ReadInt64(ZAxisAddy) + 0x1C8;
            ZAxisAddy = ReadInt64(ZAxisAddy) + 0xF8;
            ZAxisAddy = ReadInt64(ZAxisAddy) + 0x30;
            ZAxisAddy = ReadInt64(ZAxisAddy) + 0x58;

            //Get Health Addy
            HealthAddy = (long)GtaProc.MainModule.BaseAddress + 0x01C58DA0;
            HealthAddy = ReadInt64(HealthAddy) + 0x280;
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
