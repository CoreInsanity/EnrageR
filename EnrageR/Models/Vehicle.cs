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
        private Int64 VehicleAddy;
        private GTA Gta;
        private Thread AutoRepairThread;
        private float Health;

        public Vehicle(GTA gta)
        {
            Gta = gta;
            GetVehicleAddy();
            AutoRepairThread = new Thread(new ThreadStart(AutoRepair));
        }
        private void GetVehicleAddy()
        {
            VehicleAddy = (long)Gta.GtaProc.MainModule.BaseAddress + 0x01F62A08;
            VehicleAddy = Gta.ReadInt64(VehicleAddy) + 0x18;
            VehicleAddy = Gta.ReadInt64(VehicleAddy) + 0x10;
            VehicleAddy = Gta.ReadInt64(VehicleAddy) + 0x8E8;

            if (VehicleAddy < 50000)
            {
                //Assuming player is not in vehicle
                VehicleAddy = -1;
                return;
            }
        }
        public float GetHealth()
        {
            GetVehicleAddy();
            if (VehicleAddy == -1) return -1;
            Health = Gta.ReadFloat(VehicleAddy);
            return Health;
        }
        public void SetHealth(float health)
        {
            GetVehicleAddy();
            if (VehicleAddy == -1) return;
            Gta.WriteFloat(VehicleAddy, health);
            Health = health;
        }
        public void EnableAutoRepair()
        {
            AutoRepairThread = new Thread(new ThreadStart(AutoRepair));
            AutoRepairThread.Start();
        }
        public void DisableAutoRepair()
        {
            AutoRepairThread.Abort();
        }
        private void AutoRepair()
        {
            while (true)
            {
                if (GetHealth() < 1000) SetHealth(1000);
                Thread.Sleep(100);
            }
        }
    }
}
