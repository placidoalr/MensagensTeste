using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensagem
{
	public class Funcoes
	{
		public void mensageiro(IMensagem msg, string dest, string conteudo)
		{
			Console.WriteLine("Preparando o envio de mensagens...");
			msg.enviar(dest,conteudo);
		}
		public void discador(ILigacao l, string numero)
		{
			l.fazerChamada(numero);
		}
	}
}
