using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyOwnBank
{
	public partial class Form1 : Form
	{
		public Label[] quantTotalAll  = new Label[11];

		public Form1()
		{
			InitializeComponent();
			quantTotalAll = new Label[] { quantTotal5Cents, quantTotal10Cents, quantTotal25Cents, quantTotal50Cents, quantTotal1Real, quantTotal2Reais, quantTotal5Reais, quantTotal10Reais, quantTotal20Reais, quantTotal50Reais, quantTotal100Reais };
			InteractTxt(true, "C:/Users/Daniel/Desktop/teste.txt");

			DoWhatWasAskedFor(0.05f, valorTotal5Cents, quantTotal5Cents);
			DoWhatWasAskedFor(0.10f, valorTotal10Cents, quantTotal10Cents);
			DoWhatWasAskedFor(0.25f, valorTotal25Cents, quantTotal25Cents);
			DoWhatWasAskedFor(0.50f, valorTotal50Cents, quantTotal50Cents);
			DoWhatWasAskedFor(1f, valorTotal1Real, quantTotal1Real);
			DoWhatWasAskedFor(2f, valorTotal2Reais, quantTotal2Reais);
			DoWhatWasAskedFor(5f, valorTotal5Reais, quantTotal5Reais);
			DoWhatWasAskedFor(10f, valorTotal10Reais, quantTotal10Reais);
			DoWhatWasAskedFor(20f, valorTotal20Reais, quantTotal20Reais);
			DoWhatWasAskedFor(50f, valorTotal50Reais, quantTotal50Reais);
			DoWhatWasAskedFor(100f, valorTotal100Reais, quantTotal100Reais);
		}

		int c = 0;

		#region Functions

		private void DoWhatWasAskedFor(NumericUpDown quantToChange, ComboBox action, Label quantTotal)
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
				MessageBox.Show("Tente mudar a ação a ser tomada, talvez isso ajude a resolver o problema. :D", "Algo de errado não está certo...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void DoWhatWasAskedFor(double valor, Label valorTotal, Label quantTotal)
		{
			string[] b = quantTotal.Text.Split(':');
			valorTotal.Text = "Valor: R$ " + (valor * Convert.ToDouble(b[1])).ToString("0.00");
		}
		
		private void InteractTxt(bool ler, string localArquivo)
		{
			if(ler)
			{
				System.IO.StreamReader fileSR = new System.IO.StreamReader(localArquivo, false);
				string line;

				int i = 0;
				while (( line = fileSR.ReadLine()) != null)
				{
					quantTotalAll[i].Text = "Quantidade: " + line;

					i++;
				}
				fileSR.Close();
			}
			else if(!ler)
			{
				if (c > -1)
				{
					if (System.IO.File.Exists(localArquivo))
					{
						System.IO.File.Delete(localArquivo);
					}
					System.IO.StreamWriter file = new System.IO.StreamWriter(localArquivo, false);
					for (int i = 0; i < 11; i++)
					{
						string[] d = quantTotalAll[i].Text.Split(':');
						file.WriteLine(d[1]);
					}
					file.Close();
				}
				if(c == 0) c++;
			}
		}

		#endregion

		#region ButtonsClickFunction
		private void Calculate5Cents(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(quantToChange5Cents, action5Cents, quantTotal5Cents);
			DoWhatWasAskedFor(0.05f, valorTotal5Cents, quantTotal5Cents);
			InteractTxt(false, "C:/Users/Daniel/Desktop/teste.txt");
			
		}

		private void Calculate10Cents(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(quantToChange10Cents, action10Cents, quantTotal10Cents);
			DoWhatWasAskedFor(0.10f, valorTotal10Cents, quantTotal10Cents);
			InteractTxt(false, "C:/Users/Daniel/Desktop/teste.txt");
		}

		private void Calculate25Cents(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(quantToChange25Cents, action25Cents, quantTotal25Cents);
			DoWhatWasAskedFor(0.25f, valorTotal25Cents, quantTotal25Cents);
			InteractTxt(false, "C:/Users/Daniel/Desktop/teste.txt");
		}

		private void Calculate50Cents(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(quantToChange50Cents, action50Cents, quantTotal50Cents);
			DoWhatWasAskedFor(0.50f, valorTotal50Cents, quantTotal50Cents);
			InteractTxt(false, "C:/Users/Daniel/Desktop/teste.txt");
		}

		private void Calculate1Real(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(quantToChange1Real, action1Real, quantTotal1Real);
			DoWhatWasAskedFor(1f, valorTotal1Real, quantTotal1Real);
			InteractTxt(false, "C:/Users/Daniel/Desktop/teste.txt");
		}

		private void Calculate2Reais(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(quantToChange2Reais, action2Reais, quantTotal2Reais);
			DoWhatWasAskedFor(2f, valorTotal2Reais, quantTotal2Reais);
			InteractTxt(false, "C:/Users/Daniel/Desktop/teste.txt");
		}

		private void Calculate5Reais(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(quantToChange5Reais, action5Reais, quantTotal5Reais);
			DoWhatWasAskedFor(5f, valorTotal5Reais, quantTotal5Reais);
			InteractTxt(false, "C:/Users/Daniel/Desktop/teste.txt");
		}

		private void Calculate10Reais(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(quantToChange10Reais, action10Reais, quantTotal10Reais);
			DoWhatWasAskedFor(10f, valorTotal10Reais, quantTotal10Reais);
			InteractTxt(false, "C:/Users/Daniel/Desktop/teste.txt");
		}

		private void Calculate20Reais(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(quantToChange20Reais, action20Reais, quantTotal20Reais);
			DoWhatWasAskedFor(20f, valorTotal20Reais, quantTotal20Reais);
			InteractTxt(false, "C:/Users/Daniel/Desktop/teste.txt");
		}

		private void Calculate50Reais(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(quantToChange50Reais, action50Reais, quantTotal50Reais);
			DoWhatWasAskedFor(50f, valorTotal50Reais, quantTotal50Reais);
			InteractTxt(false, "C:/Users/Daniel/Desktop/teste.txt");
		}

		private void Calculate100Reais(object sender, EventArgs e)
		{
			DoWhatWasAskedFor(quantToChange100Reais, action100Reais, quantTotal100Reais);
			DoWhatWasAskedFor(100f, valorTotal100Reais, quantTotal100Reais);
			InteractTxt(false, "C:/Users/Daniel/Desktop/teste.txt");
		}
		#endregion

		private void quantTotalChanged(object sender, EventArgs e)
		{
			//InteractTxt(false, "C:/Users/Daniel/Desktop/teste.txt");
		}
	}
}
