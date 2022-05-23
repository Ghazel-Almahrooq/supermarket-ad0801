using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace supermarket_ad0801
{
    public partial class frmPerson : Form
    {
        public frmPerson()
        {
            InitializeComponent();



           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int price;
            string name;
            int qty;
            var clickpic = (PictureBox)sender;
            if (clickpic == pictureBox1)
            {
                name = "One scoop vanilla";
                price = 1;
                qty = int.Parse(Interaction.InputBox("Enter the quantity?", "quantity", ""));

            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox15_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
