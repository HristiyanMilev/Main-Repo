using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace kursova_rabota.Models
{
    class Planet
    {
        public string StarName { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool? IsInhabitable { get; set; }

        public List<Planet> Planets;

        public List<Moon> Moons;

        public Planet(string starName, string name, string type, bool? isInhabitable) 
        {
            this.StarName = starName;
            this.Name = name;
            this.Type = type;
            this.IsInhabitable = isInhabitable;

            this.Planets = new List<Planet>();
            this.Moons = new List<Moon>();
        }
        public void AddPlanet(string starName, string name, string type, string isInhabitable)
        {
            if (starName == null || name == null || type == null || isInhabitable == null)
            {
                Console.WriteLine("Not all fields have been filled!");
            }
            else
            {
                bool isInh = isInhabitable == "yes" ? true : false;
                Planet planet = new Planet(starName, name, type, isInh);
                this.Planets.Add(planet);
            }
        }

        public string ListPlanets()
        {
            List<string> planetList = this.Planets.Select(x => x.Name).ToList();
            string planets = String.Join("\n", planetList);

            return
                "-- List of all reserached planets -- \n" +
                planets + "\n" +
                "-- End of planets list --";
        }
    }
}
