using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_Proiecte
{
    internal class GiantKillerRobot
    {
        public string Name { get; set; }
        public int EyeLaserIntensity { get; set; } = 0;

        public List<CreatureType> Target { get; set; } = new List<CreatureType>();

        public bool Active { get; set; }

        public Creature CurentTarget { get; set; }

        public Planet Planet { get; set; } = new Planet();

        public void initialize()
        {
            Name = "Baymax";
            Active = true;
            Target = new List<CreatureType>();
            EyeLaserIntensity = 10;

            AcquireNextTarget();    
        }

        public void FireLaserAt(Creature curentTarget)
        {
            bool isAtarget = Target.Any((target) => target == curentTarget.Type);
            if (isAtarget)
            {
                curentTarget.LaserShoot(EyeLaserIntensity);
            }
        }

        public void AcquireNextTarget()
        {
            Random rnd = new Random();

            int creatureNumber = Planet.Creatures.Count;
            int creatureSelection = rnd.Next(creatureNumber);

            CurentTarget = Planet.Creatures[creatureSelection];
        }
    }
}
