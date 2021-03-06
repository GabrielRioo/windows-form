﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinForm
{
	public partial class Form_RichTextBox : Form
	{
		StreamReader leitura = null;
		public Form_RichTextBox()
		{
			InitializeComponent();
		}

		private void Form_RichTextBox_Load(object sender, EventArgs e)
		{

		}

		private void Novo()
		{
			MessageBox.Show("Deseja Salvar o arquivo?");
			//saveFileDialog1.ShowDialog();
			rtxb_editor.Clear();
			rtxb_editor.Focus();
		}

		private void btn_novo_Click(object sender, EventArgs e)
		{
			Novo();
		}

		private void novoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Novo();
		}

		private void Salvar()
		{
			//saveFileDialog1.ShowDialog();
			try
			{
				if(this.saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
					StreamWriter escrever = new StreamWriter(arquivo);
					escrever.Flush();
					escrever.BaseStream.Seek(0, SeekOrigin.Begin);
					escrever.Write(this.rtxb_editor.Text);
					escrever.Flush();
					escrever.Close();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Erro a gravação: \n" + ex.Message, "Erro ao gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Salvar();
		}

		private void btn_Salvar_Click(object sender, EventArgs e)
		{
			Salvar();
		}

		private void Abrir()
		{
			this.openFileDialog1.Multiselect = false;
			this.openFileDialog1.Title = "Abrir Arquivo";
			openFileDialog1.InitialDirectory = @"C:\Gabrieltmp\GitHub\windows-form\WinForm\";
			openFileDialog1.Filter = "(*.txt)|*.txt";

			if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
					StreamReader leitor = new StreamReader(arquivo);
					leitor.BaseStream.Seek(0, SeekOrigin.Begin);
					this.rtxb_editor.Text = "";
					string linha = leitor.ReadLine();

					while(linha != null)
					{
						this.rtxb_editor.Text += linha + "\n";
						linha = leitor.ReadLine();
					}
					leitor.Close();
				}
				catch(Exception ex)
				{
					MessageBox.Show("Erro de leitura: \n" + ex.Message, "Erro ao ler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}


		}

		private void btn_abrir_Click(object sender, EventArgs e)
		{
			Abrir();
		}

		private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Abrir();
		}
	}
}
