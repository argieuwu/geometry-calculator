﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.MonthCalendar;

namespace ProjectGeometry
{
    public partial class FormCircle : Form
    {
        public FormCircle()
        {
            InitializeComponent();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtRadius.Text, out double radius))
            {
                double area = Math.PI * Math.Pow(radius, 2);
                txtResult.Text = $"Area: {area:F2}";
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the radius.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCircumference_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtRadius.Text, out double radius))
            {
                double circumference = 2 * Math.PI * radius;
                txtResult.Text = $"Circume: {circumference:F2}";
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the radius.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnClearCircle_Click(object sender, EventArgs e)
        {
            txtRadius.Clear();
            txtResult.Clear();

        }

        private void txtRadius_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtRadius.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtRadius.Text = txtRadius.Text.Remove(txtRadius.Text.Length - 1);
            }
        }

        
    }
}
