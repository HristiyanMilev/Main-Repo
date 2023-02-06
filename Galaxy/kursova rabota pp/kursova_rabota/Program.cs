using System;
using kursova_rabota.Models;

namespace kursova_rabota
{
    class Program
    {
        static void Main()
        {
            Registry registry = new Registry();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');

                if (input[0] == "exit")
                    break;

                if (input[0] == "stats")
                {
                    Console.WriteLine(registry.DisplayStats());
                }
                if (input[0] == "print")
                {
                    Console.WriteLine(registry.PrintGalaxy(input[1]));
                }

                if (input[0] == "list")
                {
                    if (input[1] == "galaxies")
                        Console.WriteLine(registry.galaxy.ListGalaxies());
                    else if (input[1] == "stars")
                        Console.WriteLine(registry.star.ListStars());
                    else if (input[1] == "planets")
                        Console.WriteLine(registry.planet.ListPlanets());
                    else if (input[1] == "moons")
                        Console.WriteLine(registry.moon.ListMoons());
                }
                else if (input[0] == "add")
                {
                    if (input[1] == "galaxy")
                        registry.galaxy.AddGalaxy(input[2] ?? null, input[3] ?? null, input[4] ?? null);
                    else if (input[1] == "star")
                        registry.star.AddStar(input[2] ?? null, input[3] ?? null, float.Parse(input[4] ?? null), float.Parse(input[5] ?? null), int.Parse(input[6] ?? null), float.Parse(input[7] ?? null));
                    else if (input[1] == "planet")
                        registry.planet.AddPlanet(input[2] ?? null, input[3] ?? null, input[4] ?? null, input[5] ?? null);
                    else if (input[1] == "moon")
                        registry.moon.AddMoon(input[2] ?? null, input[3] ?? null);

                }
            }
        }

    }
}