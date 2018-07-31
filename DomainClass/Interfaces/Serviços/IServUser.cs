using DomainClass.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClass.Interfaces.Serviços
{
	public interface IServUser
	{
		User TipoTelefone(string telefone, int ID);
	}//metodo retorna usuario - tipo telefone
}
