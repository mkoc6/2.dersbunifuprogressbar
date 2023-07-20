using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.dersbunifuprogressbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
       timer1.Start();
        }
        Random rc = new Random();
        int x, y, z;
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = rc.Next(1,9);
            y = rc.Next(1,14);
            z = rc.Next(1,11);
            bunifuCircleProgressbar1.Value += x;
            bunifuCircleProgressbar2.Value += z;
            bunifuCircleProgressbar3.Value += y;
            if (bunifuCircleProgressbar3.Value>84  && bunifuCircleProgressbar3.Value<99 )
            {
                timer1.Stop();
            }
        }
    }
}
