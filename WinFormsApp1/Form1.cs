namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "Вы зарегестрироывали ученика со следующими данными:";
            label6.Text = "ФИО: "+textBox1.Text;
            label7.Text = "Класс: " + textBox2.Text;
            label8.Text = "Возраст: " + textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}