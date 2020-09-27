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
		public Form_Veiculos(String v)
		{
			InitializeComponent();
			txb_listaVeiculos.Text = v;
		}

		private void Form_Veiculos_Load(object sender, EventArgs e)
		{

		}
	}
}
