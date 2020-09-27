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
	public partial class Form_Veiculos : Form
	{
		Form_Principal fp;
		public Form_Veiculos(String v, Form_Principal f)
		{
			InitializeComponent();
			
			txb_listaVeiculos.Text = v;

			fp = f;
			f.num = 10;
		}

		private void Form_Veiculos_Load(object sender, EventArgs e)
		{

		}

		private void Form_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
		{
			fp.txb_listaVeiculos.Text = txb_listaVeiculos.Text;
		}
	}
}
