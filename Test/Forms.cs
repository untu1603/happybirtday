using System.Runtime.CompilerServices;

namespace Test
{
    public partial class Forms : Form
    {
        public Forms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "abc")
            {
                Check = true;
                Close();
            }
            else
            {
                MessageBox.Show("Sai rùi, đoán đi");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}