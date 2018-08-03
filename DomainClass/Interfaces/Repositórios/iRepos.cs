using DomainClass.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClass.Interfaces.Repositórios
{
	public interface iRepos
	{
		Telefone TipoTelefone(double telefone, int codChale);
	}
}
