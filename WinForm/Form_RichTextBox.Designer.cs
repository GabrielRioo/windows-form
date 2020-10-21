namespace WinForm
{
	partial class Form_RichTextBox
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
			this.rtxb_editor = new System.Windows.Forms.RichTextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.itálicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.centralizadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.justificadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_novo = new System.Windows.Forms.ToolStripButton();
			this.btn_abrir = new System.Windows.Forms.ToolStripButton();
			this.btn_Salvar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_copiar = new System.Windows.Forms.ToolStripButton();
			this.btn_colar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_negrito = new System.Windows.Forms.ToolStripButton();
			this.btn_italico = new System.Windows.Forms.ToolStripButton();
			this.btn_sublinhado = new System.Windows.Forms.ToolStripButton();
			this.btn_fonte = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_esquerda = new System.Windows.Forms.ToolStripButton();
			this.btn_centro = new System.Windows.Forms.ToolStripButton();
			this.btn_direita = new System.Windows.Forms.ToolStripButton();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// rtxb_editor
			// 
			this.rtxb_editor.Location = new System.Drawing.Point(0, 52);
			this.rtxb_editor.Name = "rtxb_editor";
			this.rtxb_editor.Size = new System.Drawing.Size(553, 421);
			this.rtxb_editor.TabIndex = 0;
			this.rtxb_editor.Text = "";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(553, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
			// 
			// arquivoToolStripMenuItem
			// 
			this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sairToolStripMenuItem1});
			this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
			this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.arquivoToolStripMenuItem.Text = "Arquivo";
			// 
			// novoToolStripMenuItem
			// 
			this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
			this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.novoToolStripMenuItem.Text = "Novo";
			this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
			// 
			// abrirToolStripMenuItem
			// 
			this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
			this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.abrirToolStripMenuItem.Text = "Abrir";
			this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
			// 
			// salvarToolStripMenuItem
			// 
			this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
			this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.salvarToolStripMenuItem.Text = "Salvar";
			this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
			// 
			// imprimirToolStripMenuItem
			// 
			this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
			this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.imprimirToolStripMenuItem.Text = "Imprimir";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
			// 
			// sairToolStripMenuItem1
			// 
			this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
			this.sairToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.sairToolStripMenuItem1.Text = "Sair";
			// 
			// editarToolStripMenuItem
			// 
			this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.desfazerToolStripMenuItem,
            this.refazerToolStripMenuItem});
			this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
			this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.editarToolStripMenuItem.Text = "Editar";
			// 
			// copiarToolStripMenuItem
			// 
			this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
			this.copiarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.copiarToolStripMenuItem.Text = "Copiar";
			// 
			// colarToolStripMenuItem
			// 
			this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
			this.colarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.colarToolStripMenuItem.Text = "Colar";
			// 
			// desfazerToolStripMenuItem
			// 
			this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
			this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.desfazerToolStripMenuItem.Text = "Desfazer";
			// 
			// refazerToolStripMenuItem
			// 
			this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
			this.refazerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.refazerToolStripMenuItem.Text = "Refazer";
			// 
			// formatarToolStripMenuItem
			// 
			this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritoToolStripMenuItem,
            this.itálicoToolStripMenuItem,
            this.sublinhadoToolStripMenuItem,
            this.alinhamentoToolStripMenuItem});
			this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
			this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.formatarToolStripMenuItem.Text = "Formatar";
			// 
			// negritoToolStripMenuItem
			// 
			this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
			this.negritoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.negritoToolStripMenuItem.Text = "Negrito";
			// 
			// itálicoToolStripMenuItem
			// 
			this.itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
			this.itálicoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.itálicoToolStripMenuItem.Text = "Itálico";
			// 
			// sublinhadoToolStripMenuItem
			// 
			this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
			this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.sublinhadoToolStripMenuItem.Text = "Sublinhado";
			// 
			// alinhamentoToolStripMenuItem
			// 
			this.alinhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esquerdaToolStripMenuItem,
            this.direitaToolStripMenuItem,
            this.centralizadoToolStripMenuItem,
            this.justificadaToolStripMenuItem});
			this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
			this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
			// 
			// esquerdaToolStripMenuItem
			// 
			this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
			this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.esquerdaToolStripMenuItem.Text = "Esquerda";
			// 
			// direitaToolStripMenuItem
			// 
			this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
			this.direitaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.direitaToolStripMenuItem.Text = "Direita";
			// 
			// centralizadoToolStripMenuItem
			// 
			this.centralizadoToolStripMenuItem.Name = "centralizadoToolStripMenuItem";
			this.centralizadoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.centralizadoToolStripMenuItem.Text = "Centralizado";
			// 
			// justificadaToolStripMenuItem
			// 
			this.justificadaToolStripMenuItem.Name = "justificadaToolStripMenuItem";
			this.justificadaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.justificadaToolStripMenuItem.Text = "Justificada";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_novo,
            this.btn_abrir,
            this.btn_Salvar,
            this.toolStripSeparator1,
            this.btn_copiar,
            this.btn_colar,
            this.toolStripSeparator2,
            this.btn_negrito,
            this.btn_italico,
            this.btn_sublinhado,
            this.btn_fonte,
            this.toolStripSeparator3,
            this.btn_esquerda,
            this.btn_centro,
            this.btn_direita});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(553, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btn_novo
			// 
			this.btn_novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_novo.Image = global::WinForm.Properties.Resources.Vector__3_;
			this.btn_novo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_novo.Name = "btn_novo";
			this.btn_novo.Size = new System.Drawing.Size(23, 22);
			this.btn_novo.Text = "Novo";
			this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
			// 
			// btn_abrir
			// 
			this.btn_abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_abrir.Image = global::WinForm.Properties.Resources.abrir1;
			this.btn_abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_abrir.Name = "btn_abrir";
			this.btn_abrir.Size = new System.Drawing.Size(23, 22);
			this.btn_abrir.Text = "Abrir";
			this.btn_abrir.Click += new System.EventHandler(this.btn_abrir_Click);
			// 
			// btn_Salvar
			// 
			this.btn_Salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_Salvar.Image = global::WinForm.Properties.Resources.salvar;
			this.btn_Salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_Salvar.Name = "btn_Salvar";
			this.btn_Salvar.Size = new System.Drawing.Size(23, 22);
			this.btn_Salvar.Text = "Salvar";
			this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// btn_copiar
			// 
			this.btn_copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_copiar.Image = global::WinForm.Properties.Resources.copiar;
			this.btn_copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_copiar.Name = "btn_copiar";
			this.btn_copiar.Size = new System.Drawing.Size(23, 22);
			this.btn_copiar.Text = "Copiar";
			// 
			// btn_colar
			// 
			this.btn_colar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_colar.Image = global::WinForm.Properties.Resources.colar;
			this.btn_colar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_colar.Name = "btn_colar";
			this.btn_colar.Size = new System.Drawing.Size(23, 22);
			this.btn_colar.Text = "Colar";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// btn_negrito
			// 
			this.btn_negrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_negrito.Image = global::WinForm.Properties.Resources.bold;
			this.btn_negrito.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_negrito.Name = "btn_negrito";
			this.btn_negrito.Size = new System.Drawing.Size(23, 22);
			this.btn_negrito.Text = "Negrito";
			// 
			// btn_italico
			// 
			this.btn_italico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_italico.Image = global::WinForm.Properties.Resources.I;
			this.btn_italico.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_italico.Name = "btn_italico";
			this.btn_italico.Size = new System.Drawing.Size(23, 22);
			this.btn_italico.Text = "Itálico";
			// 
			// btn_sublinhado
			// 
			this.btn_sublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_sublinhado.Image = global::WinForm.Properties.Resources.U;
			this.btn_sublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_sublinhado.Name = "btn_sublinhado";
			this.btn_sublinhado.Size = new System.Drawing.Size(23, 22);
			this.btn_sublinhado.Text = "sublinhado";
			// 
			// btn_fonte
			// 
			this.btn_fonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_fonte.Image = global::WinForm.Properties.Resources.A;
			this.btn_fonte.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_fonte.Name = "btn_fonte";
			this.btn_fonte.Size = new System.Drawing.Size(23, 22);
			this.btn_fonte.Text = "Fonte";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// btn_esquerda
			// 
			this.btn_esquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_esquerda.Image = global::WinForm.Properties.Resources.esquerda;
			this.btn_esquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_esquerda.Name = "btn_esquerda";
			this.btn_esquerda.Size = new System.Drawing.Size(23, 22);
			this.btn_esquerda.Text = "Esquerda";
			// 
			// btn_centro
			// 
			this.btn_centro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_centro.Image = global::WinForm.Properties.Resources.centro;
			this.btn_centro.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_centro.Name = "btn_centro";
			this.btn_centro.Size = new System.Drawing.Size(23, 22);
			this.btn_centro.Text = "Centro";
			// 
			// btn_direita
			// 
			this.btn_direita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_direita.Image = global::WinForm.Properties.Resources.direita;
			this.btn_direita.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_direita.Name = "btn_direita";
			this.btn_direita.Size = new System.Drawing.Size(23, 22);
			this.btn_direita.Text = "Direita";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "txt";
			this.saveFileDialog1.Filter = "(*.txt)|*.txt";
			// 
			// printDialog1
			// 
			this.printDialog1.UseEXDialog = true;
			// 
			// Form_RichTextBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(553, 473);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.rtxb_editor);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form_RichTextBox";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Editor de Texto";
			this.Load += new System.EventHandler(this.Form_RichTextBox_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtxb_editor;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem negritoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem itálicoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sublinhadoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alinhamentoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem esquerdaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem direitaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem centralizadoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem justificadaToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton btn_novo;
		private System.Windows.Forms.ToolStripButton btn_abrir;
		private System.Windows.Forms.ToolStripButton btn_Salvar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btn_copiar;
		private System.Windows.Forms.ToolStripButton btn_colar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btn_negrito;
		private System.Windows.Forms.ToolStripButton btn_italico;
		private System.Windows.Forms.ToolStripButton btn_sublinhado;
		private System.Windows.Forms.ToolStripButton btn_fonte;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton btn_esquerda;
		private System.Windows.Forms.ToolStripButton btn_centro;
		private System.Windows.Forms.ToolStripButton btn_direita;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
	}
}