using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//importando a estrutura de tela
using MySql.Data.MySqlClient;//importando a estrutura de conexão com o banco de dados

namespace Escola_de_Idiomas
{
	class DAOAluno
	{
		public MySqlConnection conexao;
		public string dados;
		public string comando;

		public DAOAluno()
		{
			conexao = new MySqlConnection("server=localhost;DataBase=escolaIdiomas;Uid=root;Password=;Convert Zero DateTime=True");
			try
			{
				conexao.Open();//abrir a conexão
			}
			catch (Exception erro)
			{
				MessageBox.Show($"Algo deu errado!\n\n {erro}");
				conexao.Close();//fecha conexão com o banco de dados
			}//fim do try_catch
		}

		public void Inserir(string nome,string cpf, string email, string telefone, DateTime dataNascimento)
		{
			try
			{
				string dataFormatada = dataNascimento.ToString("yyyy-MM-dd");
				this.dados = $"('', '{nome}', '{cpf}', '{email}', '{telefone}', '{dataFormatada}')";
				this.comando = $"Insert into aluno(codigo, nome, cpf, email, telefone, dtDeNascimento) values{this.dados}";
				//Inserir comando
				MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);
				string resultado = "" + sql.ExecuteNonQuery();
				MessageBox.Show($"Inserido com Sucesso! \n\n{resultado}");
			}
			catch (Exception erro)
			{
				MessageBox.Show($"Algo deu errado\n\n {erro}");
			}
		}//fim do inserir

		public string atualizarAluno(int codigo, string campo, string novoDado)
		{
			try
			{
				string query = $"update aluno set {campo} = '{novoDado}' where codigo = '{codigo}'";
				//executar o comando

				MySqlCommand sql = new MySqlCommand(query, this.conexao);
				string resultado = "" + sql.ExecuteNonQuery();//comando da inserção no banco
				return $"Atualizado com sucesso!\n\n{resultado}";
			}
			catch (Exception erro)
			{
				return $"Algo deu errado\n\n{erro}";
			}
		}

		public string deletar(int codigo)
		{
			try
			{
				string query = $"delete from aluno where codigo = '{codigo}'";
				//executar o comando

				MySqlCommand sql = new MySqlCommand(query, this.conexao);
				string resultado = "" + sql.ExecuteNonQuery();//comando da inserção no banco
				return $"Deletado com sucesso!\n\n{resultado}";
			}
			catch (Exception erro)
			{
				return $"Algo deu errado\n\n{erro}";
			}
		}

	}
}
