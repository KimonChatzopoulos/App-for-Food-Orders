using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace order_app
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(string user)
        {
            InitializeComponent();
            if (user == "Guest")
            {
                btnAdd.Hide();
                BtnUpdate.Hide();
                btnRemove.Hide();
            }
            else if(user == "Admin")
            {
                btnAdd.Show();
                BtnUpdate.Show();
                btnRemove.Show();

            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            userControl21.Visible = false;
            place_order1.Visible = false;
            userControl31.Visible = false;
            remove_item1.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            userControl11.SendToBack();
            guna2Transition1.ShowSync(place_order1);
            place_order1.Visible = true;
            place_order1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            remove_item1.Visible = true;
            remove_item1.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            userControl21.Visible = true;
            userControl21.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            userControl31.Visible = true;
            userControl31.BringToFront();
        }

        private void btnlogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void place_order1_Load(object sender, EventArgs e)
        {

        }
    }
}
