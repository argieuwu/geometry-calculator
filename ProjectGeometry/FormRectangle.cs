using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ProjectGeometry
{
    public partial class FormRectangle : Form
    {
        public FormRectangle()
        {
            InitializeComponent();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void RbtnLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void RbtnWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void RbtnResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            try
            {
                double length = double.Parse(RbtnLength.Text);
                double width = double.Parse(RbtnWidth.Text);
                double area = length * width;

                RbtnResult.Text = $"Area: {area:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numbers for length and width.");
            }

        }

        private void btnDiagonal_Click(object sender, EventArgs e)
        {
            try
            {
                double length = double.Parse(RbtnLength.Text);
                double width = double.Parse(RbtnWidth.Text);
                double diagonal = Math.Sqrt((length * length) + (width * width));

                RbtnResult.Text = $"Diagonal: {diagonal:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numbers for length and width.");
            }
        }

        private void btnClearCircle_Click(object sender, EventArgs e)
        {
            RbtnLength.Clear();
            RbtnWidth.Clear();
            RbtnResult.Clear();
        }
    }
}
