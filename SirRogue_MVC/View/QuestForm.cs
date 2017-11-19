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
    public partial class QuestForm : Form
    {
        Controller c;

        public QuestForm(Controller c)
        {
            InitializeComponent();
            this.c = c;
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            c.ModifyStats(hpBox.Text, manaBox.Text, attackBox.Text, speedBox.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
