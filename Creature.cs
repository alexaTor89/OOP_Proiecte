namespace OOP_Proiecte
{
    class Creature
    {
        private int health = 100;

        public CreatureType Type { get; set; }

        public bool IsAlive => health > 0;

        public void LaserShoot(int intensity)
        {

            if (IsAlive)
            {
                health = health - intensity;
            }
        }
    }
}
