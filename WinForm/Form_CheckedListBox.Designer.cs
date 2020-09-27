namespace WinForm
{
	partial class Form_CheckedListBox
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
			this.clb_transportes = new System.Windows.Forms.CheckedListBox();
			this.btn_mostrarSelecionados = new System.Windows.Forms.Button();
			this.btn_limparLista = new System.Windows.Forms.Button();
			this.btn_resetarLista = new System.Windows.Forms.Button();
			this.btn_adicionarTransporte = new System.Windows.Forms.Button();
			this.tbx_NovoTransporte = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// clb_transportes
			// 
			this.clb_transportes.FormattingEnabled = true;
			this.clb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Onibus",
            "Trem"});
			this.clb_transportes.Location = new System.Drawing.Point(12, 12);
			this.clb_transportes.Name = "clb_transportes";
			this.clb_transportes.Size = new System.Drawing.Size(120, 259);
			this.clb_transportes.TabIndex = 0;
			// 
			// btn_mostrarSelecionados
			// 
			this.btn_mostrarSelecionados.Location = new System.Drawing.Point(154, 12);
			this.btn_mostrarSelecionados.Name = "btn_mostrarSelecionados";
			this.btn_mostrarSelecionados.Size = new System.Drawing.Size(287, 26);
			this.btn_mostrarSelecionados.TabIndex = 1;
			this.btn_mostrarSelecionados.Text = "MOSTRAR SELECIONADOS";
			this.btn_mostrarSelecionados.UseVisualStyleBackColor = true;
			this.btn_mostrarSelecionados.Click += new System.EventHandler(this.btn_mostrarSelecionados_Click);
			// 
			// btn_limparLista
			// 
			this.btn_limparLista.Location = new System.Drawing.Point(154, 44);
			this.btn_limparLista.Name = "btn_limparLista";
			this.btn_limparLista.Size = new System.Drawing.Size(287, 26);
			this.btn_limparLista.TabIndex = 2;
			this.btn_limparLista.Text = "LIMPAR LISTA";
			this.btn_limparLista.UseVisualStyleBackColor = true;
			this.btn_limparLista.Click += new System.EventHandler(this.btn_limparLista_Click);
			// 
			// btn_resetarLista
			// 
			this.btn_resetarLista.Location = new System.Drawing.Point(154, 76);
			this.btn_resetarLista.Name = "btn_resetarLista";
			this.btn_resetarLista.Size = new System.Drawing.Size(287, 26);
			this.btn_resetarLista.TabIndex = 3;
			this.btn_resetarLista.Text = "RESETAR A LISTA";
			this.btn_resetarLista.UseVisualStyleBackColor = true;
			this.btn_resetarLista.Click += new System.EventHandler(this.btn_resetarLista_Click);
			// 
			// btn_adicionarTransporte
			// 
			this.btn_adicionarTransporte.Location = new System.Drawing.Point(154, 245);
			this.btn_adicionarTransporte.Name = "btn_adicionarTransporte";
			this.btn_adicionarTransporte.Size = new System.Drawing.Size(287, 26);
			this.btn_adicionarTransporte.TabIndex = 4;
			this.btn_adicionarTransporte.Text = "ADICIONAR NOVO TRANSPORTE";
			this.btn_adicionarTransporte.UseVisualStyleBackColor = true;
			this.btn_adicionarTransporte.Click += new System.EventHandler(this.btn_adicionarTransporte_Click);
			// 
			// tbx_NovoTransporte
			// 
			this.tbx_NovoTransporte.Location = new System.Drawing.Point(154, 219);
			this.tbx_NovoTransporte.Name = "tbx_NovoTransporte";
			this.tbx_NovoTransporte.Size = new System.Drawing.Size(287, 20);
			this.tbx_NovoTransporte.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(151, 199);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(171, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Digite um novo transporte";
			// 
			// Form_CheckedListBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 517);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbx_NovoTransporte);
			this.Controls.Add(this.btn_adicionarTransporte);
			this.Controls.Add(this.btn_resetarLista);
			this.Controls.Add(this.btn_limparLista);
			this.Controls.Add(this.btn_mostrarSelecionados);
			this.Controls.Add(this.clb_transportes);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form_CheckedListBox";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CheckedListBox";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox clb_transportes;
		private System.Windows.Forms.Button btn_mostrarSelecionados;
		private System.Windows.Forms.Button btn_limparLista;
		private System.Windows.Forms.Button btn_resetarLista;
		private System.Windows.Forms.Button btn_adicionarTransporte;
		private System.Windows.Forms.TextBox tbx_NovoTransporte;
		private System.Windows.Forms.Label label1;
	}
}