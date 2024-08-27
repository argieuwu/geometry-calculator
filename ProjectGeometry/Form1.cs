namespace ProjectGeometry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTriangle Check = new FormTriangle();
            Check.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCircle Check = new FormCircle();
            Check.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRectangle Check = new FormRectangle();
            Check.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormSquare Check = new FormSquare();
            Check.Show();
        }
    }
}
