using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrezQuestGame
{
    public class Weapon
    {
        public string Name { get; set; }
        public double Damage { get; set; }
        public string Category { get; set; }
        public Weapon(string name, double damage, string category)
        {
            Name = name;
            Damage = damage;
            Category = category;
        }
    }
}
