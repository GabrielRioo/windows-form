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
	public partial class Form_MaskedTextBox : Form
	{
		public Form_MaskedTextBox()
		{
			InitializeComponent();
		}

		private void btn_enviar_Click(object sender, EventArgs e)
		{

			if(chk_texto.Checked)
			{
				mtb_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
			}

			else
			{
				mtb_cpf.TextMaskFormat = MaskFormat.IncludeLiterals;
			}

			String msg = mtb_cpf.Text;
			MessageBox.Show(msg);
		}

		private void chk_verSenha_CheckedChanged(object sender, EventArgs e)
		{
			if (chk_verSenha.Checked)
			{
				mtb_senha.PasswordChar = default;

			}
			else
			{
				mtb_senha.PasswordChar = '*';
			}
		}

		private void Form_MaskedTextBox_Load(object sender, EventArgs e)
		{

		}
	}
}
