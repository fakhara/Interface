using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class TreasurChest : IDamageable
    {
        public int Damage { get; set; }
        public int Value { get; set; }

        public TreasurChest()
        {
            Damage = 20;
            Value = 100;
        }

        public void TakeDamage()
        {
            Console.WriteLine($"Chest took {Damage} damage");
        }
    }
}
