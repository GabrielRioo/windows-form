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
	public partial class Form_RadioButton : Form
	{
		public Form_RadioButton()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string txt;

			txt = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;

			textBox1.Text = txt;
			MessageBox.Show(txt);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string txt = "";

			foreach(RadioButton rb in groupBox1.Controls)
			{
				if (rb.Checked)
				{
					txt = rb.Text;
				}
			}
			MessageBox.Show(txt);

		}
	}
}
