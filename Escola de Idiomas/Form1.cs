namespace Escola_de_Idiomas
{
	public partial class Form1 : Form
	{
		Cadastrar_Aluno cadastrarAluno;
		CadastrarProfessor cadastrarProfessor;
		AtualizarAluno atualizarAluno;
		AtualizarProfessor atualizarProfessor;
		ExcluirAluno excluirAluno;
		ExcluirProfessor excluirProfessor;
		CadastrarFuncionario cadastrarFuncionario;
		LoginFuncionario loginFuncionario;
		Matricula matricula;
		ConsultarMatricula ConsultarMatricula;
		Notas notas;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			cadastrarAluno = new Cadastrar_Aluno();
			cadastrarAluno.ShowDialog();
		}//botão de cadastrar aluno

		private void button2_Click(object sender, EventArgs e)
		{
			cadastrarProfessor = new CadastrarProfessor();
			cadastrarProfessor.ShowDialog();
		}// botão de cadastrar professor

		private void button7_Click(object sender, EventArgs e)
		{
			atualizarAluno = new AtualizarAluno();
			atualizarAluno.ShowDialog();
		}// botão de atualizar aluno

		private void button9_Click(object sender, EventArgs e)
		{
			atualizarProfessor = new AtualizarProfessor();
			atualizarProfessor.ShowDialog();
		}// botão de atualizar professor

		private void button8_Click(object sender, EventArgs e)
		{
			excluirAluno = new ExcluirAluno();
			excluirAluno.ShowDialog();
		}// botão de excluir aluno

		private void button10_Click(object sender, EventArgs e)
		{
			excluirProfessor = new ExcluirProfessor();
			excluirProfessor.ShowDialog();
		}// botão de excluir professor

		private void button12_Click(object sender, EventArgs e)
		{
			cadastrarFuncionario = new CadastrarFuncionario();
			cadastrarFuncionario.ShowDialog();
		}// fim do cadastrar funcionario

		private void button3_Click(object sender, EventArgs e)
		{
			loginFuncionario = new LoginFuncionario();
			loginFuncionario.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			matricula = new Matricula();
			matricula.ShowDialog();
		}// botão de matricular aluno

		private void button6_Click(object sender, EventArgs e)
		{
			ConsultarMatricula = new ConsultarMatricula();
			ConsultarMatricula.ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			notas = new Notas();
			notas.ShowDialog();
		}// botao pra área de notas
	}
}
