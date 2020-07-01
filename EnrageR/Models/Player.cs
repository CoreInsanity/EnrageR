using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EnrageR.Helpers;

namespace EnrageR.Models
{
    class Player
    {
        private GTA Gta;
        private long PlayerAddy;
        private long PlayerInfoAddy;
        private Thread AutoHealThread;
        public Vehicle LastVehicle;

        public Player(GTA gta)
        {
            Gta = gta;
            AutoHealThread = new Thread(new ParameterizedThreadStart(AutoHeal));
            PlayerAddy = Gta.ReadInt64(Gta.CPedFactory + 0x8);
            PlayerInfoAddy = Gta.ReadInt64(PlayerAddy + 0x10B8);
        }
        public Location Location
        {
            get 
            {
                return new Location(Gta.ReadFloat(PlayerAddy + 0x90), Gta.ReadFloat(PlayerAddy + 0x94), Gta.ReadFloat(PlayerAddy + 0x98), Locations.LSAirport);
            }
            set
            {
                var radar = Gta.ReadInt64(PlayerAddy + 0x30);
                Gta.WriteFloat(radar + 0x50, value.X);
                Gta.WriteFloat(radar + 0x54, value.Y);
                Gta.WriteFloat(radar + 0x58, value.Z);

                Gta.WriteFloat(PlayerAddy + 0x90, value.X);
                Gta.WriteFloat(PlayerAddy + 0x94, value.Y);
                Gta.WriteFloat(PlayerAddy + 0x98, value.Z);
            }
        }
        public float Health
        {
            get
            {
                return Gta.ReadFloat(PlayerAddy + 0x280);
            }
            set
            {
                if (value > 0) Gta.WriteFloat(PlayerAddy + 0x280, value);
            }
        }
        public bool IsInVehicle
        {
            get
            {
                var read = Gta.ReadByte(PlayerAddy + 0x146B);
                if (read != 20) return true;
                return false;
            }
        }
        public string Name
        {
            get
            {
                return Gta.ReadString(PlayerInfoAddy + 0x7C);
            }
        }
        public float RunSpeed
        {
            get
            {
                return Gta.ReadFloat(PlayerInfoAddy + 0x14C);
            }
            set
            {
                Gta.WriteFloat(PlayerInfoAddy + 0x14C, value);
            }
        }
        public float SwimSpeed
        {
            get
            {
                return Gta.ReadFloat(PlayerInfoAddy + 0x148);
            }
            set
            {
                Gta.WriteFloat(PlayerInfoAddy + 0x148, value);
            }
        }
        public Vehicle CurrentVehicle
        {
            get
            {
                if (!IsInVehicle) return null;
                LastVehicle = new Vehicle(Gta, Gta.ReadInt64(PlayerAddy + 0xD28));
                return LastVehicle;
            }
        }

        public void EnableAutoHeal(int delay, float health)
        {
            AutoHealThread = new Thread(new ParameterizedThreadStart(AutoHeal));
            AutoHealThread.Start(new HealingParms() { Health = health, Delay = delay });
        }
        public void DisableAutoHeal()
        {
            AutoHealThread.Abort();
            Health = 200;
        }


        private void AutoHeal(object parms)
        {
            var parmsCast = (HealingParms)parms;
            while (true)
            {
                
                if (Health < parmsCast.Health) Health = parmsCast.Health;
                Thread.Sleep(parmsCast.Delay);
            }
        }
    }
    class HealingParms
    {
        public int Delay { get; set; }
        public float Health { get; set; }
    }
}
