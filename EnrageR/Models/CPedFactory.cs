using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrageR.Models
{
    class CPedFactory
    {
        public IntPtr Addy { get; set; }
        public CPedFactory(Helpers.GTA gta)
        {
            var pScan = new Helpers.PatternScan(gta);
            var scanRes = pScan.Find("48 8B 05 ? ? ? ? 45 0F C6", 0, 0, Helpers.ScanMethod.Add);
            Addy = scanRes + gta.ReadInt32((long)scanRes + 0x3) + 0x7;
        }
    }
}
