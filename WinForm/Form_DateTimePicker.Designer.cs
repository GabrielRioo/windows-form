namespace WinForm
{
	partial class Form_DateTimePicker
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
			this.dtp_data = new System.Windows.Forms.DateTimePicker();
			this.txb_data = new System.Windows.Forms.TextBox();
			this.txb_dia = new System.Windows.Forms.TextBox();
			this.txb_mes = new System.Windows.Forms.TextBox();
			this.txb_ano = new System.Windows.Forms.TextBox();
			this.btn_obterData = new System.Windows.Forms.Button();
			this.btn_setarData = new System.Windows.Forms.Button();
			this.btn_hoje = new System.Windows.Forms.Button();
			this.txb_hoje = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// dtp_data
			// 
			this.dtp_data.Location = new System.Drawing.Point(12, 13);
			this.dtp_data.Name = "dtp_data";
			this.dtp_data.Size = new System.Drawing.Size(347, 20);
			this.dtp_data.TabIndex = 0;
			// 
			// txb_data
			// 
			this.txb_data.Location = new System.Drawing.Point(12, 39);
			this.txb_data.Name = "txb_data";
			this.txb_data.Size = new System.Drawing.Size(347, 20);
			this.txb_data.TabIndex = 1;
			// 
			// txb_dia
			// 
			this.txb_dia.Location = new System.Drawing.Point(12, 65);
			this.txb_dia.Name = "txb_dia";
			this.txb_dia.Size = new System.Drawing.Size(100, 20);
			this.txb_dia.TabIndex = 2;
			// 
			// txb_mes
			// 
			this.txb_mes.Location = new System.Drawing.Point(136, 65);
			this.txb_mes.Name = "txb_mes";
			this.txb_mes.Size = new System.Drawing.Size(100, 20);
			this.txb_mes.TabIndex = 3;
			// 
			// txb_ano
			// 
			this.txb_ano.Location = new System.Drawing.Point(259, 65);
			this.txb_ano.Name = "txb_ano";
			this.txb_ano.Size = new System.Drawing.Size(100, 20);
			this.txb_ano.TabIndex = 4;
			// 
			// btn_obterData
			// 
			this.btn_obterData.Location = new System.Drawing.Point(381, 10);
			this.btn_obterData.Name = "btn_obterData";
			this.btn_obterData.Size = new System.Drawing.Size(130, 49);
			this.btn_obterData.TabIndex = 5;
			this.btn_obterData.Text = "Obter Data";
			this.btn_obterData.UseVisualStyleBackColor = true;
			this.btn_obterData.Click += new System.EventHandler(this.btn_obterData_Click);
			// 
			// btn_setarData
			// 
			this.btn_setarData.Location = new System.Drawing.Point(381, 65);
			this.btn_setarData.Name = "btn_setarData";
			this.btn_setarData.Size = new System.Drawing.Size(130, 23);
			this.btn_setarData.TabIndex = 9;
			this.btn_setarData.Text = "Setar Data";
			this.btn_setarData.UseVisualStyleBackColor = true;
			this.btn_setarData.Click += new System.EventHandler(this.btn_setarData_Click);
			// 
			// btn_hoje
			// 
			this.btn_hoje.Location = new System.Drawing.Point(381, 120);
			this.btn_hoje.Name = "btn_hoje";
			this.btn_hoje.Size = new System.Drawing.Size(130, 23);
			this.btn_hoje.TabIndex = 10;
			this.btn_hoje.Text = "Data Atual";
			this.btn_hoje.UseVisualStyleBackColor = true;
			this.btn_hoje.Click += new System.EventHandler(this.btn_hoje_Click);
			// 
			// txb_hoje
			// 
			this.txb_hoje.Location = new System.Drawing.Point(12, 123);
			this.txb_hoje.Name = "txb_hoje";
			this.txb_hoje.Size = new System.Drawing.Size(347, 20);
			this.txb_hoje.TabIndex = 11;
			// 
			// Form_DateTimePicker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(523, 483);
			this.Controls.Add(this.txb_hoje);
			this.Controls.Add(this.btn_hoje);
			this.Controls.Add(this.btn_setarData);
			this.Controls.Add(this.btn_obterData);
			this.Controls.Add(this.txb_ano);
			this.Controls.Add(this.txb_mes);
			this.Controls.Add(this.txb_dia);
			this.Controls.Add(this.txb_data);
			this.Controls.Add(this.dtp_data);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form_DateTimePicker";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form_DateTimePicker";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtp_data;
		private System.Windows.Forms.TextBox txb_data;
		private System.Windows.Forms.TextBox txb_dia;
		private System.Windows.Forms.TextBox txb_mes;
		private System.Windows.Forms.TextBox txb_ano;
		private System.Windows.Forms.Button btn_obterData;
		private System.Windows.Forms.Button btn_setarData;
		private System.Windows.Forms.Button btn_hoje;
		private System.Windows.Forms.TextBox txb_hoje;
	}
}