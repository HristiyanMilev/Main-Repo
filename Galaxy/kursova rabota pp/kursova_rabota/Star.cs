using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace kursova_rabota.Models
{
    class Star
    {
        public string GalaxyName { get; set; }
        public string Name { get; set; }
        public float? Mass { get; set; }
        public float? Size { get; set; }
        public int? Temperature { get; set; }
        public float? Brightness { get; set; }
        public string Class
        {
            get 
            {
                if ((this.Temperature >= 2400 && this.Temperature <= 3700) && this.Brightness <= 0.08 && (this.Mass >= 0.08 && this.Mass <= 0.45) && this.Size <= 0.7)
                    return "M";
                else if ((this.Temperature >= 3700 && this.Temperature <= 5200) && (this.Brightness >= 0.08 && this.Brightness <= 0.6) && (this.Mass >= 0.45 && this.Mass <= 0.8) && (this.Size >= 0.7 && this.Size <= 0.96))
                    return "K";
                else if ((this.Temperature >= 5200 && this.Temperature <= 6000) && (this.Brightness >= 0.6 && this.Brightness <= 1.5) && (this.Mass >= 0.8 && this.Mass <= 1.04) && (this.Size >= 0.96 && this.Size <= 1.15))
                    return "G";
                else if ((this.Temperature >= 6000 && this.Temperature <= 7500) && (this.Brightness >= 1.5 && this.Brightness <= 5) && (this.Mass >= 1.04 && this.Mass <= 1.4) && (this.Size >= 1.15 && this.Size <= 1.4))
                    return "F";
                else if ((this.Temperature >= 7500 && this.Temperature <= 10000) && (this.Brightness >= 5 && this.Brightness <= 25) && (this.Mass >= 1.4 && this.Mass <= 2.1) && (this.Size >= 1.4 && this.Size <= 1.8))
                    return "A";
                else if ((this.Temperature >= 10000 && this.Temperature <= 30000) && (this.Brightness >= 25 && this.Brightness <= 30000) && (this.Mass >= 2.1 && this.Mass <= 16) && (this.Size >= 1.8 && this.Size <= 6.6))
                    return "B";
                else if (this.Temperature >= 30000 && this.Brightness >= 30000 && this.Mass >= 16 && this.Size >= 6.6)
                    return "O";
                return null;
            }
        }

        public List<Star> Stars;
        public List<Planet> Planets;

        public Star(string galaxyName, string name, float? mass, float? size, int? temperature, float? brightness) 
        {
            this.GalaxyName = galaxyName;
            this.Name = name;
            this.Mass = mass;
            this.Size = size;
            this.Temperature = temperature;
            this.Brightness = brightness;

            this.Stars = new List<Star>();
            this.Planets = new List<Planet>();
        }

        public void AddStar(string galaxyName, string name, float? mass, float? size, int? temperature, float? brightness)
        {
            if (galaxyName == null || name == null || mass == null || size == null || temperature == null || brightness == null)
            {
                Console.WriteLine("Not all fields have been filled!");
            }
            else
            {
                Star star = new Star(galaxyName, name, (float)mass, (float)size, (int)temperature, (float)brightness);
                this.Stars.Add(star);
            }
        }

        public string ListStars()
        {
            List<string> starList = this.Stars.Select(x => x.Name).ToList();
            string stars = String.Join("\n", starList);

            return
                "-- List of all reserached stars -- \n" +
                stars + "\n" +
                "-- End of stars list --";
        }
    }
}
