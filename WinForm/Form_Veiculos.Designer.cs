namespace WinForm
{
	partial class Form_Veiculos
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
			this.txb_listaVeiculos = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txb_listaVeiculos
			// 
			this.txb_listaVeiculos.Location = new System.Drawing.Point(12, 12);
			this.txb_listaVeiculos.Multiline = true;
			this.txb_listaVeiculos.Name = "txb_listaVeiculos";
			this.txb_listaVeiculos.Size = new System.Drawing.Size(421, 558);
			this.txb_listaVeiculos.TabIndex = 0;
			// 
			// Form_Veiculos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 582);
			this.Controls.Add(this.txb_listaVeiculos);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form_Veiculos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lista de Veiculos";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Veiculos_FormClosed);
			this.Load += new System.EventHandler(this.Form_Veiculos_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txb_listaVeiculos;
	}
}