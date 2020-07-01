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
        public CPedFactory(Helpers.GTA gta, GtaType type)
        {
            switch (type)
            {
                case GtaType.AUTO:
                    var pScan = new Helpers.PatternScan(gta);
                    var scanRes = pScan.Find("48 8B 05 ? ? ? ? 45 0F C6", 0, 0, Helpers.ScanMethod.Add);
                    Addy = scanRes + gta.ReadInt32((long)scanRes + 0x3) + 0x7;
                    break;
                case GtaType.ROCKSTAR:
                    Addy = new IntPtr((long)gta.GtaProc.MainModule.BaseAddress + 0x24ACB48);
                    break;
                case GtaType.STEAM:
                    Addy = new IntPtr((long)gta.GtaProc.MainModule.BaseAddress + 0x24B0C50);
                    break;
                case GtaType.EPIC:
                    Addy = new IntPtr((long)gta.GtaProc.MainModule.BaseAddress + 0x24AECE0);
                    break;

            }
            
        }
    }
    enum GtaType
    { 
        ROCKSTAR,
        STEAM,
        EPIC,
        AUTO
    }
}
