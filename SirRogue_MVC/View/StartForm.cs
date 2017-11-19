using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirRogue_MVC
{
    public partial class StartForm : Form
    {
        Controller c;

        public StartForm(Controller c)
        {
            InitializeComponent();
            this.c = c;
        }

        public void SetBindings(DataManager dm)
        {
            hpLabel.DataBindings.Add("Text", dm.Stats, "HP");
            manaLabel.DataBindings.Add("Text", dm.Stats, "Mana");
            attackLabel.DataBindings.Add("Text", dm.Stats, "Attack");
            speedLabel.DataBindings.Add("Text", dm.Stats, "Speed");
        }

        private void questBtn_Click(object sender, EventArgs e)
        {
            c.StartQuest();
        }
    }
}
