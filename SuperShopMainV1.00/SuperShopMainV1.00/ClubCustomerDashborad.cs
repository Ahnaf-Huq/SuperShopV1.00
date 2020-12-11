using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopMainV1._00
{
    public partial class ClubCustomerDashborad : Form
    {
        public ClubCustomerDashborad()
        {
            InitializeComponent();
        }

        private void ClubCustomerDashboarplanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesmanDashboar ssld = new SalesmanDashboar();
            ssld.Show();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            Login logout = new Login();
            logout.Show();
        }
    }
}
