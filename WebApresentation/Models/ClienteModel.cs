using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApresentation.Models
{
	public class ClienteModel
	{
		public int codCliente { get; protected set; }

		[Required(ErrorMessage = "Campo Obrigatório!")]
		[Display(Name ="Nome")]
		public string nomeCliente { get; set; }

		[Required(ErrorMessage = "Campo Obrigatório!")]
		[Display(Name = "Rg")]
		[MaxLength(9, ErrorMessage = "Campo com tamanho máximo de 9 caracteres!")]
		public double rgCliente { get; set; }

		[Display(Name = "Endereco")]
		[Required(ErrorMessage = "Campo Obrigatório!")]
		public string enderecoCliente { get; set; }

		[Required(ErrorMessage = "Campo Obrigatório!")]
		[Display(Name = "Bairro")]
		public string bairroCliente { get; set; }

		[Required(ErrorMessage = "Campo Obrigatório!")]
		[Display(Name = "Cidade")]
		public string cidadeCliente { get; set; }

		[Required(ErrorMessage = "Campo Obrigatório!")]
		[Display(Name = "Estado")]
		public string estadoCliente { get; set; }

		[Required(ErrorMessage = "Campo Obrigatório!")]
		[MaxLength(7, ErrorMessage = "Campo com tamanho máximo de 7 caracteres!")]
		[Display(Name = "CEP")]
		public string CEPCliente { get; set; }

		[Display(Name = "Data Nascimento")]
		[Required(ErrorMessage = "Campo Obrigatório!")]
		public DateTime nascimentoCliente { get; set; }


		//cliente model view para adicionar o tipo para somente o usuario ver
	}
}