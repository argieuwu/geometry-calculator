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
    public partial class FormSquare : Form
    {
        public FormSquare()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            try
            {
                double side = double.Parse(btnSide.Text);
                double area = side * side;

                SbtnResult.Text = $"Area {area:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number for the side.");
            }
        }

        private void btnSide_TextChanged(object sender, EventArgs e)
        {

        }

        private void SbtnDiagonal_Click(object sender, EventArgs e)
        {
            try
            {
                double side = double.Parse(btnSide.Text);
                double diagonal = Math.Sqrt(2) * side;

                SbtnResult.Text = $"Diagonal {diagonal:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number for the side.");
            }

        }

        private void SbtnPerimeter_Click(object sender, EventArgs e)
        {
            try
            {
                double side = double.Parse(btnSide.Text);
                double perimeter = 4 * side;

                SbtnResult.Text = $"Perimeter: {perimeter:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number for the side.");
            }
        }

        private void SbtnResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClearCircle_Click(object sender, EventArgs e)
        {
           
            SbtnResult.Clear();
            btnSide.Clear();

        }
    }
}
