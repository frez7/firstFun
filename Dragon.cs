using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrezQuestGame
{
    public class Dragon
    {
        private string _name;
        public double damage;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name == "Pizduk")
                {
                    damage = 5;
                    Damage = damage;
                    
                    _name = value;
                }
                else
                {
                    Damage = 25;
                    Damage = damage;
                    _name = value;
                }
            }
        }
        public double Damage { get; set; }
        public double HP { get; set; }
        public Dragon(string name, double hp)
        {
            Name = name;
            HP = hp;
        }
        public void TakeDamage(double damage)
        {
            HP -= damage;
        }

        public double Incinerate()
        {
            Random random = new Random();
            int damageChoose = random.Next(1, 5);
            switch (damageChoose)
            {
                case 0: 
                    return damage = 20;
                    break;
                case 1: 
                    return damage = 30;
                    break;
                case 2: 
                    return damage = 20;
                    break;
                case 3: 
                    return damage = 500;
                    break;
                case 4: 
                    return damage = 20;
                    break;
                case 5:
                    return damage = 30;
                    break;
                default:
                    break;
            }
            return damage;
        }
    }
}
