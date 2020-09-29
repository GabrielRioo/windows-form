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
	public partial class Form_Principal : Form
	{
		public int num;
		public Form_Principal()
		{
			InitializeComponent();
			num = 0;

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		//private void btn_enviar_Click(object sender, EventArgs e)
		//{
		//	lbl_newText.Text = txb_veiculo.Text;
		//}

		private void btn_adicionar_Click(object sender, EventArgs e)
		{
			if (txb_veiculo.Text == "")
			{
				MessageBox.Show("Digite um veículo!");
				txb_veiculo.Focus();
				return;
			}

			//txb_listaVeiculos.Text = txb_listaVeiculos.Text  + txb_veiculo.Text;
			txb_listaVeiculos.Text += txb_veiculo.Text + ", ";
			txb_veiculo.Clear();
			txb_veiculo.Focus();
		}

		private void btn_limpar_Click(object sender, EventArgs e)
		{
			txb_listaVeiculos.Clear();
			txb_veiculo.Clear();
			txb_veiculo.Focus();
		}

		private void btn_mostrar_Click(object sender, EventArgs e)
		{
			Form_Veiculos form_Veiculos = new Form_Veiculos(txb_listaVeiculos.Text, this);
			form_Veiculos.ShowDialog();
		}

		private void btn_valNum_Click(object sender, EventArgs e)
		{
			MessageBox.Show(num.ToString());
		}

		private void lbl_texto_Click(object sender, EventArgs e)
		{

		}

		private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_ChecBox form_ChecBox = new Form_ChecBox();
			form_ChecBox.ShowDialog();
		}

		private void checkedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_CheckedListBox form_checkedListBox = new Form_CheckedListBox();
			form_checkedListBox.ShowDialog();
		}

		private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_ComboBox form_ComboBox = new Form_ComboBox();
			form_ComboBox.ShowDialog();
		}

		private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_DateTimePicker form_DateTimePicker = new Form_DateTimePicker();
			form_DateTimePicker.ShowDialog();
		}

		private void labelLinkLabelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_LinkLabel form_LinkLabel = new Form_LinkLabel();
			form_LinkLabel.ShowDialog();
		}

		private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_ListBox form_ListBox = new Form_ListBox();
			form_ListBox.ShowDialog();
		}
	}
}
