namespace WinForm
{
	partial class Form_MonthCalendar
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
			this.mcd_calendario = new System.Windows.Forms.MonthCalendar();
			this.btn_pegarData = new System.Windows.Forms.Button();
			this.txb_text1 = new System.Windows.Forms.TextBox();
			this.txb_text2 = new System.Windows.Forms.TextBox();
			this.txb_dataAtual = new System.Windows.Forms.TextBox();
			this.btn_dataAtual = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// mcd_calendario
			// 
			this.mcd_calendario.Location = new System.Drawing.Point(18, 18);
			this.mcd_calendario.MaxSelectionCount = 30;
			this.mcd_calendario.Name = "mcd_calendario";
			this.mcd_calendario.TabIndex = 0;
			this.mcd_calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcd_calendario_DateChanged);
			// 
			// btn_pegarData
			// 
			this.btn_pegarData.Location = new System.Drawing.Point(257, 111);
			this.btn_pegarData.Name = "btn_pegarData";
			this.btn_pegarData.Size = new System.Drawing.Size(177, 23);
			this.btn_pegarData.TabIndex = 1;
			this.btn_pegarData.Text = "Pegar Data";
			this.btn_pegarData.UseVisualStyleBackColor = true;
			this.btn_pegarData.Click += new System.EventHandler(this.btn_pegarData_Click);
			// 
			// txb_text1
			// 
			this.txb_text1.Location = new System.Drawing.Point(258, 48);
			this.txb_text1.Name = "txb_text1";
			this.txb_text1.Size = new System.Drawing.Size(176, 20);
			this.txb_text1.TabIndex = 2;
			// 
			// txb_text2
			// 
			this.txb_text2.Location = new System.Drawing.Point(258, 74);
			this.txb_text2.Name = "txb_text2";
			this.txb_text2.Size = new System.Drawing.Size(176, 20);
			this.txb_text2.TabIndex = 3;
			// 
			// txb_dataAtual
			// 
			this.txb_dataAtual.Location = new System.Drawing.Point(259, 183);
			this.txb_dataAtual.Name = "txb_dataAtual";
			this.txb_dataAtual.Size = new System.Drawing.Size(176, 20);
			this.txb_dataAtual.TabIndex = 5;
			// 
			// btn_dataAtual
			// 
			this.btn_dataAtual.Location = new System.Drawing.Point(258, 220);
			this.btn_dataAtual.Name = "btn_dataAtual";
			this.btn_dataAtual.Size = new System.Drawing.Size(177, 23);
			this.btn_dataAtual.TabIndex = 4;
			this.btn_dataAtual.Text = "Data Atual";
			this.btn_dataAtual.UseVisualStyleBackColor = true;
			this.btn_dataAtual.Click += new System.EventHandler(this.btn_dataAtual_Click);
			// 
			// Form_MonthCalendar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(523, 450);
			this.Controls.Add(this.txb_dataAtual);
			this.Controls.Add(this.btn_dataAtual);
			this.Controls.Add(this.txb_text2);
			this.Controls.Add(this.txb_text1);
			this.Controls.Add(this.btn_pegarData);
			this.Controls.Add(this.mcd_calendario);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form_MonthCalendar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form_MonthCalendar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MonthCalendar mcd_calendario;
		private System.Windows.Forms.Button btn_pegarData;
		private System.Windows.Forms.TextBox txb_text1;
		private System.Windows.Forms.TextBox txb_text2;
		private System.Windows.Forms.TextBox txb_dataAtual;
		private System.Windows.Forms.Button btn_dataAtual;
	}
}