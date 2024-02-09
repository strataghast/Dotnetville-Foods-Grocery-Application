using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using static Assignment_5_3_2.Basket;

namespace Assignment_5_3_2
{
    public partial class Form2 : Form
    {
        static string filename;
        const string path = @"C:\Users\brett\OneDrive\Desktop\Programming\MSSA\Data Structures and Algorithims\Week 5\Assignment 5-3-2\Receipts\Purchase_Receipt.txt";
        public Form2()
        {
            InitializeComponent();
        }
        private void btnCoupon_Click(object sender, EventArgs e)
        {
            grpCoupon.Show();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Groceries purchased. Please come to the store within 30 minutes to pick them up.", "Purchase Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshData();

            // STRINGBUILDER //

            StringBuilder purchaseDetailsBuilder = new StringBuilder();
            purchaseDetailsBuilder.AppendLine("Dotnetville Foods\n1399 Seasharp Lane, Dotnetville, US, 99901");
            purchaseDetailsBuilder.AppendLine("\nItem#\t\tProduct\t\t\tPrice\t\tQuantity");
            purchaseDetailsBuilder.AppendLine("--------------------------------------------------------------------------------\n");

            foreach(DataGridViewRow row in gridCheckout.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    purchaseDetailsBuilder.Append(cell.Value + "\t\t");
                }
                purchaseDetailsBuilder.Append("\n\n");
            }
            purchaseDetailsBuilder.AppendLine("--------------------------------------------------------------------------------\n");
            purchaseDetailsBuilder.AppendLine("\nSubtotal: " + txtSubtotal2.Text);
            purchaseDetailsBuilder.AppendLine("Total Paid: " + txtTotal.Text);

            // CONVERTING STRINGBUILDER DETAILS TO STRING

            string purchaseDetails = purchaseDetailsBuilder.ToString();

            // OPENING 

            File.WriteAllText(path, purchaseDetails);
            Process.Start("notepad.exe", path);
            
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (txtCoupon.Text == "ABC1337")
            {
                MessageBox.Show("Coupon successfully added.", "Coupon Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCoupon.Text = "10% discount applied!";
                decimal coupon = 0.1m;
                Calculations calc = new Calculations();
                txtTotal.Text = string.Format("${0:0.##}", calc.Coupon(decimal.Parse(Form1.sendtext), coupon));
            }
            else txtCoupon.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            grpCoupon.Hide();
            gridCheckout.DataSource = Basket.Data.basketData;
            txtSubtotal2.Text = string.Format("${0:0.##}", Form1.sendtext);
            decimal salesTax = 0.0475m;
            Calculations calc = new Calculations();
            txtTotal.Text = string.Format("${0:0.##}", calc.SalesTax(decimal.Parse(Form1.sendtext), salesTax));
            cmboMonth.DataSource = Enum.GetValues(typeof(Months));
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            form1.RefreshData();
            this.Hide();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            grpCoupon.Hide();
        }
        private void RefreshData()
        {
            txtName.Clear();
            txtCC.Clear();
            txtCVC.Clear();
            txtYearExp.Clear();
            cmboMonth.SelectedIndex = -1;
        }
    }
}
