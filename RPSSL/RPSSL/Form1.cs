using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPSSL_dll;

namespace RPSSL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pbx_robot_Click(object sender, EventArgs e)
        {

        }

        private void pbx_pirate_Click(object sender, EventArgs e)
        {

        }

        private void pbx_ninja_Click(object sender, EventArgs e)
        {

        }

        private void pbx_monkey_Click(object sender, EventArgs e)
        {

        }

        private void pbx_zombie_Click(object sender, EventArgs e)
        {

        }

        private void btn_instructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Robot: schlägt Zombie und Ninja \nPirate: schlägt Robot und Monkey \nNinja: schlägt Pirate und Zombie \nMonkey: schlägt Ninja und Robot \nZombie: schlägt Monkey und Pirate");
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {

        }

        private void pbx_minun_Click(object sender, EventArgs e)
        {

        }

        private void pbx_melkor_Click(object sender, EventArgs e)
        {

        }
    }
}
