using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirRogue_MVC
{
    public class Controller
    {
        DataManager dm;

        public Controller(DataManager dm)
        {
            this.dm = dm;
        }

        public void StartGame()
        {
            StartForm form = new StartForm(this);
            form.SetBindings(dm);
            Application.Run(form);
        }

        public void StartQuest()
        {
            QuestForm form = new QuestForm(this);
            form.ShowDialog();
        }

        public void ModifyStats(string hp, string mana, string attack, string speed)
        {
            double _hp = Convert.ToDouble(hp);
            double _mana = Convert.ToDouble(mana);
            double _attack = Convert.ToDouble(attack);
            double _speed = Convert.ToDouble(speed);
            dm.Stats.AddModifier(_hp, _mana, _attack, _speed);
        }

    }
}
