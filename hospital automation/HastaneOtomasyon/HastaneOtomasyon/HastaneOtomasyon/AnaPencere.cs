using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class AnaPencere : Form
    {
        public AnaPencere()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandevuAl rAl = new RandevuAl();
            
            rAl.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Servis sF = new Servis();

            sF.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Depo dF = new Depo();

            dF.Show();
        }
    }
}
