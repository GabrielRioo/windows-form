namespace WinForm
{
	partial class Form_LinkLabel
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
			this.lkl_Canal = new System.Windows.Forms.LinkLabel();
			this.lkl_calculadora = new System.Windows.Forms.LinkLabel();
			this.lkl_multiplosLinks = new System.Windows.Forms.LinkLabel();
			this.lbl_texto = new System.Windows.Forms.Label();
			this.txb_texto = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lkl_Canal
			// 
			this.lkl_Canal.AutoSize = true;
			this.lkl_Canal.Location = new System.Drawing.Point(24, 102);
			this.lkl_Canal.Name = "lkl_Canal";
			this.lkl_Canal.Size = new System.Drawing.Size(34, 13);
			this.lkl_Canal.TabIndex = 0;
			this.lkl_Canal.TabStop = true;
			this.lkl_Canal.Text = "Canal";
			this.lkl_Canal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl_Canal_LinkClicked);
			// 
			// lkl_calculadora
			// 
			this.lkl_calculadora.AutoSize = true;
			this.lkl_calculadora.Location = new System.Drawing.Point(81, 102);
			this.lkl_calculadora.Name = "lkl_calculadora";
			this.lkl_calculadora.Size = new System.Drawing.Size(63, 13);
			this.lkl_calculadora.TabIndex = 1;
			this.lkl_calculadora.TabStop = true;
			this.lkl_calculadora.Text = "Calculadora";
			this.lkl_calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl_calculadora_LinkClicked);
			// 
			// lkl_multiplosLinks
			// 
			this.lkl_multiplosLinks.AutoSize = true;
			this.lkl_multiplosLinks.Location = new System.Drawing.Point(162, 102);
			this.lkl_multiplosLinks.Name = "lkl_multiplosLinks";
			this.lkl_multiplosLinks.Size = new System.Drawing.Size(126, 13);
			this.lkl_multiplosLinks.TabIndex = 2;
			this.lkl_multiplosLinks.TabStop = true;
			this.lkl_multiplosLinks.Text = "Google - Canal - Youtube";
			// 
			// lbl_texto
			// 
			this.lbl_texto.AutoSize = true;
			this.lbl_texto.Location = new System.Drawing.Point(23, 20);
			this.lbl_texto.Name = "lbl_texto";
			this.lbl_texto.Size = new System.Drawing.Size(85, 13);
			this.lbl_texto.TabIndex = 3;
			this.lbl_texto.Text = "Digite seu Nome";
			// 
			// txb_texto
			// 
			this.txb_texto.Location = new System.Drawing.Point(26, 45);
			this.txb_texto.Name = "txb_texto";
			this.txb_texto.Size = new System.Drawing.Size(262, 20);
			this.txb_texto.TabIndex = 4;
			// 
			// Form_LinkLabel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(530, 489);
			this.Controls.Add(this.txb_texto);
			this.Controls.Add(this.lbl_texto);
			this.Controls.Add(this.lkl_multiplosLinks);
			this.Controls.Add(this.lkl_calculadora);
			this.Controls.Add(this.lkl_Canal);
			this.Name = "Form_LinkLabel";
			this.Text = "Link Label";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel lkl_Canal;
		private System.Windows.Forms.LinkLabel lkl_calculadora;
		private System.Windows.Forms.LinkLabel lkl_multiplosLinks;
		private System.Windows.Forms.Label lbl_texto;
		private System.Windows.Forms.TextBox txb_texto;
	}
}