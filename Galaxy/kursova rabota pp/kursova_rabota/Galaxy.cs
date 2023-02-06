using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace kursova_rabota.Models
{
    class Galaxy
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Age { get; set; }

        public List<Galaxy> Galaxies;

        public Galaxy(string name, string type, string age) 
        {
            this.Name = name;
            this.Type = type;
            this.Age = age;

            this.Galaxies = new List<Galaxy>();
        }

        public void AddGalaxy(string name, string type, string age)
        {   
            if (name == null || type == null || age == null)
            {
                Console.WriteLine("Not all fields have been filled!");
            }
            else
            {
                Galaxy galaxy = new Galaxy(name, type, age);
                this.Galaxies.Add(galaxy);
            }
        }

        public string ListGalaxies()
        {
            List<string> galaxyList = this.Galaxies.Select(x => x.Name).ToList();
            string galaxies = String.Join("\n", galaxyList);

            return
                "-- List of all reserached galaxies -- \n" +
                galaxies + "\n" +
                "-- End of galaxies list --";
        }
    }
}
