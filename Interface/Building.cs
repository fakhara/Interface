using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Building : IDamageable
    {
        public int Damage { get; set; }
        public int Height { get; set; }

        public Building()
        {
            Damage = 50;    // Standardvärde för skada
            Height = 100;   // Du kan ställa in ett standardvärde för höjden
        }

        // Metod för att hantera att byggnaden tar skada
        public void TakeDamage()
        {
            Console.WriteLine($" Building took {Damage} damage");
        }
    }
}

