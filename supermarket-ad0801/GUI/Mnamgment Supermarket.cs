using supermarket_ad0801.entities;
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
    public partial class frmManegment : Form
    {
        Sales currentSales;
        public frmManegment()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentSales = new Sales();
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            currentSales.Sid = int.Parse(row.Cells[0].Value.ToString());
            currentSales.Product = (row.Cells[1].Value.ToString());
            currentSales.Quantity = int.Parse(row.Cells[2].Value.ToString());
            currentSales.Price = double.Parse(row.Cells[3].Value.ToString());

            txtPrice.Text = currentSales.Price.ToString();
            txtProduct.Text = currentSales.Product.ToString();
            txtQuantity.Text = currentSales.Quantity.ToString();

        }
        private void RefreshdataGridView()
        {
            dataGridView1.DataSource = SalesDAL.GetAllCommand(); 
        }

        private void frmManegment_Load(object sender, EventArgs e)
        {
            RefreshdataGridView();
        }
    }
}
