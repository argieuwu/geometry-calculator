namespace ProjectGeometry
{
    public partial class FormMenu : Form
    {
        // Declare form instances as class fields
        private FormSquare formSquare;
        private FormTriangle formTriangle;
        private FormCircle formCircle;
        private FormRectangle formRectangle;

        public FormMenu()
        {
            InitializeComponent();

            // Initialize the forms in the constructor
            formSquare = new FormSquare();
            formTriangle = new FormTriangle();
            formCircle = new FormCircle();
            formRectangle = new FormRectangle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formCircle.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            formTriangle.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formRectangle.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formSquare.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nice G!");
            this.Close();
        }
    }
}
