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
		User TipoTelefone(string telefone, int ID);

	}
}
