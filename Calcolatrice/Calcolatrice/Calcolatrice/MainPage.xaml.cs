using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ClassCalcolatriceLibrary;



namespace Calcolatrice
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			
			
		}
		Operazione op = new Operazione();
		double numero1 = 0;
		double ans = 0;
		double risultato = 0;
		string lastButton;
		bool lastOp = true;

		

		private void btn_Clicked(object sender, EventArgs e)
		{
			Button btn = sender as Button;

			if (lastOp == false)
			{
				lastOp = true;
				lbl_operazione.Text = "";
				lbl_risultato.Text = "";
				if (btn.Text != "ANS")
				{
					if (lbl_calcoli.Text == "0")
						lbl_calcoli.Text = "";
					lbl_calcoli.Text = lbl_calcoli.Text + btn.Text;
				}
				else
					lbl_calcoli.Text = lbl_calcoli.Text + ans;
			}
			else
			{
				if (btn.Text != "ANS")
				{
					if (lbl_calcoli.Text == "0")
						lbl_calcoli.Text = "";
					lbl_calcoli.Text = lbl_calcoli.Text + btn.Text;
				}
				else
					lbl_calcoli.Text = lbl_calcoli.Text + ans;
			}
			


		}

		private void btn_operazioneClicked(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			numero1 = Convert.ToDouble(lbl_calcoli.Text);
			lbl_calcoli.Text = "";
			lbl_operazione.Text=Convert.ToString(lbl_operazione.Text + numero1 + "+");
			risultato = op.TutteOperazioni(risultato, numero1,btn.Text);
			lastButton = btn.Text;
		}

		

		private void btn_operazioneRadice_Clicked(object sender, EventArgs e)
		{

		}

		private void btn_Virgola_Clicked(object sender, EventArgs e)
		{
			
				
			lbl_calcoli.Text = lbl_calcoli.Text + ",";
		}

		private void btn_Uguale_Clicked(object sender, EventArgs e)
		{
			if(lastButton=="+")
			{
				numero1 = Convert.ToDouble(lbl_calcoli.Text);
				lbl_operazione.Text = Convert.ToString(lbl_operazione.Text + numero1);		
				risultato = op.TutteOperazioni(risultato, numero1,"+");				
				lbl_risultato.Text = Convert.ToString(risultato);
				lastButton = "";
			}
			if (lastButton == "*")
			{
				numero1 = Convert.ToDouble(lbl_calcoli.Text);
				lbl_operazione.Text = Convert.ToString(lbl_operazione.Text + numero1);
				risultato = op.TutteOperazioni(risultato, numero1, "*");
				lbl_risultato.Text = Convert.ToString(risultato);
				lastButton = "";
			}
			if (lastButton == "-")
			{
				numero1 = Convert.ToDouble(lbl_calcoli.Text);
				lbl_operazione.Text = Convert.ToString(lbl_operazione.Text + numero1);
				risultato = op.TutteOperazioni(risultato, numero1, "-");
				lbl_risultato.Text = Convert.ToString(risultato);
				lastButton = "";
			}
			if (lastButton == "/")
			{
				numero1 = Convert.ToDouble(lbl_calcoli.Text);
				lbl_operazione.Text = Convert.ToString(lbl_operazione.Text + numero1);
				risultato = op.TutteOperazioni(risultato, numero1, "/");
				lbl_risultato.Text = Convert.ToString(risultato);
				lastButton = "";
			}
			ans = risultato;
			lbl_calcoli.Text = "";
			lastOp = false;

		}

		private void btn_Del_Clicked(object sender, EventArgs e)
		{
			lbl_calcoli.Text.Remove(lbl_calcoli.Text.Length - 1, 1);
		}

		private void btn_C_Clicked(object sender, EventArgs e)
		{
			lbl_calcoli.Text = "";
			lbl_operazione.Text = "";
			lbl_risultato.Text = "";
			numero1 = 0;
			risultato = 0;

		}

		private void btn_Ans_Clicked(object sender, EventArgs e)
		{
			lbl_calcoli.Text = lbl_calcoli.Text + ans;
		}
	}
}
