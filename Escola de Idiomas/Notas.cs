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
	public partial class Notas : Form
	{
		DAONotas notas;
		AdiconarNotas adiconarNotas;
		ExcluirNotas excluirNotas;
		AtualizarNotas atualizarNotas;
		public Notas()
		{
			InitializeComponent();
			this.notas = new DAONotas();
			ChamarMetodo(dataGridView1);//Configurar toda a estrutura
		}

		public void ChamarMetodo(DataGridView datagrid)
		{
			ConfigurarDataGrid(datagrid);//Configuro a estrutura
			NomeColunas(datagrid);//Configuro os nomes
			AdicionarDados(datagrid);//Adiciono os dados

		}//fim do método

		public void NomeColunas(DataGridView dataGrid)
		{
			dataGrid.Columns[0].Name = "Código";
			dataGrid.Columns[1].Name = "nota";
			dataGrid.Columns[2].Name = "data";
			dataGrid.Columns[3].Name = "observacao";
		}//fim do método

		public void ConfigurarDataGrid(DataGridView dataGrid)
		{
			dataGrid.AllowUserToAddRows = false;//Não permito que o usuário adicione linhas
			dataGrid.AllowUserToDeleteRows = false;
			dataGrid.AllowUserToResizeColumns = false;
			dataGrid.AllowUserToResizeRows = false;
			dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


			dataGrid.ColumnCount = 4;
		}//fim do configurar

		public void AdicionarDados(DataGridView dataGrid)
		{
			//Primeira coisa será: PREENCHER O VETOR
			this.notas.PreencherVetor();
			for (int i = 0; i < this.notas.contar; i++)
			{
				dataGrid.Rows.Add(this.notas.codigo[i], this.notas.nota[i], this.notas.dat[i], this.notas.observacao[i]);
			}//fim do for
		}//fim do adicionarDados

		public DataGridView retornarData()
		{
			return dataGridView1;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}// data grideview para mostrar as notas dos alunos

		private void button1_Click(object sender, EventArgs e)
		{
			atualizarNotas = new AtualizarNotas();
			atualizarNotas.ShowDialog();
		}// botao atualizar para atualizar as notas dos alunos

		private void button2_Click(object sender, EventArgs e)
		{
			adiconarNotas = new AdiconarNotas();
			adiconarNotas.ShowDialog();
		}// botao adicionar para adicionar as notas dos alunos

		private void button3_Click(object sender, EventArgs e)
		{
			excluirNotas = new ExcluirNotas();
			excluirNotas.ShowDialog();
		}// botao excluir para excluir as notas dos alunos
	}
}
