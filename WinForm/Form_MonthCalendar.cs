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
	public partial class Form_MonthCalendar : Form
	{
		public Form_MonthCalendar()
		{
			InitializeComponent();
		}

		private void btn_pegarData_Click(object sender, EventArgs e)
		{
			txb_text1.Text = mcd_calendario.SelectionStart.ToShortDateString();
			txb_text2.Text = mcd_calendario.SelectionEnd.ToShortDateString();
		}

		private void btn_dataAtual_Click(object sender, EventArgs e)
		{
			txb_dataAtual.Text = mcd_calendario.TodayDate.ToShortDateString();
		}

		private void mcd_calendario_DateChanged(object sender, DateRangeEventArgs e)
		{
			txb_text1.Text = mcd_calendario.SelectionStart.ToShortDateString();
			txb_text2.Text = mcd_calendario.SelectionEnd.ToShortDateString();
			txb_dataAtual.Text = mcd_calendario.TodayDate.ToShortDateString();
		}
	}
}
