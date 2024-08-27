namespace ProjectGeometry
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTriangle Check = new FormTriangle();
            Check.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCircle Check = new FormCircle();
            Check.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRectangle Check = new FormRectangle();
            Check.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormSquare Check = new FormSquare();
            Check.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nice G!");
            this.Close();
        }

        
    }
}
