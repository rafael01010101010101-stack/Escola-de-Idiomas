namespace Escola_de_Idiomas
{
	public partial class Form1 : Form
	{
		Cadastrar_Aluno cadastrarAluno;
		CadastrarProfessor cadastrarProfessor;
		AtualizarAluno atualizarAluno;

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
	}
}
