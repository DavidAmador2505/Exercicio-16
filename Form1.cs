namespace Exercicio_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nome = (textBox1.Text);
            string Email = (textBox2.Text);
            string Password = (textBox3.Text);

            textBox1.Text = Convert.ToString(Classe_Utilizador.Nome);
            textBox2.Text = Convert.ToString(Classe_Utilizador.Email);
            textBox3.Text = Convert.ToString(Classe_Utilizador.Password);

            MessageBox.Show("Confirmação de Conta de Utilizador");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Seguinte = new Form2();
            Seguinte.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FecharTodososforms.Fecharformularios();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
               
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}