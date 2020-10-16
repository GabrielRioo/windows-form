using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinForm
{
	public partial class Form_ProgressBar : Form
	{
		public Form_ProgressBar()
		{
			InitializeComponent();
		}

		private void btn_valor_Click(object sender, EventArgs e)
		{

			if(int.Parse(txt_valor.Text) >= pb_progresso.Minimum & int.Parse(txt_valor.Text) >= pb_progresso.Maximum)
			{
				pb_progresso.Value = int.Parse(txt_valor.Text);

			}
		}

		private void btn_iniciar_Click(object sender, EventArgs e)
		{
			pb_progresso.Value = 0;

			for (int i = 0; i <= pb_progresso.Maximum; i++)
			{
				pb_progresso.Value = i;
				Thread.Sleep(200);
			}


		}

		private void btn_iniciarFor_Click(object sender, EventArgs e)
		{
			pb_progresso2.Value = 0;
			pb_progresso2.Maximum = int.Parse(txb_for.Text);
			for (int i = 0; i <= int.Parse(txb_for.Text); i++)
			{
				label1.Text = i.ToString();
				pb_progresso2.Value = i;
				//Thread.Sleep(200);
			}
		}
	}
}
