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
	public partial class Form_NumericUpDown : Form
	{
		public Form_NumericUpDown()
		{
			InitializeComponent();
		}

		private void btn_Atribuir_Click(object sender, EventArgs e)
		{
			if(Decimal.Parse(txb_Atribuir.Text) > nud_numero.Maximum)
			{
				MessageBox.Show("Não é aceitavel valor maior que " + nud_numero.Maximum);
			}
			else if (Decimal.Parse(txb_Atribuir.Text) < nud_numero.Minimum)
			{
				MessageBox.Show("Não é aceitavel valor menor que " + nud_numero.Minimum);
			}
			else 
				nud_numero.Value = Decimal.Parse(txb_Atribuir.Text);
		}
	}
}
