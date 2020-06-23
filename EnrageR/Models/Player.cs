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
        private float Health;
        private GTA Gta;
        private Location Location;
        private Thread AutoHealThread;

        public Player(GTA gta)
        {
            Gta = gta;
            AutoHealThread = new Thread(new ParameterizedThreadStart(AutoHeal));
        }
        public Location GetLocation()
        {
            Location = new Location(
                Gta.ReadFloat(Gta.XAxisAddy),
                Gta.ReadFloat(Gta.YAxisAddy),
                Gta.ReadFloat(Gta.ZAxisAddy),
                Locations.Grapeseed);
            return Location;
        }
        public void SetLocation(Location loc)
        {
            Gta.WriteFloat(Gta.XAxisAddy, loc.X);
            Gta.WriteFloat(Gta.YAxisAddy, loc.Y);
            Gta.WriteFloat(Gta.ZAxisAddy, loc.Z);
            Location = loc;
        }
        public void SetHealth(float value)
        {
            Gta.WriteFloat(Gta.HealthAddy, value);
            Health = value;
        }
        public double GetHealth()
        {
            Health = Gta.ReadFloat(Gta.HealthAddy);
            return Health;
        }
        public void EnableAutoHeal(int delay, float health)
        {
            AutoHealThread = new Thread(new ParameterizedThreadStart(AutoHeal));
            AutoHealThread.Start(new HealingParms() { Health = health, Delay = delay });
        }
        public void DisableAutoHeal()
        {
            AutoHealThread.Abort();
        }
        private void AutoHeal(object parms)
        {
            var parmsCast = (HealingParms)parms;
            while (true)
            {
                
                if (GetHealth() < parmsCast.Health) SetHealth(parmsCast.Health);
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
