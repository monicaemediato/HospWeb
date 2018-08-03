using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClass.Entidades
{
	public class Chale
	{
		public int codChale { get; set; }
		public string localizacao { get; set; }
		public string capacidade { get; set; }
		public double valorAltaEdtacao { get; set; }
		public double valorBaixaEstacao { get; set; }

		public int GetcodChale()
		{
			return codChale;
		}

		public virtual void SetcodChale(Chale value)
		{
			codChale = value;
		}

		public static implicit operator int(Chale v)
		{
			throw new NotImplementedException();
		}
	}


}
