using EnrageR.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrageR.Models
{
    class Weapon
    {
        private GTA Gta;
        private long WpAddy;
        private long CurrentWeaponAddy;
        public WeaponBackup Backup;
        public Weapon(GTA gta, long playerAddy)
        {
            Gta = gta;
            WpAddy = Gta.ReadInt64(playerAddy + 0x10C8);
        }
        public bool Update()
        {
            var addy = Gta.ReadInt64(WpAddy + 0x20);
            if (addy == CurrentWeaponAddy) return false;

            if(Backup != null) Reset();
            CurrentWeaponAddy = addy;
            Backup = new WeaponBackup()
            {
                Damage = Damage,
                Range = Range,
                Recoil = Recoil,
                ReloadMultiplier = ReloadMultiplier,
                Spread = Spread
            };
            return true;
        }
        private void Reset()
        {
            ReloadMultiplier = Backup.ReloadMultiplier;
            Recoil = Backup.Recoil;
            Spread = Backup.Spread;
            Range = Backup.Range;
            Damage = Backup.Damage;
        }
        public float ReloadMultiplier
        {
            get
            {
                return Gta.ReadFloat(CurrentWeaponAddy + 0x12C);
            }
            set
            {
                Gta.WriteFloat(CurrentWeaponAddy + 0x12C, value);
            }
        }
        public float Recoil
        {
            get
            {
                return Gta.ReadFloat(CurrentWeaponAddy + 0x2E8);
            }
            set
            {
                Gta.WriteFloat(CurrentWeaponAddy + 0x2E8, value);
            }
        }
        public float Spread
        {
            get
            {
                return Gta.ReadFloat(CurrentWeaponAddy + 0x74);
            }
            set
            {
                Gta.WriteFloat(CurrentWeaponAddy + 0x74, value);
            }
        }
        public float Range
        {
            get
            {
                return Gta.ReadFloat(CurrentWeaponAddy + 0x28C);
            }
            set
            {
                Gta.WriteFloat(CurrentWeaponAddy + 0x28C, value);
            }
        }
        public float Damage
        {
            get
            {
                return Gta.ReadFloat(CurrentWeaponAddy + 0xB0);
            }
            set
            {
                Gta.WriteFloat(CurrentWeaponAddy + 0xB0, value);
            }
        }
    }
    class WeaponBackup
    { 
        public float ReloadMultiplier { get; set; }
        public float Recoil { get; set; }
        public float Spread { get; set; }
        public float Range { get; set; }
        public float Damage { get; set; }
    }
}
