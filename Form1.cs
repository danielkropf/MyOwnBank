using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOwnBank
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void DoWhatWasAskedFor(double valor, NumericUpDown quantToChange, ComboBox action, Label quantTotal, Label valorTotal)
		{
			if (action.Text == "Adicionar")
			{
				string[] a = quantTotal.Text.Split(':');
				quantTotal.Text = a[0] + ": " + Convert.ToString(Convert.ToInt32(a[1]) + quantToChange.Value);
			} 
			else if (action.Text == "Diminuir")
			{
				string[] a = quantTotal.Text.Split(':');
				if (quantToChange.Value > Convert.ToInt32(a[1])) quantToChange.Value = Convert.ToInt32(a[1]);
				quantTotal.Text = a[0] + ": " + Convert.ToString(Convert.ToInt32(a[1]) - quantToChange.Value);
			} 
			else
			{
				MessageBox.Show("Tente mudar a ação a ser tomada, talvez isso ajude a resolver o problema. :D", "Algo de errado não está certo...");
			}

			string[] b = quantTotal.Text.Split(':');
			valorTotal.Text = "Valor: R$ " + (valor * Convert.ToDouble(b[1])).ToString("0.00");

		}

		private void Calculate5Cents(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(0.05f, quantToChange5Cents, action5Cents, quantTotal5Cents, valorTotal5Cents);
		}

		private void Calculate10Cents(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(0.10f, quantToChange10Cents, action10Cents, quantTotal10Cents, valorTotal10Cents);
		}

		private void Calculate25Cents(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(0.25f, quantToChange25Cents, action25Cents, quantTotal25Cents, valorTotal25Cents);
		}

		private void Calculate50Cents(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(0.50f, quantToChange50Cents, action50Cents, quantTotal50Cents, valorTotal50Cents);
		}

		private void Calculate1Real(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(1f, quantToChange1Real, action1Real, quantTotal1Real, valorTotal1Real);
		}

		private void Calculate2Reais(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(2f, quantToChange2Reais, action2Reais, quantTotal2Reais, valorTotal2Reais);
		}

		private void Calculate5Reais(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(5f, quantToChange5Reais, action5Reais, quantTotal5Reais, valorTotal5Reais);
		}

		private void Calculate10Reais(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(10f, quantToChange10Reais, action10Reais, quantTotal10Reais, valorTotal10Reais);
		}

		private void Calculate20Reais(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(20f, quantToChange20Reais, action20Reais, quantTotal20Reais, valorTotal20Reais);
		}

		private void Calculate50Reais(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(50f, quantToChange50Reais, action50Reais, quantTotal50Reais, valorTotal50Reais);
		}

		private void Calculate100Reais(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(100f, quantToChange100Reais, action100Reais, quantTotal100Reais, valorTotal100Reais);
		}
	}
}
