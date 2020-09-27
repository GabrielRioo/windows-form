using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
	public partial class Form_ChecBox : Form
	{
		List<CheckBox> transp = new List<CheckBox>();
		public Form_ChecBox()
		{
			InitializeComponent();

			transp.Add(cb_carro);
			transp.Add(cb_aviao);
			transp.Add(cb_navio);
			transp.Add(cb_onibus);
		}

		private void btn_transportesMarcados_Click(object sender, EventArgs e)
		{
			
			string txt = "";
			foreach (CheckBox item in transp)
			{
				if(item.Checked)
				{
					txt += item.Text + ", ";
				}
			}

			MessageBox.Show(txt);

		}

		private void cb_patinete_CheckedChanged(object sender, EventArgs e)
		{
			if(cb_patinete.Checked)
			{
				MessageBox.Show("Patinete Marcada");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form_FilhoCheckBox form_FilhoCheckBox = new Form_FilhoCheckBox();
			form_FilhoCheckBox.ShowDialog();
		}
	}
}
