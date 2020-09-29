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
	public partial class Form_ListBox : Form
	{
	List<string> carros = new List<string>();
		public Form_ListBox()
		{
			InitializeComponent();
			carros.Add("HVR");
			carros.Add("Golf");
			carros.Add("Focus");

			lbx_carro.DataSource = carros;  
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			if(txb_carro.Text == "")
			{
				MessageBox.Show("Nenhum valor digitado");
				txb_carro.Focus();
				return;	
			}
			else
			{
				carros.Add(txb_carro.Text);
				txb_carro.Clear();
				txb_carro.Focus();
				 
				lbx_carro.DataSource = null;
				lbx_carro.DataSource = carros;

			}
		}

		private void btn_remover_Click(object sender, EventArgs e)
		{
			carros.RemoveAt(lbx_carro.SelectedIndex);
			lbx_carro.DataSource = null;
			lbx_carro.DataSource = carros;


		}

		private void btn_obter_Click(object sender, EventArgs e)
		{
			txb_carro.Text = carros[lbx_carro.SelectedIndex];
		}

		private void btn_limpar_Click(object sender, EventArgs e)
		{
			carros.Clear();

			lbx_carro.DataSource = null;
			lbx_carro.DataSource = carros;
		}
	}
}
