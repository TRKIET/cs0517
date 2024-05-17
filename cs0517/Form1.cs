namespace cs0517
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Top = label1.Top + 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left - 10;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("‚±‚ñ‚É‚¿‚Í");   
            MessageBox.Show(100.ToString());
            MessageBox.Show($"{100}");
            MessageBox.Show($"label1. Top={label1.Top}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left + 10;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top - 10;
        }
    }
}