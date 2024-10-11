using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Goblin : IDamageable
    {
        public int Damage { get; set; }
        public int HP { get; set; }

        public Goblin()
        {
            Damage = 100;
            HP = 200; // du kan stæælla in ett standardvärde för HP om du vill
        }

        // metod för att hantera att goblinen tar skada
        public void TakeDamage()
        {
            Console.WriteLine($"Goblin took {Damage} damage");
            HP -= Damage; // Goblinen tar skada och HP minska
            Console.WriteLine($" Goblin's remaining HP: {HP}");
        }
    }
}
