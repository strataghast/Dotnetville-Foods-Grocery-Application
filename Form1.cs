using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment_5_3_2.Basket;

namespace Assignment_5_3_2
{
    public partial class Form1 : Form
    {
        public static string sendtext = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPine_Click(object sender, EventArgs e)
        {
            Data.basketData.Add(new Basket() { itemNumber = 101, productName = "Pineapple", productPrice = 2.49, productQuanitity = 1 });
            RefreshData();
            txtSubtotal.Text = "0";
            for (int i = 0; i < gridBasket.Rows.Count; i++)
            {
                txtSubtotal.Text = Convert.ToString(decimal.Parse(txtSubtotal.Text) + decimal.Parse(gridBasket.Rows[i].Cells[2].Value.ToString()));
            }
            Form2 form2 = new Form2();
            sendtext = txtSubtotal.Text;
        }

        private void btnPassion_Click(object sender, EventArgs e)
        {
            Data.basketData.Add(new Basket() { itemNumber = 102, productName = "Passion Fruit", productPrice = 1.29, productQuanitity = 1 });
            RefreshData();
            txtSubtotal.Text = "0";
            for (int i = 0; i < gridBasket.Rows.Count; i++)
            {
                txtSubtotal.Text = Convert.ToString(decimal.Parse(txtSubtotal.Text) + decimal.Parse(gridBasket.Rows[i].Cells[2].Value.ToString()));
            }
            Form2 form2 = new Form2();
            sendtext = txtSubtotal.Text;
        }

        private void btnStraw_Click(object sender, EventArgs e)
        {
            Data.basketData.Add(new Basket() { itemNumber = 103, productName = "Strawberries", productPrice = 4.99, productQuanitity = 1 });
            RefreshData();
            txtSubtotal.Text = "0";
            for (int i = 0; i < gridBasket.Rows.Count; i++)
            {
                txtSubtotal.Text = Convert.ToString(decimal.Parse(txtSubtotal.Text) + decimal.Parse(gridBasket.Rows[i].Cells[2].Value.ToString()));
            }
            Form2 form2 = new Form2();
            sendtext = txtSubtotal.Text;
        }

        private void btnApple_Click(object sender, EventArgs e)
        {
            Data.basketData.Add(new Basket() { itemNumber = 104, productName = "Apple (Single)", productPrice = 1.99, productQuanitity = 1 });
            RefreshData();
            txtSubtotal.Text = "0";
            for (int i = 0; i < gridBasket.Rows.Count; i++)
            {
                txtSubtotal.Text = Convert.ToString(decimal.Parse(txtSubtotal.Text) + decimal.Parse(gridBasket.Rows[i].Cells[2].Value.ToString()));
            }
            Form2 form2 = new Form2();
            sendtext = txtSubtotal.Text;
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void RefreshData()
        {
            gridBasket.DataSource = null;
            gridBasket.DataSource = Basket.Data.basketData.ToList();
            txtSubtotal.Text = "0";
            for (int i = 0; i < gridBasket.Rows.Count; i++)
            {
                txtSubtotal.Text = Convert.ToString(decimal.Parse(txtSubtotal.Text) + decimal.Parse(gridBasket.Rows[i].Cells[2].Value.ToString()));
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Basket.Data.basketData.RemoveAt(gridBasket.CurrentRow.Index);
            RefreshData();
            txtSubtotal.Text = "0";
            for (int i = 0; i < gridBasket.Rows.Count; i++)
            {
                txtSubtotal.Text = Convert.ToString(decimal.Parse(txtSubtotal.Text) + decimal.Parse(gridBasket.Rows[i].Cells[2].Value.ToString()));
            }
            sendtext = txtSubtotal.Text;
        }
    }
}
