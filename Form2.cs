using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoOsuDaTrashGemu
{
    public partial class Form2 : Form
    {
        int x = -100;
        int y =-10;
        public Form2()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Danh Ngu vl ra");
        }

        private void picSaberUwU_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picSaberUwU.Left += x;
            picSaberUwU.Top += y;
            if (picSaberUwU.Left <= 0 || picSaberUwU.Right >= ClientRectangle.Width)
                x = -x;
            if (picSaberUwU.Top < -150 || picSaberUwU.Bottom >= ClientRectangle.Height + 150)
                y = -y;
        }
    }
}
