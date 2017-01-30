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
        string m_meldung;
        int m_wert;
        public Form1()
        {
            InitializeComponent();
        }

        private void pbx_robot_Click(object sender, EventArgs e)
        {
            int m_wert = 1;
            pbx_melkor.Image = Image.FromFile("C:/Users/Saturn/Documents/Visual Studio 2015/Projects/RPSSL/robot.png");
        }

        private void pbx_pirate_Click(object sender, EventArgs e)
        {
            int m_wert = 2;
            pbx_melkor.Image = Image.FromFile("C:/Users/Saturn/Documents/Visual Studio 2015/Projects/RPSSL/pirate.png");
        }

        private void pbx_ninja_Click(object sender, EventArgs e)
        {
            int m_wert = 3;
            pbx_melkor.Image = Image.FromFile("C:/Users/Saturn/Documents/Visual Studio 2015/Projects/RPSSL/ninja.png");
        }

        private void pbx_monkey_Click(object sender, EventArgs e)
        {
            int m_wert = 4;
            pbx_melkor.Image = Image.FromFile("C:/Users/Saturn/Documents/Visual Studio 2015/Projects/RPSSL/monkey.png");
        }

        private void pbx_zombie_Click(object sender, EventArgs e)
        {
            int m_wert = 5;
            pbx_melkor.Image = Image.FromFile("C:/Users/Saturn/Documents/Visual Studio 2015/Projects/RPSSL/zombie.png");
        }

        private void btn_instructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Robot: schlägt Zombie und Ninja \nPirate: schlägt Robot und Monkey \nNinja: schlägt Pirate und Zombie \nMonkey: schlägt Ninja und Robot \nZombie: schlägt Monkey und Pirate");
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            RPSSL_dll.RPSSL_dll.Spielablauf(m_meldung, m_wert);
            MessageBox.Show(m_meldung);
        }
    }
}
