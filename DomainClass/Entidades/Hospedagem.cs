using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClass.Entidades
{
	public class Hospedagem
	{
		public int codHospedagem { get; set; }

		private Chale codChale1;

		public virtual Chale GetcodChale()
		{
			return codChale1;
		}

		public virtual void SetcodChale(Chale value)
		{
			codChale1 = value;
		}

		public DateTime dataInicio { get; set; }
		public DateTime dataFim { get; set; }
		public double qtdPessoas { get; set; }
		public double desconto { get; set; }
		public double valorFinal { get; set; }
		public virtual User User { get; set; }
	}
}
