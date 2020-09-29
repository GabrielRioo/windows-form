namespace WinForm
{
	partial class Form_ListView
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
			System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "180",
            "69,99"}, -1);
			System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "80",
            "134,99"}, -1);
			System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Monitor",
            "38",
            "938,50"}, -1);
			this.lv_produtos = new System.Windows.Forms.ListView();
			this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txb_id = new System.Windows.Forms.TextBox();
			this.txb_produto = new System.Windows.Forms.TextBox();
			this.txb_quantidade = new System.Windows.Forms.TextBox();
			this.txb_preco = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_adicionar = new System.Windows.Forms.Button();
			this.btn_remover = new System.Windows.Forms.Button();
			this.btn_obter = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lv_produtos
			// 
			this.lv_produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_produto,
            this.col_quantidade,
            this.col_preco});
			this.lv_produtos.FullRowSelect = true;
			this.lv_produtos.HideSelection = false;
			this.lv_produtos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9});
			this.lv_produtos.Location = new System.Drawing.Point(12, 12);
			this.lv_produtos.MultiSelect = false;
			this.lv_produtos.Name = "lv_produtos";
			this.lv_produtos.Size = new System.Drawing.Size(498, 143);
			this.lv_produtos.TabIndex = 0;
			this.lv_produtos.UseCompatibleStateImageBehavior = false;
			this.lv_produtos.View = System.Windows.Forms.View.Details;
			// 
			// col_id
			// 
			this.col_id.Text = " ID";
			this.col_id.Width = 40;
			// 
			// col_produto
			// 
			this.col_produto.Text = "Produto";
			this.col_produto.Width = 250;
			// 
			// col_quantidade
			// 
			this.col_quantidade.Text = "Quantidade";
			this.col_quantidade.Width = 80;
			// 
			// col_preco
			// 
			this.col_preco.Text = "Preço";
			this.col_preco.Width = 120;
			// 
			// txb_id
			// 
			this.txb_id.Location = new System.Drawing.Point(12, 250);
			this.txb_id.Name = "txb_id";
			this.txb_id.Size = new System.Drawing.Size(61, 20);
			this.txb_id.TabIndex = 1;
			// 
			// txb_produto
			// 
			this.txb_produto.Location = new System.Drawing.Point(79, 250);
			this.txb_produto.Name = "txb_produto";
			this.txb_produto.Size = new System.Drawing.Size(224, 20);
			this.txb_produto.TabIndex = 2;
			// 
			// txb_quantidade
			// 
			this.txb_quantidade.Location = new System.Drawing.Point(309, 250);
			this.txb_quantidade.Name = "txb_quantidade";
			this.txb_quantidade.Size = new System.Drawing.Size(101, 20);
			this.txb_quantidade.TabIndex = 3;
			// 
			// txb_preco
			// 
			this.txb_preco.Location = new System.Drawing.Point(416, 250);
			this.txb_preco.Name = "txb_preco";
			this.txb_preco.Size = new System.Drawing.Size(94, 20);
			this.txb_preco.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 234);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(76, 234);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Produto";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(306, 231);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Quantidade";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(413, 231);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Preço";
			// 
			// btn_adicionar
			// 
			this.btn_adicionar.Location = new System.Drawing.Point(15, 294);
			this.btn_adicionar.Name = "btn_adicionar";
			this.btn_adicionar.Size = new System.Drawing.Size(495, 23);
			this.btn_adicionar.TabIndex = 9;
			this.btn_adicionar.Text = "ADICIONAR";
			this.btn_adicionar.UseVisualStyleBackColor = true;
			this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
			// 
			// btn_remover
			// 
			this.btn_remover.Location = new System.Drawing.Point(12, 323);
			this.btn_remover.Name = "btn_remover";
			this.btn_remover.Size = new System.Drawing.Size(495, 23);
			this.btn_remover.TabIndex = 10;
			this.btn_remover.Text = "REMOVER";
			this.btn_remover.UseVisualStyleBackColor = true;
			this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
			// 
			// btn_obter
			// 
			this.btn_obter.Location = new System.Drawing.Point(12, 352);
			this.btn_obter.Name = "btn_obter";
			this.btn_obter.Size = new System.Drawing.Size(495, 23);
			this.btn_obter.TabIndex = 11;
			this.btn_obter.Text = "OBTER";
			this.btn_obter.UseVisualStyleBackColor = true;
			this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
			// 
			// Form_ListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(522, 450);
			this.Controls.Add(this.btn_obter);
			this.Controls.Add(this.btn_remover);
			this.Controls.Add(this.btn_adicionar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txb_preco);
			this.Controls.Add(this.txb_quantidade);
			this.Controls.Add(this.txb_produto);
			this.Controls.Add(this.txb_id);
			this.Controls.Add(this.lv_produtos);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form_ListView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form_ListView";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lv_produtos;
		private System.Windows.Forms.ColumnHeader col_id;
		private System.Windows.Forms.ColumnHeader col_produto;
		private System.Windows.Forms.ColumnHeader col_quantidade;
		private System.Windows.Forms.ColumnHeader col_preco;
		private System.Windows.Forms.TextBox txb_id;
		private System.Windows.Forms.TextBox txb_produto;
		private System.Windows.Forms.TextBox txb_quantidade;
		private System.Windows.Forms.TextBox txb_preco;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btn_adicionar;
		private System.Windows.Forms.Button btn_remover;
		private System.Windows.Forms.Button btn_obter;
	}
}