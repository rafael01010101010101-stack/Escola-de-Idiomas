namespace Escola_de_Idiomas
{
	partial class ExcluirCursos
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			textBox1 = new TextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15F);
			label1.ForeColor = Color.OrangeRed;
			label1.Location = new Point(318, 42);
			label1.Name = "label1";
			label1.Size = new Size(192, 28);
			label1.TabIndex = 0;
			label1.Text = "Área de excluir curso";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 15F);
			label2.Location = new Point(231, 177);
			label2.Name = "label2";
			label2.Size = new Size(81, 28);
			label2.TabIndex = 1;
			label2.Text = "Codigo:";
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 15F);
			textBox1.Location = new Point(318, 177);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(192, 34);
			textBox1.TabIndex = 2;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI", 15F);
			button1.Location = new Point(318, 279);
			button1.Name = "button1";
			button1.Size = new Size(192, 39);
			button1.TabIndex = 3;
			button1.Text = "EXCLUIR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// ExcluirCursos
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.Copilot_20260430_14461510;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "ExcluirCursos";
			Text = "ExcluirCursos";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox textBox1;
		private Button button1;
	}
}