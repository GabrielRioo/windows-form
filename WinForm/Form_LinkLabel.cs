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
	public partial class Form_LinkLabel : Form
	{
		public Form_LinkLabel()
		{
			InitializeComponent();
			lkl_multiplosLinks.Links.Add(0, 6, "www.google.com.br");
			lkl_multiplosLinks.Links.Add(9, 5, "www.linkedin.com");
			lkl_multiplosLinks.Links.Add(17, 7, "www.youtube.com");
		}

		private void lkl_Canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://google.com/" + txb_texto.Text);
		}

		private void lkl_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("calc.exe");
		}
	}
}
