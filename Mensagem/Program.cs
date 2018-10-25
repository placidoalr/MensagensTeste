using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mensagem
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Funcoes funcoes = new Funcoes();

			Email e = new Email();
			Mobile m = new Mobile();
			WhatsApp w = new WhatsApp();

			funcoes.mensageiro(e, "placido@gmail.com", "A kauana é vaca!!");
			funcoes.mensageiro(w, "+55 48 9 8888-8888", "A thalyne é linda demais!!!!!");

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			funcoes.mensageiro(m, "+55 47 9 9999-9999", "A joice não tem opinião propria!!");
			funcoes.discador(m, "+55 47 9 0000-9009");


			Console.WriteLine("Pressione qualquer tecla para continuar...");
			Console.ReadKey();
			//string comparar = null;
			//comparar += "abc123ABC$. +-";
			//Console.WriteLine(comparar);
			//comparar += "_)(*/";
			//Console.WriteLine(comparar);
			//comparar += "\n";
			//Console.WriteLine(comparar);
			//comparar = comparar.Replace("\n", "^");
			//Console.WriteLine(comparar);
			//string valorTratado = Regex.Replace(comparar, "[^0-9^ .]", "");
			//Console.WriteLine(valorTratado);
			//valorTratado = valorTratado.Replace("^", "\n");
			//Console.WriteLine(valorTratado);
			//Console.ReadKey();
		}
		
	}
}
