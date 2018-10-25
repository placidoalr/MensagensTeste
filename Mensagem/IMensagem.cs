using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensagem
{
	public interface IMensagem
	{
		void enviar(string dest, string mensagem);

	}
}
