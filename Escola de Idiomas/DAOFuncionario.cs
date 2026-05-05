using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//importando a estrutura de tela
using System.Numerics;

namespace Escola_de_Idiomas
{
	class DAOFuncionario
	{
		public MySqlConnection conexao;
		public string dados;
		public string comando;

		public DAOFuncionario()
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

		public void InserirFuncionario(string nome, string telefone, string cnpj, DateTime dataNascimento, double salario, string cargo, string email, string senha)
		{
			try
			{
				string dataFormatada = dataNascimento.ToString("yyyy-MM-dd");
				this.dados = $"('', '{nome}', '{telefone}', '{cnpj}', '{dataFormatada}', '{salario}', '{cargo}', '{email}', '{senha}')";
				this.comando = $"Insert into funcionario(codigo, nome, telefone, cnpj, dataNascimento, salario, cargo, email, senha) values{this.dados}";
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

		public void ValidarLoginFuncionario(string email, string senha)
		{
			string sql =
				"SELECT * FROM funcionario " +
				"WHERE email = '" + email + "' AND senha = '" + senha + "'";

			MySqlCommand cmd = new MySqlCommand(sql, conexao);
			MySqlDataReader leitura = cmd.ExecuteReader();

			if (leitura.Read())
			{
				MessageBox.Show("Bem-vindo!");
			}
			else
			{
				MessageBox.Show("Email ou Senha inválidos! Tente novamente.");
			}

			leitura.Close();
		}
	}
}
