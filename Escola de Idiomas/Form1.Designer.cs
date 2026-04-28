namespace Escola_de_Idiomas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			label1 = new Label();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			button5 = new Button();
			button6 = new Button();
			button7 = new Button();
			button8 = new Button();
			button9 = new Button();
			button10 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 20F);
			label1.ForeColor = Color.Red;
			label1.Location = new Point(278, 31);
			label1.Name = "label1";
			label1.Size = new Size(229, 37);
			label1.TabIndex = 0;
			label1.Text = "Escola de Idiomas";
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI", 10F);
			button1.ForeColor = Color.Black;
			button1.Location = new Point(12, 77);
			button1.Name = "button1";
			button1.Size = new Size(139, 38);
			button1.TabIndex = 1;
			button1.Text = "Cadastrar Aluno";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Font = new Font("Segoe UI", 10F);
			button2.ForeColor = Color.Black;
			button2.Location = new Point(12, 132);
			button2.Name = "button2";
			button2.Size = new Size(139, 39);
			button2.TabIndex = 2;
			button2.Text = "Cadastrar Professor";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Font = new Font("Segoe UI", 10F);
			button3.ForeColor = Color.Black;
			button3.Location = new Point(12, 190);
			button3.Name = "button3";
			button3.Size = new Size(72, 36);
			button3.TabIndex = 3;
			button3.Text = "Login";
			button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			button4.Font = new Font("Segoe UI", 10F);
			button4.ForeColor = Color.Black;
			button4.Location = new Point(654, 76);
			button4.Name = "button4";
			button4.Size = new Size(134, 41);
			button4.TabIndex = 4;
			button4.Text = "Matrícula";
			button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			button5.Font = new Font("Segoe UI", 10F);
			button5.ForeColor = Color.Black;
			button5.Location = new Point(654, 133);
			button5.Name = "button5";
			button5.Size = new Size(134, 38);
			button5.TabIndex = 5;
			button5.Text = "Consultar Nota";
			button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			button6.Font = new Font("Segoe UI", 10F);
			button6.ForeColor = Color.Black;
			button6.Location = new Point(654, 190);
			button6.Name = "button6";
			button6.Size = new Size(134, 40);
			button6.TabIndex = 6;
			button6.Text = "Consultar Usuários";
			button6.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			button7.Font = new Font("Segoe UI", 10F);
			button7.ForeColor = Color.Black;
			button7.Location = new Point(12, 244);
			button7.Name = "button7";
			button7.Size = new Size(139, 34);
			button7.TabIndex = 7;
			button7.Text = "Atualizar Aluno";
			button7.UseVisualStyleBackColor = true;
			button7.Click += button7_Click;
			// 
			// button8
			// 
			button8.Font = new Font("Segoe UI", 10F);
			button8.ForeColor = Color.Black;
			button8.Location = new Point(693, 244);
			button8.Name = "button8";
			button8.Size = new Size(95, 35);
			button8.TabIndex = 8;
			button8.Text = "Excluir Aluno";
			button8.UseVisualStyleBackColor = true;
			// 
			// button9
			// 
			button9.Font = new Font("Segoe UI", 10F);
			button9.ForeColor = Color.Black;
			button9.Location = new Point(12, 295);
			button9.Name = "button9";
			button9.Size = new Size(139, 28);
			button9.TabIndex = 9;
			button9.Text = "Atualizar Professor";
			button9.UseVisualStyleBackColor = true;
			// 
			// button10
			// 
			button10.Font = new Font("Segoe UI", 10F);
			button10.ForeColor = Color.Black;
			button10.Location = new Point(672, 294);
			button10.Name = "button10";
			button10.Size = new Size(116, 31);
			button10.TabIndex = 10;
			button10.Text = "Excluir Professor";
			button10.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			BackgroundImage = Properties.Resources.horizonte_idiomas_resized;
			ClientSize = new Size(800, 450);
			Controls.Add(button10);
			Controls.Add(button9);
			Controls.Add(button8);
			Controls.Add(button7);
			Controls.Add(button6);
			Controls.Add(button5);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label1);
			ForeColor = Color.OrangeRed;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
		private Button button6;
		private Button button7;
		private Button button8;
		private Button button9;
		private Button button10;
	}
}
