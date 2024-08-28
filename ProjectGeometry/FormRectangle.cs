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
            this.Hide();
            FormMenu newform = new FormMenu();
            newform.ShowDialog();
            this.ShowDialog();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
