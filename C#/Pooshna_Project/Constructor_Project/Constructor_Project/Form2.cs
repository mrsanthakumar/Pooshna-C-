using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Constructor_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Logout this Page?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PerformAction();
            }
        }

        private void PerformAction()
        {
            var myForm = new Form1();
            this.Hide();
            myForm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form3();
            this.Hide();
            myForm.Show();
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form4();
            this.Hide();
            myForm.Show();
        }

        private void showCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form5();
            this.Hide();
            myForm.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form6();
            this.Hide();
            myForm.Show();
        }

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form7();
            this.Hide();
            myForm.Show();
        }

        private void showProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form8();
            this.Hide();
            myForm.Show();
        }

        private void addRentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form9();
            this.Hide();
            myForm.Show();
        }

        private void deleteRentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form10();
            this.Hide();
            myForm.Show();
        }

        private void rentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form11();
            this.Hide();
            myForm.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form12();
            this.Hide();
            myForm.Show();
        }

        private void addCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form13();
            this.Hide();
            myForm.Show();
        }

        private void deleteCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form14();
            this.Hide();
            myForm.Show();
        }

        private void showCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form15();
            this.Hide();
            myForm.Show();
        }
    }
}