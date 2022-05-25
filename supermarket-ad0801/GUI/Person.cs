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
            pictureBox1.MouseClick += mouseClick;
            pictureBox2.MouseClick += mouseClick;
            pictureBox5.MouseClick += mouseClick;
            pictureBox4.MouseClick += mouseClick;
            pictureBox3.MouseClick += mouseClick;
            pictureBox6.MouseClick += mouseClick;
            pictureBox7.MouseClick += mouseClick;
            pictureBox8.MouseClick += mouseClick;
            pictureBox9.MouseClick += mouseClick;
            pictureBox15.MouseClick += mouseClick;



        }
        int price;
            string name;
            int qty;
            int total;
            
        private void mouseClick(object sender, MouseEventArgs e)
        {
           
            var clickpic = (PictureBox)sender;
            if (clickpic == pictureBox1)
            {
                name = "One scoop vanilla";
                price = 1;
                qty = int.Parse(Interaction.InputBox("Enter the quantity?", "quantity", ""));
            }

            else if (clickpic == pictureBox2)
            {
                name = "One scoop Mint with cohoclate pieces";
                price = 1;
                qty = int.Parse(Interaction.InputBox("Enter the quantity?", "quantity", ""));
            }
            else if (clickpic == pictureBox5)
            {
                name = "One scoop cohoclate";
                price = 1;
                qty = int.Parse(Interaction.InputBox("Enter the quantity?", "quantity", ""));
            }
            else if (clickpic == pictureBox4)
            {
                name = "One scoop strawberry";
                price = 1;
                qty = int.Parse(Interaction.InputBox("Enter the quantity?", "quantity", ""));
            }
            else if (clickpic == pictureBox3)
            {
                name = "One scoop cohoclate ball";
                price = 1;
                qty = int.Parse(Interaction.InputBox("Enter the quantity?", "quantity", ""));
            }

            //more scoops
            else if (clickpic == pictureBox6)
            {
                name = "6 scoops of different flavors ";
                price = 3;
                qty = int.Parse(Interaction.InputBox("Enter the quantity?", "quantity", ""));
            }
            else if (clickpic == pictureBox7)
            {
                name = "2 large scoops with caramel sauce and pecan pieces";
                price = 5;
                qty = int.Parse(Interaction.InputBox("Enter the quantity?", "quantity", ""));
            }
            else if (clickpic == pictureBox8)
            {
                name = "3 scoops of different flavors";
                price = 2;
                qty = int.Parse(Interaction.InputBox("Enter the quantity?", "quantity", ""));
            }
            else if (clickpic == pictureBox9)
            {
                name = "3 scoops of same flavors";
                price = 2;
                qty = int.Parse(Interaction.InputBox("Enter the quantity?", "quantity", ""));
            }
            else if (clickpic == pictureBox15)
            {
                name = "2 large scoops with chocolate sauce and almond pieces";
                price = 5;
                qty = int.Parse(Interaction.InputBox("Enter the quantity?", "quantity", ""));
            }

                total = price * qty;
            this.dataGridView1.Rows.Add(name, price, qty,total.ToString());

            int sum=0;
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value);
            }

            txtTotal.Text = sum.ToString();




            





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {


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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
