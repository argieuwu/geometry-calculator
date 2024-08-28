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
            this.Hide();
            FormMenu newform = new FormMenu();
            newform.ShowDialog();
            this.ShowDialog();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {

        }
    }
}
