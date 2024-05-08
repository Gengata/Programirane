namespace Uprajneniea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void control11_Load(object sender, EventArgs e)
        {

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            control11.Hide();
        }

        private void ‚ıÓ‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            control11.Show();
            control11.BringToFront();
        }
    }
}
