namespace WinForm
{
	partial class Form_MaskedTextBox
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
			this.mtb_senha = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.mtb_cep = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_enviar = new System.Windows.Forms.Button();
			this.chk_texto = new System.Windows.Forms.CheckBox();
			this.chk_verSenha = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// mtb_senha
			// 
			this.mtb_senha.Location = new System.Drawing.Point(12, 44);
			this.mtb_senha.Name = "mtb_senha";
			this.mtb_senha.PasswordChar = '*';
			this.mtb_senha.Size = new System.Drawing.Size(129, 20);
			this.mtb_senha.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Senha";
			// 
			// mtb_cep
			// 
			this.mtb_cep.Location = new System.Drawing.Point(16, 139);
			this.mtb_cep.Mask = "00000-999";
			this.mtb_cep.Name = "mtb_cep";
			this.mtb_cep.Size = new System.Drawing.Size(69, 20);
			this.mtb_cep.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 123);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "CEP";
			// 
			// mtb_cpf
			// 
			this.mtb_cpf.Location = new System.Drawing.Point(16, 215);
			this.mtb_cpf.Mask = "000.000.000-00";
			this.mtb_cpf.Name = "mtb_cpf";
			this.mtb_cpf.Size = new System.Drawing.Size(89, 20);
			this.mtb_cpf.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 199);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "CPF";
			// 
			// btn_enviar
			// 
			this.btn_enviar.Location = new System.Drawing.Point(215, 215);
			this.btn_enviar.Name = "btn_enviar";
			this.btn_enviar.Size = new System.Drawing.Size(75, 23);
			this.btn_enviar.TabIndex = 6;
			this.btn_enviar.Text = "Enviar";
			this.btn_enviar.UseVisualStyleBackColor = true;
			this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
			// 
			// chk_texto
			// 
			this.chk_texto.AutoSize = true;
			this.chk_texto.Location = new System.Drawing.Point(111, 217);
			this.chk_texto.Name = "chk_texto";
			this.chk_texto.Size = new System.Drawing.Size(98, 17);
			this.chk_texto.TabIndex = 7;
			this.chk_texto.Text = "Somente Texto";
			this.chk_texto.UseVisualStyleBackColor = true;
			// 
			// chk_verSenha
			// 
			this.chk_verSenha.AutoSize = true;
			this.chk_verSenha.Location = new System.Drawing.Point(147, 44);
			this.chk_verSenha.Name = "chk_verSenha";
			this.chk_verSenha.Size = new System.Drawing.Size(76, 17);
			this.chk_verSenha.TabIndex = 8;
			this.chk_verSenha.Text = "Ver Senha";
			this.chk_verSenha.UseVisualStyleBackColor = true;
			this.chk_verSenha.CheckedChanged += new System.EventHandler(this.chk_verSenha_CheckedChanged);
			// 
			// Form_MaskedTextBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 480);
			this.Controls.Add(this.chk_verSenha);
			this.Controls.Add(this.chk_texto);
			this.Controls.Add(this.btn_enviar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.mtb_cpf);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.mtb_cep);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.mtb_senha);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form_MaskedTextBox";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form_MaskedTextBox";
			this.Load += new System.EventHandler(this.Form_MaskedTextBox_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox mtb_senha;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox mtb_cep;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox mtb_cpf;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_enviar;
		private System.Windows.Forms.CheckBox chk_texto;
		private System.Windows.Forms.CheckBox chk_verSenha;
	}
}