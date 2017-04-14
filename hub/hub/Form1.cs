using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hub
{
    public partial class Form1 : Form
    {
        Entity me;
        Entity enemy = new Entity(1);

        public Form1(Entity user)
        {
            InitializeComponent();
            me = user;

            myBar.Value = me._health;
            enemyBar.Value = enemy._health;

            if ((me._speed >= enemy._speed && me._went == false) || (me._went == false && enemy._went == true)) me._turn = true;
            else enemy._turn = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
