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
	public partial class Form_ListView : Form
	{
		public Form_ListView()
		{
			InitializeComponent();
		}

		private void limpar()
		{
			txb_id.Clear();
			txb_produto.Clear();
			txb_quantidade.Clear();
			txb_preco.Clear();

			txb_id.Focus();
		}

		private void obter()
		{
			if (lv_produtos.SelectedItems.Count > 0)
			{
				txb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
				txb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
				txb_quantidade.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
				txb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
			}

		}

		private void btn_adicionar_Click(object sender, EventArgs e)
		{

			if (txb_id.Text == "" || txb_preco.Text == "" || txb_produto.Text == "" || txb_quantidade.Text == "")
			{
				MessageBox.Show("Preencha todos os campos.");
				return;
			}

			string[] prod = new string[4];
			prod[0] = txb_id.Text;
			prod[1] = txb_produto.Text;
			prod[2] = txb_quantidade.Text;
			prod[3] = txb_preco.Text;

			ListViewItem list = new ListViewItem(prod);
			lv_produtos.Items.Add(list);

			limpar();
		}

		private void btn_remover_Click(object sender, EventArgs e)
		{
			lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]);
		}

		private void btn_obter_Click(object sender, EventArgs e)
		{
			obter();
		}

		private void lv_produtos_SelectedIndexChanged(object sender, EventArgs e)
		{
			obter();

		}
	}
}
