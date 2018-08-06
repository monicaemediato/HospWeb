using DomainClass.Entidades;
using DomainClass.Interfaces.Repositórios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositórios
{
	public class ReposUser : iRepos

	{
		public Telefone TipoTelefone(double telefone, int codCliente)
		{
			try
			{
				Telefone novoTelefone = new Telefone()
				{
					telefone = 1.3212
				};
				return novoTelefone;
			}
			catch (Exception)
			{
				throw;
			}
			}
		}
	}
}
