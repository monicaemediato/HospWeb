using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClass.Entidades
{
	public class User
	{
		public int codCliente { get; protected set; }
		public string nomeCliente { get; set; }
		public double rgCliente { get; set; }
		public string enderecoCliente { get; set; }
		public string bairroCliente { get; set; }
		public string cidadeCliente { get; set; }
		public string estadoCliente { get; set; }
		public string CEPCliente { get; set; }
		public DateTime nascimentoCliente { get; set; }
	}
}
