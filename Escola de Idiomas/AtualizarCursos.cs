using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola_de_Idiomas
{
    public partial class AtualizarCursos : Form
    {
        DAOCursos cursos;
        public AtualizarCursos()
        {
            InitializeComponent();
            this.cursos = new DAOCursos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo código

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo nome

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo carga horária

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo valor

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Preencha os campos!");
                return;
            }

            int codigo = Convert.ToInt32(textBox1.Text);
            string nome = textBox2.Text;
            int cargaHoraria = Convert.ToInt32(textBox3.Text);
            decimal valor = Convert.ToDecimal(textBox4.Text);

            this.cursos.AtualizarCursos(codigo, "nome", nome);
            this.cursos.AtualizarCursos(codigo, "cargaHoraria", cargaHoraria.ToString());
            this.cursos.AtualizarCursos(codigo, "valor", valor.ToString());
            MessageBox.Show("Atualizado com sucesso!");

            LimparCampos();
        }// fim do botão atualizar curso

        public void LimparCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
