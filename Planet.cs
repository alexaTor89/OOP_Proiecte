using System.Collections.Generic;
using System.Linq;

namespace OOP_Proiecte
{
    internal class Planet
    {
        public PlanetType Type { get; set; }

        public List<Creature> Creatures { get; set; } = new List<Creature>();   

        public bool ContainsLife => Creatures.Any((w) => w.IsAlive);
    }
}
