using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Proiecte
{
    internal class Program
    {
        // Creati un robot, care sa omoare toate creaturile de pe planeta Pamant.Setati intensitatea(Kill) tipul
        // creaturilor si statusul lor(in viata sau nu).
        static void Main(string[] args)
        {
            Planet earth = new Planet();
            earth.Type = PlanetType.Earth;

            earth.Creatures = new List<Creature>()
            {
                new Creature(){ Type = CreatureType.Animal },
                new Creature(){ Type = CreatureType.SuperHeroe },
                new Creature(){ Type = CreatureType.Human }
            };

            GiantKillerRobot robot = new GiantKillerRobot();
            robot.Planet = earth;

            robot.initialize();

            robot.EyeLaserIntensity = Intensity.Kill;
            robot.Target = new List<CreatureType>() { CreatureType.Animal, CreatureType.SuperHeroe, CreatureType.Human };

            while (robot.Active && earth.ContainsLife)
            {
                if (robot.CurentTarget.IsAlive)
                {
                    Console.WriteLine($"Our Target is : {robot.CurentTarget.Type}");

                    robot.FireLaserAt(robot.CurentTarget);
                    Console.WriteLine($"The Creature Type : {robot.CurentTarget.Type} was killed by Robot: {robot.Name}");

                }

                else
                {
                    robot.AcquireNextTarget();
                }
                //Console.WriteLine($"Acquire next target, the previous was killed");
            }
        }
    }
}
