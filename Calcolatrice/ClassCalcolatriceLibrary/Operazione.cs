using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCalcolatriceLibrary
{
	public class Operazione : IOperazione
	{
		
		public double TutteOperazioni(double a, double b, string segni)
		{
			if (segni=="+")
			{
				return a + b;
			}
			if (segni == "-")
			{
				return a - b;

			}
			if (segni == "*")
			{
				return a * b;

			}
			else
			{
				try
				{
					return a / b;
				}
				catch (Exception e)
				{
					return 0;
				}
			}	
		}
	}
}
