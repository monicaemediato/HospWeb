using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClass.Entidades
{
	public class User
	{
		public int ID { get; set; }
		public string cNome { get; set; }
		public double cRG { get; set; }
		public string cEndereco { get; set; }
		public string cBairro { get; set; }
		public string cCidade { get; set; }
		public string cEstado { get; set; }
		public string cCEP { get; set; }
		public DateTime cNascimento { get; set; }
	}
}
