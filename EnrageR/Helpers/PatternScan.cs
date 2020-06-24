using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrageR.Helpers
{
    class PatternScan
    {
        private IntPtr baseAddress;

        private byte[] dump;

        public IntPtr BaseAddress { get { return baseAddress; } }

        public PatternScan(GTA gta)
        {
            gta.GtaProc.Refresh();

            baseAddress = gta.GtaProc.MainModule.BaseAddress;

            dump = gta.ReadByteArray((long)baseAddress, gta.GtaProc.MainModule.ModuleMemorySize);
        }
        public IntPtr Find(string mask, int patternOffset, int addressOffset, ScanMethod method)
        {
            return Find(MaskToPattern(mask), patternOffset, addressOffset, method);
        }

        public IntPtr Find(byte[] pattern, int patternOffset, int addressOffset, ScanMethod method)
        {
            int length = pattern.Length;
            int i = 0;
            int k = 0;

            int loopDist = dump.Length - length;

            while (i < loopDist)
            {
                if (pattern[k] == 0x00 || dump[i] == pattern[k])
                {
                    k++;
                    if (k == length)
                        break;
                }
                else
                {
                    i -= k;
                    k = 0;
                }
                i++;
            }

            int address = i - k + 1;

            if (address < 1)
                return IntPtr.Zero;

            switch (method)
            {
                case ScanMethod.None:
                    return (IntPtr)(address + patternOffset + addressOffset);
                case ScanMethod.Add:
                    return baseAddress + address + patternOffset + addressOffset;
                case ScanMethod.Subtract:
                    return baseAddress - address + patternOffset + addressOffset;
            }

            return (IntPtr)address;
        }

        private byte[] MaskToPattern(string mask)
        {
            string[] numbers = mask.StartsWith(@"\x") ? mask.Split('\\', 'x') : mask.Split(' ');

            byte[] pattern = new byte[numbers.Length];

            for (int i = 0; i < pattern.Length; i++)
            {
                if (numbers[i].StartsWith("?"))
                {
                    pattern[i] = 0x00;
                }
                else
                {
                    pattern[i] = byte.Parse(numbers[i], NumberStyles.HexNumber);
                }
            }

            return pattern;
        }
    }
    public enum ScanMethod
    {
        None,
        Add,
        Subtract,
        Read,
        ReadAndSubtract
    }
}
