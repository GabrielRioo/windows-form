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
	public partial class Form_PictureBox : Form
	{
		public Form_PictureBox()
		{
			InitializeComponent();
		}

		private void Form_PictureBox_Load(object sender, EventArgs e)
		{
			lbl_texto1.Text = Properties.Resources.NomeCliente;
			lbl_texto2.Text = Properties.Resources.EnderecoCliente;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			pictureBox1.Image = Properties.Resources.rabisco;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			pictureBox1.Image = Properties.Resources._2436733;
		}
	}
}
