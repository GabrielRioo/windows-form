namespace WinForm
{
	partial class Form_NumericUpDown
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
			this.nud_numero = new System.Windows.Forms.NumericUpDown();
			this.txb_Atribuir = new System.Windows.Forms.TextBox();
			this.btn_Atribuir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nud_numero)).BeginInit();
			this.SuspendLayout();
			// 
			// nud_numero
			// 
			this.nud_numero.DecimalPlaces = 2;
			this.nud_numero.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nud_numero.Location = new System.Drawing.Point(13, 13);
			this.nud_numero.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.nud_numero.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nud_numero.Name = "nud_numero";
			this.nud_numero.Size = new System.Drawing.Size(120, 20);
			this.nud_numero.TabIndex = 0;
			this.nud_numero.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// txb_Atribuir
			// 
			this.txb_Atribuir.Location = new System.Drawing.Point(249, 15);
			this.txb_Atribuir.Name = "txb_Atribuir";
			this.txb_Atribuir.Size = new System.Drawing.Size(100, 20);
			this.txb_Atribuir.TabIndex = 1;
			// 
			// btn_Atribuir
			// 
			this.btn_Atribuir.Location = new System.Drawing.Point(355, 13);
			this.btn_Atribuir.Name = "btn_Atribuir";
			this.btn_Atribuir.Size = new System.Drawing.Size(75, 23);
			this.btn_Atribuir.TabIndex = 2;
			this.btn_Atribuir.Text = "Atribuir";
			this.btn_Atribuir.UseVisualStyleBackColor = true;
			this.btn_Atribuir.Click += new System.EventHandler(this.btn_Atribuir_Click);
			// 
			// Form_NumericUpDown
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(509, 478);
			this.Controls.Add(this.btn_Atribuir);
			this.Controls.Add(this.txb_Atribuir);
			this.Controls.Add(this.nud_numero);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form_NumericUpDown";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form_NumericUpDown";
			((System.ComponentModel.ISupportInitialize)(this.nud_numero)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nud_numero;
		private System.Windows.Forms.TextBox txb_Atribuir;
		private System.Windows.Forms.Button btn_Atribuir;
	}
}