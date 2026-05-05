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
	public partial class AdiconarNotas : Form
	{
		DAONotas notas;
		public AdiconarNotas()
		{
			InitializeComponent();
			this.notas = new DAONotas();
		}

		private void AdiconarNotas_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}// fim do campo nome do aluno

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}// fim do campo data de avaliação

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}// fim do campo observação

		private void button1_Click(object sender, EventArgs e)
		{
			if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
			{
				MessageBox.Show("Preencha os Campos");
			}
			else
			{
				decimal nota = Convert.ToDecimal(textBox1.Text);
				DateTime dat = Convert.ToDateTime(textBox2.Text);
				string observacao = textBox3.Text;
				// INSERIR DENTRO DO BANCO
				this.notas.InserirNotas(nota, dat, observacao);
				// limpar os campos
				LimparCampos();
			}
		}// fim do botão adicionar notas

		public void LimparCampos()
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
		}
	}
}
