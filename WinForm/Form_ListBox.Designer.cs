namespace WinForm
{
	partial class Form_ListBox
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
			this.lbx_carro = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txb_carro = new System.Windows.Forms.TextBox();
			this.btn_add = new System.Windows.Forms.Button();
			this.btn_remover = new System.Windows.Forms.Button();
			this.btn_obter = new System.Windows.Forms.Button();
			this.btn_limpar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbx_carro
			// 
			this.lbx_carro.FormattingEnabled = true;
			this.lbx_carro.Location = new System.Drawing.Point(12, 12);
			this.lbx_carro.Name = "lbx_carro";
			this.lbx_carro.Size = new System.Drawing.Size(120, 173);
			this.lbx_carro.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(138, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Carro";
			// 
			// txb_carro
			// 
			this.txb_carro.Location = new System.Drawing.Point(141, 29);
			this.txb_carro.Name = "txb_carro";
			this.txb_carro.Size = new System.Drawing.Size(100, 20);
			this.txb_carro.TabIndex = 2;
			// 
			// btn_add
			// 
			this.btn_add.BackColor = System.Drawing.Color.Green;
			this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btn_add.Location = new System.Drawing.Point(141, 65);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(100, 23);
			this.btn_add.TabIndex = 3;
			this.btn_add.Text = "button1";
			this.btn_add.UseVisualStyleBackColor = false;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// btn_remover
			// 
			this.btn_remover.BackColor = System.Drawing.Color.Firebrick;
			this.btn_remover.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btn_remover.Location = new System.Drawing.Point(141, 94);
			this.btn_remover.Name = "btn_remover";
			this.btn_remover.Size = new System.Drawing.Size(100, 23);
			this.btn_remover.TabIndex = 4;
			this.btn_remover.Text = "Remover";
			this.btn_remover.UseVisualStyleBackColor = false;
			this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
			// 
			// btn_obter
			// 
			this.btn_obter.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn_obter.Location = new System.Drawing.Point(141, 123);
			this.btn_obter.Name = "btn_obter";
			this.btn_obter.Size = new System.Drawing.Size(100, 23);
			this.btn_obter.TabIndex = 5;
			this.btn_obter.Text = "Obter";
			this.btn_obter.UseVisualStyleBackColor = false;
			this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
			// 
			// btn_limpar
			// 
			this.btn_limpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn_limpar.Location = new System.Drawing.Point(141, 162);
			this.btn_limpar.Name = "btn_limpar";
			this.btn_limpar.Size = new System.Drawing.Size(100, 23);
			this.btn_limpar.TabIndex = 6;
			this.btn_limpar.Text = "Limpar";
			this.btn_limpar.UseVisualStyleBackColor = false;
			this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
			// 
			// Form_ListBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 484);
			this.Controls.Add(this.btn_limpar);
			this.Controls.Add(this.btn_obter);
			this.Controls.Add(this.btn_remover);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.txb_carro);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbx_carro);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form_ListBox";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form_ListBox";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbx_carro;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txb_carro;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Button btn_remover;
		private System.Windows.Forms.Button btn_obter;
		private System.Windows.Forms.Button btn_limpar;
	}
}