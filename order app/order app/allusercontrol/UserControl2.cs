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
    public partial class UserControl2 : UserControl
    {
        function fn = new function();
        String query;
        public UserControl2()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            query = "instert into items (name,category,price) values ('"+txtItemName.Text+"','"+txtCategory.Text+"',"+txtPrice.Text+")";
            fn.setData(query);
            clearALL();
        }
        public void clearALL()
        {
            txtCategory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl2_Leave(object sender, EventArgs e)
        {
            clearALL();
        }
    }
}