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
		Telefone TipoTelefone(double telefone, int codChale);
	}//metodo retorna usuario - tipo telefone
}
