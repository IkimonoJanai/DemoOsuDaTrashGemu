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
        int x = -100, y = -20;
        int xArrow = 0, yArrow = 25 , xArrowBot = -5 , xArrowRight = 5;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây la nhánh");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picSaberUwU.Left += x;
            picSaberUwU.Top += y;
            if (picSaberUwU.Left <= 0 || picSaberUwU.Right >= ClientRectangle.Width)
                x = -x;
            if (picSaberUwU.Top <= -150 || picSaberUwU.Bottom >= ClientRectangle.Height + 150)
                y = -y;
            picArrow.Left += xArrow;
            picArrow.Top += yArrow;
            if (picArrow.Left <= 0 || picArrow.Right >= ClientRectangle.Width)
                xArrow = -xArrow;
            if (picArrow.Top <= -20 || picArrow.Bottom >= ClientRectangle.Height)
                yArrow = -yArrow;
            //picArrow.Right += xArrowRight; // read only cant write
            //picArrow.Bottom += xArrowBot; // read only cant write

        }
    }
}
