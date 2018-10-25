using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensagem
{
	public class Sms : IMensagem
	{
		public void enviar(string dest, string mensagem)
		{
			Console.WriteLine("SMS");
			Console.WriteLine("Destinatário: {0}", dest);
			Console.WriteLine("Mensgagem: {0}", mensagem);
		}
	}
}
