using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensagem
{
	public class Email : IMensagem
	{
		public void enviar(string dest, string mensagem)
		{
			Console.WriteLine("EMAIL");
			Console.WriteLine("Destinatário: {0}", dest);
			Console.WriteLine("Mensgagem: {0}", mensagem);
		}
	}
}
