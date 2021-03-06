﻿using System;
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
        public Weapon Weapon;

        public Player(GTA gta)
        {
            Gta = gta;
            AutoHealThread = new Thread(new ParameterizedThreadStart(AutoHeal));
            PlayerAddy = Gta.ReadInt64(Gta.CPedFactory + 0x8);
            PlayerInfoAddy = Gta.ReadInt64(PlayerAddy + 0x10B8);
            Weapon = new Weapon(Gta, PlayerAddy);
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
        public Location Waypoint
        {
            get
            { 
                var baseAddy = (long)Gta.GtaProc.MainModule.BaseAddress;
                return new Location(Gta.ReadFloat(baseAddy + 0x1F43408), Gta.ReadFloat(baseAddy + 0x1F4340C), 15, Locations.Waypoint);
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
        public VehicleStatus VehicleStatus
        {
            get
            {
                switch (Gta.ReadByte(PlayerAddy + 0x146B))
                {
                    case 20:
                        return VehicleStatus.OUT;
                    case 4:
                        return VehicleStatus.TRANS;
                    case 12:
                        return VehicleStatus.IN;
                    default:
                        return VehicleStatus.TRANS;
                }
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
                if (VehicleStatus == VehicleStatus.IN || VehicleStatus == VehicleStatus.TRANS)
                {
                    LastVehicle = new Vehicle(Gta, Gta.ReadInt64(PlayerAddy + 0xD28));
                    return LastVehicle;
                }
                else return null;
            }
        }

        public void EnableAutoHeal(int delay)
        {
            AutoHealThread = new Thread(new ParameterizedThreadStart(AutoHeal));
            AutoHealThread.Start(delay);
        }
        public void DisableAutoHeal()
        {
            AutoHealThread.Abort();
        }


        private void AutoHeal(object parms)
        {
            var delay = (int)parms;
            var health = Health;
            while (true)
            {
                if (Health != health) Health = health;
                Thread.Sleep(delay);
            }
        }
    }
}
