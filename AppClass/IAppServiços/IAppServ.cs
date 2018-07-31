using DomainClass.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClass.IAppServiços
{
	public interface IAppServ
	{

		User TipoTelefone(string telefone, int ID);
	}
}
]

//telefone seria uma nova entidade do dominio?