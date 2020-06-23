using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrageR.Models
{
    class Location
    {
        public Locations Name { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Location(float x, float y, float z, Locations name)
        {
            X = x;
            Y = y;
            Z = z;
            Name = name;
        }
        public static List<Location> GetLocations()
        {
            var locs = new List<Location>();
            locs.Add(new Location(-1085.701904f, -3037.571777f, 13.94573784f, Locations.LSAirport));
            locs.Add(new Location(-1524.258789f, -974.5093384f, 10.16818905f, Locations.Pier));
            locs.Add(new Location(-74.73883057f, -819.6027222f, 326.1750488f, Locations.Maze));
            locs.Add(new Location(1878.713989f, 3972.780029f, 34.01015472f, Locations.Sandy));
            locs.Add(new Location(-53.80023575f, 6663.047363f, 27.18950272f, Locations.Paleto));
            locs.Add(new Location(1664.367554f, 4691.213379f, 43.06264877f, Locations.Grapeseed));
            locs.Add(new Location(3574.94751f, 3676.032715f, 33.88866043f, Locations.Humane));
            locs.Add(new Location(239.1478119f, -2040.87561f, 18.01265907f, Locations.Jamestown));
            locs.Add(new Location(29.54866219f, -1846.197754f, 23.67085648f, Locations.Grove));
            locs.Add(new Location(1404.32251f, -644.1864014f, 78.21471405f, Locations.Mirror));
            locs.Add(new Location(-563.5316772f, 5362.556641f, 70.21471405f, Locations.Chilliad));
            return locs;
        }
    }
    enum Locations
    { 
        LSAirport,
        Pier,
        Maze,
        Sandy,
        Paleto,
        Grapeseed,
        Humane,
        Jamestown,
        Grove,
        Mirror,
        Chilliad
    }
}
