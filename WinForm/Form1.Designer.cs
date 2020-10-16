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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
			this.btn_adicionar = new System.Windows.Forms.Button();
			this.lbl_texto = new System.Windows.Forms.Label();
			this.txb_veiculo = new System.Windows.Forms.TextBox();
			this.lbl_newText = new System.Windows.Forms.Label();
			this.txb_listaVeiculos = new System.Windows.Forms.TextBox();
			this.btn_limpar = new System.Windows.Forms.Button();
			this.btn_mostrar = new System.Windows.Forms.Button();
			this.btn_valNum = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.checkedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dateTimePickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.labelLinkLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.maskedTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.monthCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.numericUpDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.MenuNotificacoes = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmi_Restaurar = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmi_Mensagem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmi_Fechar = new System.Windows.Forms.ToolStripMenuItem();
			this.progressBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.MenuNotificacoes.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_adicionar
			// 
			this.btn_adicionar.BackColor = System.Drawing.Color.Green;
			this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_adicionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btn_adicionar.Location = new System.Drawing.Point(273, 101);
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
			this.lbl_texto.Location = new System.Drawing.Point(74, 45);
			this.lbl_texto.Name = "lbl_texto";
			this.lbl_texto.Size = new System.Drawing.Size(303, 31);
			this.lbl_texto.TabIndex = 1;
			this.lbl_texto.Text = "Digite um Alguma Coisa";
			this.lbl_texto.Click += new System.EventHandler(this.lbl_texto_Click);
			// 
			// txb_veiculo
			// 
			this.txb_veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_veiculo.Location = new System.Drawing.Point(12, 104);
			this.txb_veiculo.Multiline = true;
			this.txb_veiculo.Name = "txb_veiculo";
			this.txb_veiculo.Size = new System.Drawing.Size(236, 35);
			this.txb_veiculo.TabIndex = 2;
			// 
			// lbl_newText
			// 
			this.lbl_newText.AutoSize = true;
			this.lbl_newText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_newText.Location = new System.Drawing.Point(168, 250);
			this.lbl_newText.Name = "lbl_newText";
			this.lbl_newText.Size = new System.Drawing.Size(0, 25);
			this.lbl_newText.TabIndex = 3;
			// 
			// txb_listaVeiculos
			// 
			this.txb_listaVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_listaVeiculos.Location = new System.Drawing.Point(12, 162);
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
			this.btn_limpar.Location = new System.Drawing.Point(12, 382);
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
			this.btn_mostrar.Location = new System.Drawing.Point(230, 382);
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
			this.btn_valNum.Location = new System.Drawing.Point(12, 441);
			this.btn_valNum.Name = "btn_valNum";
			this.btn_valNum.Size = new System.Drawing.Size(416, 42);
			this.btn_valNum.TabIndex = 7;
			this.btn_valNum.Text = "VALOR DA VARIAVEL NUM";
			this.btn_valNum.UseVisualStyleBackColor = false;
			this.btn_valNum.Click += new System.EventHandler(this.btn_valNum_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(445, 24);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// componentesToolStripMenuItem
			// 
			this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem,
            this.checkedToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.dateTimePickerToolStripMenuItem,
            this.labelLinkLabelToolStripMenuItem,
            this.listBoxToolStripMenuItem,
            this.listViewToolStripMenuItem,
            this.maskedTextBoxToolStripMenuItem,
            this.monthCalendarToolStripMenuItem,
            this.numericUpDownToolStripMenuItem,
            this.pictureBoxToolStripMenuItem,
            this.progressBarToolStripMenuItem});
			this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
			this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
			this.componentesToolStripMenuItem.Text = "Componentes";
			// 
			// checkBoxToolStripMenuItem
			// 
			this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
			this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.checkBoxToolStripMenuItem.Text = "CheckBox";
			this.checkBoxToolStripMenuItem.Click += new System.EventHandler(this.checkBoxToolStripMenuItem_Click);
			// 
			// checkedToolStripMenuItem
			// 
			this.checkedToolStripMenuItem.Name = "checkedToolStripMenuItem";
			this.checkedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.checkedToolStripMenuItem.Text = "CheckedListBox";
			this.checkedToolStripMenuItem.Click += new System.EventHandler(this.checkedToolStripMenuItem_Click);
			// 
			// comboBoxToolStripMenuItem
			// 
			this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
			this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.comboBoxToolStripMenuItem.Text = "ComboBox";
			this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
			// 
			// dateTimePickerToolStripMenuItem
			// 
			this.dateTimePickerToolStripMenuItem.Name = "dateTimePickerToolStripMenuItem";
			this.dateTimePickerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.dateTimePickerToolStripMenuItem.Text = "Date Time Picker";
			this.dateTimePickerToolStripMenuItem.Click += new System.EventHandler(this.dateTimePickerToolStripMenuItem_Click);
			// 
			// labelLinkLabelToolStripMenuItem
			// 
			this.labelLinkLabelToolStripMenuItem.Name = "labelLinkLabelToolStripMenuItem";
			this.labelLinkLabelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.labelLinkLabelToolStripMenuItem.Text = "Label / Link Label";
			this.labelLinkLabelToolStripMenuItem.Click += new System.EventHandler(this.labelLinkLabelToolStripMenuItem_Click);
			// 
			// listBoxToolStripMenuItem
			// 
			this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
			this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.listBoxToolStripMenuItem.Text = "List Box";
			this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
			// 
			// listViewToolStripMenuItem
			// 
			this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
			this.listViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.listViewToolStripMenuItem.Text = "List View";
			this.listViewToolStripMenuItem.Click += new System.EventHandler(this.listViewToolStripMenuItem_Click);
			// 
			// maskedTextBoxToolStripMenuItem
			// 
			this.maskedTextBoxToolStripMenuItem.Name = "maskedTextBoxToolStripMenuItem";
			this.maskedTextBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.maskedTextBoxToolStripMenuItem.Text = "Masked Text Box";
			this.maskedTextBoxToolStripMenuItem.Click += new System.EventHandler(this.maskedTextBoxToolStripMenuItem_Click);
			// 
			// monthCalendarToolStripMenuItem
			// 
			this.monthCalendarToolStripMenuItem.Name = "monthCalendarToolStripMenuItem";
			this.monthCalendarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.monthCalendarToolStripMenuItem.Text = "Month Calendar";
			this.monthCalendarToolStripMenuItem.Click += new System.EventHandler(this.monthCalendarToolStripMenuItem_Click);
			// 
			// numericUpDownToolStripMenuItem
			// 
			this.numericUpDownToolStripMenuItem.Name = "numericUpDownToolStripMenuItem";
			this.numericUpDownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.numericUpDownToolStripMenuItem.Text = "Numeric Up Down";
			this.numericUpDownToolStripMenuItem.Click += new System.EventHandler(this.numericUpDownToolStripMenuItem_Click);
			// 
			// pictureBoxToolStripMenuItem
			// 
			this.pictureBoxToolStripMenuItem.Name = "pictureBoxToolStripMenuItem";
			this.pictureBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.pictureBoxToolStripMenuItem.Text = "Picture Box";
			this.pictureBoxToolStripMenuItem.Click += new System.EventHandler(this.pictureBoxToolStripMenuItem_Click);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.MenuNotificacoes;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "WinForm";
			this.notifyIcon1.Visible = true;
			// 
			// MenuNotificacoes
			// 
			this.MenuNotificacoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Restaurar,
            this.tsmi_Mensagem,
            this.tsmi_Fechar});
			this.MenuNotificacoes.Name = "MenuNotificacoes";
			this.MenuNotificacoes.Size = new System.Drawing.Size(134, 70);
			this.MenuNotificacoes.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuNotificacoes_ItemClicked);
			// 
			// tsmi_Restaurar
			// 
			this.tsmi_Restaurar.Name = "tsmi_Restaurar";
			this.tsmi_Restaurar.Size = new System.Drawing.Size(133, 22);
			this.tsmi_Restaurar.Text = "Restaurar";
			// 
			// tsmi_Mensagem
			// 
			this.tsmi_Mensagem.Name = "tsmi_Mensagem";
			this.tsmi_Mensagem.Size = new System.Drawing.Size(133, 22);
			this.tsmi_Mensagem.Text = "Mensagem";
			// 
			// tsmi_Fechar
			// 
			this.tsmi_Fechar.Name = "tsmi_Fechar";
			this.tsmi_Fechar.Size = new System.Drawing.Size(133, 22);
			this.tsmi_Fechar.Text = "Fechar";
			// 
			// progressBarToolStripMenuItem
			// 
			this.progressBarToolStripMenuItem.Name = "progressBarToolStripMenuItem";
			this.progressBarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.progressBarToolStripMenuItem.Text = "Progress Bar";
			this.progressBarToolStripMenuItem.Click += new System.EventHandler(this.progressBarToolStripMenuItem_Click);
			// 
			// Form_Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 496);
			this.Controls.Add(this.btn_valNum);
			this.Controls.Add(this.btn_mostrar);
			this.Controls.Add(this.btn_limpar);
			this.Controls.Add(this.txb_listaVeiculos);
			this.Controls.Add(this.lbl_newText);
			this.Controls.Add(this.txb_veiculo);
			this.Controls.Add(this.lbl_texto);
			this.Controls.Add(this.btn_adicionar);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form_Principal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Estudo Windows Form";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.MenuNotificacoes.ResumeLayout(false);
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
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem checkedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dateTimePickerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem labelLinkLabelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listViewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem maskedTextBoxToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem monthCalendarToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip MenuNotificacoes;
		private System.Windows.Forms.ToolStripMenuItem tsmi_Restaurar;
		private System.Windows.Forms.ToolStripMenuItem tsmi_Mensagem;
		private System.Windows.Forms.ToolStripMenuItem tsmi_Fechar;
		private System.Windows.Forms.ToolStripMenuItem numericUpDownToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pictureBoxToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem progressBarToolStripMenuItem;
	}
}

