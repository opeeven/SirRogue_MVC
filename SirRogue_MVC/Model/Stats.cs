using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirRogue_MVC
{
    public class Stats: INotifyPropertyChanged
    {
        public double HP { get; private set; }
        public double Mana { get; private set; }
        public double Attack { get; private set; }
        public double Speed { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public Stats(double h, double m, double a, double s)
        {
            HP = h;
            Mana = m;
            Attack = a;
            Speed = s;
        }

        public void AddModifier(double Mod, string type)//callback???
        {
            switch (type)
            {
                case "HP":
                    HP += Mod;
                    PropertyChanged(this, new PropertyChangedEventArgs("HP"));
                    break;
                case "Mana":
                    Mana += Mod;
                    PropertyChanged(this, new PropertyChangedEventArgs("Mana"));
                    break;
                case "Attack":
                    Attack += Mod;
                    PropertyChanged(this, new PropertyChangedEventArgs("Attack"));
                    break;
                case "Speed":
                    Speed += Mod;
                    PropertyChanged(this, new PropertyChangedEventArgs("Speed"));
                    break;
                default:
                    throw new Exception("Wrong type!");
            }
        }

        public void AddModifier(double hp, double mana, double attack, double speed)
        {
            HP = HP + hp;
            PropertyChanged(this, new PropertyChangedEventArgs("HP"));
            Mana += mana;
            PropertyChanged(this, new PropertyChangedEventArgs("Mana"));
            Attack += attack;
            PropertyChanged(this, new PropertyChangedEventArgs("Attack"));
            Speed += speed;
            PropertyChanged(this, new PropertyChangedEventArgs("Speed"));
        }

    }
}
