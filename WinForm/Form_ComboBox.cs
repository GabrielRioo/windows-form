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
	public partial class Form_ComboBox : Form
	{
		public Form_ComboBox()
		{
			InitializeComponent();
		}

		private void btn_mostrarSelecionado_Click(object sender, EventArgs e)
		{
			MessageBox.Show(cb_transporte.Text);
		}

		private void btn_limpar_Click(object sender, EventArgs e)
		{
			cb_transporte.Items.Clear();
		}

		private void btn_resetarElementos_Click(object sender, EventArgs e)
		{
			cb_transporte.Items.Add("Carro");
			cb_transporte.Items.Add("Aviao");
			cb_transporte.Items.Add("Navio");
			cb_transporte.Items.Add("Onibus");
			cb_transporte.Items.Add("Trem");

		}

		private void cb_transporte_SelectedIndexChanged(object sender, EventArgs e)
		{
			txb_transporte.Text = cb_transporte.Text;
		}

		private void btn_adicionar_Click(object sender, EventArgs e)
		{
			if (txb_transporte.Text != "")
			{
				if (cb_transporte.FindString(txb_transporte.Text) < 0)
				{
					cb_transporte.Items.Add(txb_transporte.Text);
					txb_transporte.Clear();
					txb_transporte.Focus();

					lbl_resultado.Text = "Item adicionado com sucesso";
				}
				else
				{
					lbl_resultado.Text = "Este item ja existe.";
				}

			}
		}
	}
}
