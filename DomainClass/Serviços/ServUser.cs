using DomainClass.Entidades;
using DomainClass.Interfaces.Repositórios;
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

		private iRepos _repository;

		public ServUser(iRepos repository)
		{
			_repository = repository;
		}

		public Telefone TipoTelefone(double telefone, int codCliente)
		{
			return _repository.TipoTelefone(telefone, codCliente);
		}
	}
}
