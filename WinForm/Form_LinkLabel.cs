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
			lkl_multiplosLinks.Links.Add(0, 6, "www.google.com.br"); // só define o link de cada area. Ainda falta criar o link para a pagina.
			lkl_multiplosLinks.Links.Add(9, 5, "www.linkedin.com	");
			lkl_multiplosLinks.Links.Add(17, 7, "www.youtube.com");

			lkl_multiplosLinks.Links[2].Enabled = false;
		}

		private void lkl_Canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://google.com/" + txb_texto.Text);


			LinkLabel lkl = (LinkLabel)sender;
			lkl.LinkVisited = true;
		}

		private void lkl_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("calc.exe");
		}

		private void lkl_multiplosLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
			e.Link.Visited = true;
		}
	}
}
