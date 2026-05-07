namespace Escola_de_Idiomas
{
	partial class Cursos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cursos));
			label1 = new Label();
			dataGridView1 = new DataGridView();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15F);
			label1.ForeColor = Color.OrangeRed;
			label1.Location = new Point(318, 30);
			label1.Name = "label1";
			label1.Size = new Size(142, 28);
			label1.TabIndex = 0;
			label1.Text = "Área de Cursos";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(27, 99);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(433, 243);
			dataGridView1.TabIndex = 1;
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI", 15F);
			button1.Location = new Point(622, 85);
			button1.Name = "button1";
			button1.Size = new Size(167, 38);
			button1.TabIndex = 2;
			button1.Text = "Adicionar Cursos";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Font = new Font("Segoe UI", 15F);
			button2.Location = new Point(622, 146);
			button2.Name = "button2";
			button2.Size = new Size(167, 35);
			button2.TabIndex = 3;
			button2.Text = "Excluir Cursos";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Font = new Font("Segoe UI", 15F);
			button3.Location = new Point(613, 200);
			button3.Margin = new Padding(3, 2, 3, 2);
			button3.Name = "button3";
			button3.Size = new Size(176, 37);
			button3.TabIndex = 4;
			button3.Text = "Atualizar Cursos";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// Cursos
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.Copilot_20260430_1446158;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(800, 450);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(dataGridView1);
			Controls.Add(label1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Cursos";
			Text = "Cursos";
			Load += Cursos_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private DataGridView dataGridView1;
		private Button button1;
		private Button button2;
        private Button button3;
    }
}