using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrezQuestGame
{
    public class Hero
    {
        public string Name { get; set; }
        public double HP { get; set; }
        public string Armor { get; set; }
        public Hero(string name, double hp)
        {
            Name = name;
            HP = hp;
        }

        public double Bite()
        {
            Random biting = new Random();
            double damage = biting.Next(1, 20);
            return damage;
        }
        public void TakeDamage(double damage)
        {
            HP -= damage;
        }
    }
    
}
