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
	public partial class Form_CheckedListBox : Form
	{
		public Form_CheckedListBox()
		{
			InitializeComponent();
		}

		private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
		{
			string txt = "";

			foreach (string item in clb_transportes.CheckedItems)
			{
				txt += item + ", ";

			}

			MessageBox.Show(txt);
		}

		private void btn_limparLista_Click(object sender, EventArgs e)
		{
			clb_transportes.Items.Clear();
		}

		private void btn_resetarLista_Click(object sender, EventArgs e)
		{
			clb_transportes.Items.Clear();

			List<string> transp = new List<string>();
			transp.Add("Carro");
			transp.Add("Aviao");
			transp.Add("Navio");
			transp.Add("Onibus");
			transp.Add("Trem");

			clb_transportes.Items.AddRange(transp.ToArray());

		}

		private void btn_adicionarTransporte_Click(object sender, EventArgs e)
		{
			if (tbx_NovoTransporte.Text != "")
			{
				clb_transportes.Items.Add(tbx_NovoTransporte.Text);
				tbx_NovoTransporte.Clear();
				tbx_NovoTransporte.Focus();
			}

		}
	}
}
