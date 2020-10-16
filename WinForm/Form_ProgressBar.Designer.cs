namespace WinForm
{
	partial class Form_ProgressBar
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
			this.pb_progresso = new System.Windows.Forms.ProgressBar();
			this.btn_iniciar = new System.Windows.Forms.Button();
			this.txt_valor = new System.Windows.Forms.TextBox();
			this.btn_valor = new System.Windows.Forms.Button();
			this.btn_iniciarFor = new System.Windows.Forms.Button();
			this.pb_progresso2 = new System.Windows.Forms.ProgressBar();
			this.txb_for = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pb_progresso
			// 
			this.pb_progresso.Location = new System.Drawing.Point(53, 182);
			this.pb_progresso.Name = "pb_progresso";
			this.pb_progresso.Size = new System.Drawing.Size(468, 23);
			this.pb_progresso.TabIndex = 0;
			// 
			// btn_iniciar
			// 
			this.btn_iniciar.Location = new System.Drawing.Point(236, 211);
			this.btn_iniciar.Name = "btn_iniciar";
			this.btn_iniciar.Size = new System.Drawing.Size(100, 23);
			this.btn_iniciar.TabIndex = 1;
			this.btn_iniciar.Text = "Iniciar ";
			this.btn_iniciar.UseVisualStyleBackColor = true;
			this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
			// 
			// txt_valor
			// 
			this.txt_valor.Location = new System.Drawing.Point(236, 86);
			this.txt_valor.Name = "txt_valor";
			this.txt_valor.Size = new System.Drawing.Size(100, 20);
			this.txt_valor.TabIndex = 2;
			this.txt_valor.Text = "0";
			// 
			// btn_valor
			// 
			this.btn_valor.Location = new System.Drawing.Point(236, 112);
			this.btn_valor.Name = "btn_valor";
			this.btn_valor.Size = new System.Drawing.Size(100, 23);
			this.btn_valor.TabIndex = 3;
			this.btn_valor.Text = "Definir valor";
			this.btn_valor.UseVisualStyleBackColor = true;
			this.btn_valor.Click += new System.EventHandler(this.btn_valor_Click);
			// 
			// btn_iniciarFor
			// 
			this.btn_iniciarFor.Location = new System.Drawing.Point(236, 346);
			this.btn_iniciarFor.Name = "btn_iniciarFor";
			this.btn_iniciarFor.Size = new System.Drawing.Size(100, 23);
			this.btn_iniciarFor.TabIndex = 5;
			this.btn_iniciarFor.Text = "Iniciar For";
			this.btn_iniciarFor.UseVisualStyleBackColor = true;
			this.btn_iniciarFor.Click += new System.EventHandler(this.btn_iniciarFor_Click);
			// 
			// pb_progresso2
			// 
			this.pb_progresso2.Location = new System.Drawing.Point(52, 291);
			this.pb_progresso2.Name = "pb_progresso2";
			this.pb_progresso2.Size = new System.Drawing.Size(468, 23);
			this.pb_progresso2.TabIndex = 4;
			// 
			// txb_for
			// 
			this.txb_for.Location = new System.Drawing.Point(236, 320);
			this.txb_for.Name = "txb_for";
			this.txb_for.Size = new System.Drawing.Size(100, 20);
			this.txb_for.TabIndex = 6;
			this.txb_for.Text = "10000";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(267, 372);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "label1";
			// 
			// Form_ProgressBar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(573, 470);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txb_for);
			this.Controls.Add(this.btn_iniciarFor);
			this.Controls.Add(this.pb_progresso2);
			this.Controls.Add(this.btn_valor);
			this.Controls.Add(this.txt_valor);
			this.Controls.Add(this.btn_iniciar);
			this.Controls.Add(this.pb_progresso);
			this.Name = "Form_ProgressBar";
			this.Text = "Form_ProgressBar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btn_iniciar;
		private System.Windows.Forms.TextBox txt_valor;
		private System.Windows.Forms.Button btn_valor;
		private System.Windows.Forms.ProgressBar pb_progresso;
		private System.Windows.Forms.Button btn_iniciarFor;
		private System.Windows.Forms.ProgressBar pb_progresso2;
		private System.Windows.Forms.TextBox txb_for;
		private System.Windows.Forms.Label label1;
	}
}