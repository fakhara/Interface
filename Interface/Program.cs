namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IDamageable> damageablesObjects = new List<IDamageable>();

            // Skapa olika objekt som implementerar IDamageable
            Goblin goblin = new Goblin();
            Building building = new Building();
            TreasurChest chest = new TreasurChest();

            // Lägg till objekten i listen
            damageablesObjects.Add(goblin);
            damageablesObjects.Add(building);
            damageablesObjects.Add(chest);
            // Gå igonom listan och applicera skada på alla objekt
            foreach(var obj in damageablesObjects)
            {
                obj.TakeDamage();
            }

        }
    }
}