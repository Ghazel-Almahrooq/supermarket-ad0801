using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarket_ad0801
{
    public partial class frmForm1 : Form
    {
      
        public frmForm1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmFamily frm = new frmFamily();
            frm.TopLevel = false;
            panelMain.Controls.Add(frm);
            frm.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        { 

            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.TopLevel = false;
            panelMain.Controls.Add(frm);
            frm.Show();
        }

        private void btnForPerson_Click(object sender, EventArgs e)
        {
            frmPerson frm = new frmPerson();
            frm.TopLevel = false;
            panelMain.Controls.Add(frm);
            frm.Show();
        }

        private void btnBuyPay_Click(object sender, EventArgs e)
        {
            frmManegment frm = new frmManegment();
            frm.TopLevel = false;
            panelMain.Controls.Add(frm);
            frm.Show();
        }
    }
}
