using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace kursova_rabota.Models
{
    class Registry
    {
        public Galaxy galaxy = new Galaxy(null, null, null);
        public Star star = new Star(null, null, null, null, null, null);
        public Planet planet = new Planet(null, null, null, null);
        public Moon moon = new Moon(null, null);

        public string DisplayStats()
        {
            return
                "-- Stats -- \n" +
                "Galaxies: " + galaxy.Galaxies.Count + "\n" +
                "Stars: " + star.Stars.Count + "\n" +
                "Planets: " + planet.Planets.Count + "\n" +
                "Moons: " + moon.Moons.Count + "\n" +
                "-- End of stats --";
        }

        public string PrintGalaxy(string galaxy)
        {
            Galaxy gal = this.galaxy.Galaxies.Where(x => x.Name == galaxy).FirstOrDefault();
            List<Star> stars = gal != null ? star.Stars.Where(x => x.GalaxyName == gal.Name).ToList() : new List<Star>();

            if (stars.Count > 0)
            {
                stars.ForEach(x =>
                {
                    x.Planets = planet.Planets.Where(y => y.StarName == x.Name).ToList();
                    x.Planets.ForEach(z => z.Moons = moon.Moons.Where(g => g.PlanetName == z.Name).ToList());
                });
            }

            List<string> starsOut = new List<string>();
            if (gal != null)
            {
                starsOut.Add($"Type: {gal.Type}");
                starsOut.Add($"Age: {gal.Age}");
                if (stars.Count > 0)
                {
                    starsOut.Add("Stars: ");
                    foreach (Star star in stars)
                    {
                        starsOut.Add($"     Name: {star.Name}");
                        starsOut.Add($"     Class: {star.Class}");
                        if (star.Planets.Count > 0)
                        {
                            starsOut.Add("     Planets: ");
                            foreach (Planet planet in star.Planets)
                            {
                                starsOut.Add($"         Name: {planet.Name}");
                                starsOut.Add($"         Type: {planet.Type}");
                                string isInh = (bool)planet.IsInhabitable ? "yes" : "no";
                                starsOut.Add($"         Support life: {isInh}");
                                if (planet.Moons.Count > 0)
                                {
                                    starsOut.Add("         Moons: ");
                                    foreach (Moon moon in planet.Moons)
                                    {
                                        starsOut.Add($"             Name: {moon.Name}");
                                    }
                                }
                                else
                                {
                                    starsOut.Add("         Moons: None");
                                }

                            }
                        }
                        else
                        {
                            starsOut.Add("     Planets: None");
                        }
                    }
                }
                else
                {
                    starsOut.Add("Stars: None");
                }
            }

            return
                $"--- Data for {galaxy} galaxy --- \n" +
                String.Join("\n", starsOut) + "\n" +
                $"-- - End of data for {galaxy} galaxy-- -";
        }
    }
}
