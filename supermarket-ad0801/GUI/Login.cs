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
    public partial class frmLogin : Form
    {
        List<User> Users = new List<User>();
        User user1 = new User();



        public frmLogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            user1.Name = "Ghazel";
            user1.Username = "ghazel";
            user1.Password = "1234";
            Users.Add(user1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == Users[0].Username))
            {
                Form1 frm = new Form1();
                frm.Show();
            }
        }

        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";

        }
    }
}
