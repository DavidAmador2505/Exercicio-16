using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_16
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //fica automaticamente ao mudar de form
            label4.Text = Classe_Utilizador.Nome;
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
            //Guardar dados do form nas variáveis e guardar na classe utilizador
            string nome = textBox1.Text;
            string email = textBox2.Text;
            string password = TxtPassword.Text;

            Classe_Utilizador.Nome = nome;
            Classe_Utilizador.Email = email;
            Classe_Utilizador.Password = password;


            MessageBox.Show("Confirmação de Conta de Utilizador");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Anterior = new Form1();
            Anterior.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FecharTodososforms.Fecharformularios();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TxtPassword.UseSystemPasswordChar = false;

            }

            else

            {
                TxtPassword.UseSystemPasswordChar = true;
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
