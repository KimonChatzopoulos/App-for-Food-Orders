using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace order_app.allusercontrol
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                lbanner.Location = new Point(94,367);
                lbanner.ForeColor = Color.Orange;
                num++;

            }
            else if (num == 1)
            {
                lbanner.Location = new Point(166, 367);
                lbanner.ForeColor = Color.Green;
                num++;
            }
            else if (num == 2)
            {
                lbanner.Location = new Point(268, 367);
                lbanner.ForeColor = Color.RoyalBlue;
                num=0;
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
