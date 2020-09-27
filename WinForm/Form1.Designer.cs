namespace WinForm
{
	partial class Form_Principal
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
			this.btn_adicionar = new System.Windows.Forms.Button();
			this.lbl_texto = new System.Windows.Forms.Label();
			this.txb_veiculo = new System.Windows.Forms.TextBox();
			this.lbl_newText = new System.Windows.Forms.Label();
			this.txb_listaVeiculos = new System.Windows.Forms.TextBox();
			this.btn_limpar = new System.Windows.Forms.Button();
			this.btn_mostrar = new System.Windows.Forms.Button();
			this.btn_valNum = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_adicionar
			// 
			this.btn_adicionar.BackColor = System.Drawing.Color.Green;
			this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_adicionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btn_adicionar.Location = new System.Drawing.Point(273, 68);
			this.btn_adicionar.Name = "btn_adicionar";
			this.btn_adicionar.Size = new System.Drawing.Size(155, 42);
			this.btn_adicionar.TabIndex = 0;
			this.btn_adicionar.Text = "ADICIONAR";
			this.btn_adicionar.UseVisualStyleBackColor = false;
			this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
			// 
			// lbl_texto
			// 
			this.lbl_texto.AutoSize = true;
			this.lbl_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_texto.Location = new System.Drawing.Point(110, 9);
			this.lbl_texto.Name = "lbl_texto";
			this.lbl_texto.Size = new System.Drawing.Size(224, 31);
			this.lbl_texto.TabIndex = 1;
			this.lbl_texto.Text = "Digite um Veiculo";
			// 
			// txb_veiculo
			// 
			this.txb_veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_veiculo.Location = new System.Drawing.Point(12, 71);
			this.txb_veiculo.Multiline = true;
			this.txb_veiculo.Name = "txb_veiculo";
			this.txb_veiculo.Size = new System.Drawing.Size(236, 35);
			this.txb_veiculo.TabIndex = 2;
			// 
			// lbl_newText
			// 
			this.lbl_newText.AutoSize = true;
			this.lbl_newText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_newText.Location = new System.Drawing.Point(168, 217);
			this.lbl_newText.Name = "lbl_newText";
			this.lbl_newText.Size = new System.Drawing.Size(0, 25);
			this.lbl_newText.TabIndex = 3;
			// 
			// txb_listaVeiculos
			// 
			this.txb_listaVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_listaVeiculos.Location = new System.Drawing.Point(12, 123);
			this.txb_listaVeiculos.Multiline = true;
			this.txb_listaVeiculos.Name = "txb_listaVeiculos";
			this.txb_listaVeiculos.ReadOnly = true;
			this.txb_listaVeiculos.Size = new System.Drawing.Size(416, 200);
			this.txb_listaVeiculos.TabIndex = 4;
			// 
			// btn_limpar
			// 
			this.btn_limpar.BackColor = System.Drawing.Color.DarkRed;
			this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_limpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btn_limpar.Location = new System.Drawing.Point(12, 349);
			this.btn_limpar.Name = "btn_limpar";
			this.btn_limpar.Size = new System.Drawing.Size(198, 42);
			this.btn_limpar.TabIndex = 5;
			this.btn_limpar.Text = "LIMPAR";
			this.btn_limpar.UseVisualStyleBackColor = false;
			this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
			// 
			// btn_mostrar
			// 
			this.btn_mostrar.BackColor = System.Drawing.Color.CadetBlue;
			this.btn_mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_mostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btn_mostrar.Location = new System.Drawing.Point(230, 349);
			this.btn_mostrar.Name = "btn_mostrar";
			this.btn_mostrar.Size = new System.Drawing.Size(198, 42);
			this.btn_mostrar.TabIndex = 6;
			this.btn_mostrar.Text = "MOSTRAR VEICULOS";
			this.btn_mostrar.UseVisualStyleBackColor = false;
			this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
			// 
			// btn_valNum
			// 
			this.btn_valNum.BackColor = System.Drawing.Color.CadetBlue;
			this.btn_valNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_valNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btn_valNum.Location = new System.Drawing.Point(12, 408);
			this.btn_valNum.Name = "btn_valNum";
			this.btn_valNum.Size = new System.Drawing.Size(416, 42);
			this.btn_valNum.TabIndex = 7;
			this.btn_valNum.Text = "VALOR DA VARIAVEL NUM";
			this.btn_valNum.UseVisualStyleBackColor = false;
			this.btn_valNum.Click += new System.EventHandler(this.btn_valNum_Click);
			// 
			// Form_Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 582);
			this.Controls.Add(this.btn_valNum);
			this.Controls.Add(this.btn_mostrar);
			this.Controls.Add(this.btn_limpar);
			this.Controls.Add(this.txb_listaVeiculos);
			this.Controls.Add(this.lbl_newText);
			this.Controls.Add(this.txb_veiculo);
			this.Controls.Add(this.lbl_texto);
			this.Controls.Add(this.btn_adicionar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form_Principal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Estudo Windows Form";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_adicionar;
		private System.Windows.Forms.Label lbl_texto;
		private System.Windows.Forms.TextBox txb_veiculo;
		private System.Windows.Forms.Label lbl_newText;
		private System.Windows.Forms.Button btn_limpar;
		private System.Windows.Forms.Button btn_mostrar;
		private System.Windows.Forms.Button btn_valNum;
		public System.Windows.Forms.TextBox txb_listaVeiculos;
	}
}

