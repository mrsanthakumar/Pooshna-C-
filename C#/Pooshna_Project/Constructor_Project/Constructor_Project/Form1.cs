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
    public partial class Form1 : Form
    {
        private Timer timer;

        public Form1()
        {
            InitializeComponent();

            // Initialize the timer
            timer = new Timer();
            timer.Interval = 1000; // Update every 1000 milliseconds (1 second)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm2();
        }
        private void OpenForm2()
        {
            // Instead of creating a new instance of Form2 each time, 
            // you can reuse the same instance if it exists
            if (Application.OpenForms["Form2"] == null)
            {
                var form2 = new Form2();
                form2.FormClosed += (s, args) => this.Show(); // Show Form1 when Form2 is closed
                form2.Show();
                this.Hide();
            }
            else
            {
                Application.OpenForms["Form2"].Activate(); // Activate Form2 if it's already open
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initial update of the label
            UpdateLabel();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the label with the current date and time every second
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            // Set the text of label4 to the current date and time
            label4.Text = "Current Date and Time: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}