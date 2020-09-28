namespace WinForm
{
	partial class Form_ComboBox
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
			this.cb_transporte = new System.Windows.Forms.ComboBox();
			this.btn_mostrarSelecionado = new System.Windows.Forms.Button();
			this.btn_limpar = new System.Windows.Forms.Button();
			this.btn_resetarElementos = new System.Windows.Forms.Button();
			this.btn_adicionar = new System.Windows.Forms.Button();
			this.txb_transporte = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_resultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cb_transporte
			// 
			this.cb_transporte.FormattingEnabled = true;
			this.cb_transporte.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Onibus",
            "Trem"});
			this.cb_transporte.Location = new System.Drawing.Point(12, 12);
			this.cb_transporte.Name = "cb_transporte";
			this.cb_transporte.Size = new System.Drawing.Size(295, 21);
			this.cb_transporte.TabIndex = 0;
			this.cb_transporte.SelectedIndexChanged += new System.EventHandler(this.cb_transporte_SelectedIndexChanged);
			// 
			// btn_mostrarSelecionado
			// 
			this.btn_mostrarSelecionado.Location = new System.Drawing.Point(313, 12);
			this.btn_mostrarSelecionado.Name = "btn_mostrarSelecionado";
			this.btn_mostrarSelecionado.Size = new System.Drawing.Size(238, 23);
			this.btn_mostrarSelecionado.TabIndex = 1;
			this.btn_mostrarSelecionado.Text = "Mostrar Selecionado";
			this.btn_mostrarSelecionado.UseVisualStyleBackColor = false;
			this.btn_mostrarSelecionado.Click += new System.EventHandler(this.btn_mostrarSelecionado_Click);
			// 
			// btn_limpar
			// 
			this.btn_limpar.Location = new System.Drawing.Point(313, 41);
			this.btn_limpar.Name = "btn_limpar";
			this.btn_limpar.Size = new System.Drawing.Size(238, 23);
			this.btn_limpar.TabIndex = 2;
			this.btn_limpar.Text = "Limpar Elementos";
			this.btn_limpar.UseVisualStyleBackColor = true;
			this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
			// 
			// btn_resetarElementos
			// 
			this.btn_resetarElementos.Location = new System.Drawing.Point(313, 70);
			this.btn_resetarElementos.Name = "btn_resetarElementos";
			this.btn_resetarElementos.Size = new System.Drawing.Size(238, 23);
			this.btn_resetarElementos.TabIndex = 3;
			this.btn_resetarElementos.Text = "Resetar Elementos";
			this.btn_resetarElementos.UseVisualStyleBackColor = true;
			this.btn_resetarElementos.Click += new System.EventHandler(this.btn_resetarElementos_Click);
			// 
			// btn_adicionar
			// 
			this.btn_adicionar.Location = new System.Drawing.Point(313, 146);
			this.btn_adicionar.Name = "btn_adicionar";
			this.btn_adicionar.Size = new System.Drawing.Size(238, 23);
			this.btn_adicionar.TabIndex = 4;
			this.btn_adicionar.Text = "Adicionar Novo Transporte";
			this.btn_adicionar.UseVisualStyleBackColor = true;
			this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
			// 
			// txb_transporte
			// 
			this.txb_transporte.Location = new System.Drawing.Point(313, 120);
			this.txb_transporte.Name = "txb_transporte";
			this.txb_transporte.Size = new System.Drawing.Size(238, 20);
			this.txb_transporte.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(313, 187);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 6;
			// 
			// lbl_resultado
			// 
			this.lbl_resultado.AutoSize = true;
			this.lbl_resultado.Location = new System.Drawing.Point(313, 187);
			this.lbl_resultado.Name = "lbl_resultado";
			this.lbl_resultado.Size = new System.Drawing.Size(0, 13);
			this.lbl_resultado.TabIndex = 7;
			// 
			// Form_ComboBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(563, 450);
			this.Controls.Add(this.lbl_resultado);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txb_transporte);
			this.Controls.Add(this.btn_adicionar);
			this.Controls.Add(this.btn_resetarElementos);
			this.Controls.Add(this.btn_limpar);
			this.Controls.Add(this.btn_mostrarSelecionado);
			this.Controls.Add(this.cb_transporte);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form_ComboBox";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ComboBox";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cb_transporte;
		private System.Windows.Forms.Button btn_mostrarSelecionado;
		private System.Windows.Forms.Button btn_limpar;
		private System.Windows.Forms.Button btn_resetarElementos;
		private System.Windows.Forms.Button btn_adicionar;
		private System.Windows.Forms.TextBox txb_transporte;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_resultado;
	}
}