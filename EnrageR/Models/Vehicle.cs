using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EnrageR.Helpers;

namespace EnrageR.Models
{
    class Vehicle
    {
        private long VehicleAddy;
        private long VehicleHandlingAddy;
        private GTA Gta;

        public Vehicle(GTA gta, long addy)
        {
            Gta = gta;
            VehicleAddy = addy;
            VehicleHandlingAddy = Gta.ReadInt64(VehicleAddy + 0x918);
        }
        public void Reset()
        {
            //TODO: Get the default values, as they're different for each vehicle

            Gravity = 9.8f;
            Acceleration = 1f;
            EngineDamage = 1f;
            CollisionDamage = 1f;
            WeaponDamage = 1f;
            DeformationDamage = 1f;
        }
        public float Gravity
        {
            get
            {
                return Gta.ReadFloat(VehicleAddy + 0xC3C);
            }
            set
            {
                Gta.WriteFloat(VehicleAddy + 0xC3C, value);
            }
        }
        public float Acceleration
        {
            get
            {
                return Gta.ReadFloat(VehicleHandlingAddy + 0x4C);
            }
            set
            {
                Gta.WriteFloat(VehicleHandlingAddy + 0x4C, value);
            }
        }
        public float EngineHealth
        {
            get
            {
                return Gta.ReadFloat(VehicleAddy + 0x8E8);
            }
            set
            {
                Gta.WriteFloat(VehicleAddy + 0x8E8, value);
            }
        }
        public float EngineDamage
        {
            get
            {
                return Gta.ReadFloat(VehicleHandlingAddy + 0xFC);
            }
            set
            {
                Gta.WriteFloat(VehicleHandlingAddy + 0xFC, value);
            }
        }
        public float CollisionDamage
        {
            get
            {
                return Gta.ReadFloat(VehicleHandlingAddy + 0xF0);
            }
            set
            {
                Gta.WriteFloat(VehicleHandlingAddy + 0xF0, value);
            }
        }
        public float WeaponDamage
        {
            get
            {
                return Gta.ReadFloat(VehicleHandlingAddy + 0xF4);
            }
            set
            {
                Gta.WriteFloat(VehicleHandlingAddy + 0xF4, value);
            }
        }
        public float DeformationDamage
        {
            get
            {
                return Gta.ReadFloat(VehicleHandlingAddy + 0xF8);
            }
            set
            {
                Gta.WriteFloat(VehicleHandlingAddy + 0xF8, value);
            }
        }
    }
}
