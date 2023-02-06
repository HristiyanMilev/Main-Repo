using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace kursova_rabota.Models
{
    class Moon
    {
        public string PlanetName { get; set; }
        public string Name { get; set; }

        public List<Moon> Moons;

        public Moon(string planetName, string name)
        {
            this.PlanetName = planetName;
            this.Name = name;

            this.Moons = new List<Moon>();
        }

        public void AddMoon(string planetName, string name)
        {
            if (name == null)
            {
                Console.WriteLine("Not all fields have been filled!");
            }
            else
            {
                Moon moon = new Moon(planetName, name);
                this.Moons.Add(moon);
            }
        }

        public string ListMoons()
        {
            List<string> moonList = this.Moons.Select(x => x.Name).ToList();
            string moons = String.Join("\n", moonList);

            return
                "-- List of all reserached moons -- \n" +
                moons + "\n" +
                "-- End of moons list --";
        }
    }
}
