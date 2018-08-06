using AppClass.IAppServiços;
using DomainClass.Interfaces.Serviços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClass.AppServiços
{
	public class AppServUser : IAppServ
	{
		private IServUser _services;

		public AppServUser(IServUser services)
		{
			_services = services;
		}

		public DomainClass.Entidades.Telefone TipoTelefone(double telefone, int codCliente)
		{
			return _services.TipoTelefone(telefone, codCliente);
		}
	}
}
