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
    public partial class FormTriangle : Form
    {
        public FormTriangle()
        {
            InitializeComponent();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  

        private void btnArea_Click(object sender, EventArgs e)
        {
            try
            {
                double baseLength = double.Parse(TbtnBase.Text);
                double height = double.Parse(TbtnHeight.Text);
                double area = 0.5 * baseLength * height;

                TbtnResult.Text = $"Area: {area:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numbers for base and height.");
            }

        }

     

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TbtnResult.Text))
            {
               
            }

        }

        private void btnClearCircle_Click(object sender, EventArgs e)
        {
            TbtnBase.Clear();
            TbtnHeight.Clear();
            TbtnResult.Clear();

        }
    }
}
