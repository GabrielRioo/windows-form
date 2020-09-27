﻿using System;
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
	public partial class Form_Principal : Form
	{
		public Form_Principal()
		{
			InitializeComponent();

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		//private void btn_enviar_Click(object sender, EventArgs e)
		//{
		//	lbl_newText.Text = txb_veiculo.Text;
		//}

		private void btn_adicionar_Click(object sender, EventArgs e)
		{
			if (txb_veiculo.Text == "")
			{
				MessageBox.Show("Digite um veículo!");
				txb_veiculo.Focus();
				return;
			}

			//txb_listaVeiculos.Text = txb_listaVeiculos.Text  + txb_veiculo.Text;
			txb_listaVeiculos.Text += txb_veiculo.Text + ", ";
			txb_veiculo.Clear();
			txb_veiculo.Focus();
		}

		private void btn_limpar_Click(object sender, EventArgs e)
		{
			txb_listaVeiculos.Clear();
			txb_veiculo.Clear();
			txb_veiculo.Focus();
		}
	}
}