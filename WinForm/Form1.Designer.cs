namespace WinForm
{
	partial class Form1
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
			this.btn_enviar = new System.Windows.Forms.Button();
			this.lbl_texto = new System.Windows.Forms.Label();
			this.txb_input = new System.Windows.Forms.TextBox();
			this.lbl_newText = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_enviar
			// 
			this.btn_enviar.BackColor = System.Drawing.Color.DarkRed;
			this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_enviar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btn_enviar.Location = new System.Drawing.Point(551, 298);
			this.btn_enviar.Name = "btn_enviar";
			this.btn_enviar.Size = new System.Drawing.Size(244, 42);
			this.btn_enviar.TabIndex = 0;
			this.btn_enviar.Text = "ENVIAR";
			this.btn_enviar.UseVisualStyleBackColor = false;
			this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
			// 
			// lbl_texto
			// 
			this.lbl_texto.AutoSize = true;
			this.lbl_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_texto.Location = new System.Drawing.Point(545, 167);
			this.lbl_texto.Name = "lbl_texto";
			this.lbl_texto.Size = new System.Drawing.Size(250, 31);
			this.lbl_texto.TabIndex = 1;
			this.lbl_texto.Text = "Digite alguma coisa";
			// 
			// txb_input
			// 
			this.txb_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_input.Location = new System.Drawing.Point(551, 224);
			this.txb_input.Multiline = true;
			this.txb_input.Name = "txb_input";
			this.txb_input.Size = new System.Drawing.Size(244, 35);
			this.txb_input.TabIndex = 2;
			// 
			// lbl_newText
			// 
			this.lbl_newText.AutoSize = true;
			this.lbl_newText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_newText.Location = new System.Drawing.Point(546, 370);
			this.lbl_newText.Name = "lbl_newText";
			this.lbl_newText.Size = new System.Drawing.Size(0, 25);
			this.lbl_newText.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1333, 568);
			this.Controls.Add(this.lbl_newText);
			this.Controls.Add(this.txb_input);
			this.Controls.Add(this.lbl_texto);
			this.Controls.Add(this.btn_enviar);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_enviar;
		private System.Windows.Forms.Label lbl_texto;
		private System.Windows.Forms.TextBox txb_input;
		private System.Windows.Forms.Label lbl_newText;
	}
}

