using DomainClass.Entidades;
using DomainClass.Interfaces.Serviços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//essa classe implementa a interface....... serviço com usuario
namespace DomainClass.Serviços
{
	public class ServUser : IServUser
	{

		public Entidades.Telefone TipoTelefone(double telefone, int codChale)
		{
			throw new NotImplementedException();
		}
	}
}
