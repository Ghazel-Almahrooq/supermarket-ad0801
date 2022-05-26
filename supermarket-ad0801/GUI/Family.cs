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
    public partial class frmFamily : Form
    {
        public frmFamily()
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
           
        }

        int price;
        string name;
        int Qty;
        int total;

        private void mouseClick(object sender, MouseEventArgs e)
        {
            var clickpic = (PictureBox)sender;
            if (clickpic == pictureBox1)
            {
                name = "Vanilla and double chocolate flavor 4 liters ";
                price = 10;
                Qty = int.Parse(Interaction.InputBox("Enter the quantity?", "quantity", ""));
            }

            else if (clickpic == pictureBox3)
            {
                name = "Chocolate brownies flavor 4 liters ";
                price = 11;
                Qty = int.Parse(Interaction.InputBox("Enter the quantity?", "quantity", ""));
            }
            else if (clickpic == pictureBox2)
            {
                name = "Peanut butter flavor 4 liters";
                price = 15;
                Qty = int.Parse(Interaction.InputBox("Enter the quantity?", "quantity", ""));
            }
            else if (clickpic == pictureBox4)
            {
                name = "Pecan butter flavor 4 liters";
                price = 15;
                Qty = int.Parse(Interaction.InputBox("Enter the quantity?", "quantity", ""));
            }
            else if (clickpic == pictureBox5)
            {
                name = "Coffe flavor 4 liters";
                price = 10;
                Qty = int.Parse(Interaction.InputBox("Enter the quantity?", "quantity", ""));
            }
            else if (clickpic == pictureBox6)
            {
                name = "Mango flavor 4 liters";
                price = 10;
                Qty = int.Parse(Interaction.InputBox("Enter the quantity?", "quantity", ""));
            }
            else if (clickpic == pictureBox7)
            {
                name = "Natural vanilla flavor 4 liters";
                price = 15;
                Qty = int.Parse(Interaction.InputBox("Enter the quantity?", "quantity", ""));
            }
            else if (clickpic == pictureBox8)
            {
                name = "A 15 pieces of different flavors for ice cream sticks";
                price = 20;
                Qty = int.Parse(Interaction.InputBox("Enter the quantity?", "quantity", ""));
            }

            total = price * Qty;
            this.dataGridView1.Rows.Add(name, price, Qty, total.ToString());

            int sum = 0;
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value);
            }

            txtTotal.Text = sum.ToString();







        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Completed!" + "" + "Your order will be delivered within 2-4 hours.");
            txtTotal.Text = "";

        }
    }
}
