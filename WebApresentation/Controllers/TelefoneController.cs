using AppClass.IAppServiços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApresentation.Models;

namespace WebApresentation.Controllers
{ 

	//criei
	public class TelefoneController : BaseController
	{

		private readonly IAppServ _cliente;
		private readonly IAppServ _telefone;

		public ActionResult TelefoneController(IAppServ codcliente)
		{
			_cliente = codcliente;
		}

		// GET: Base
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult TipoTelefone()
		{
			return View();
		}

		[HttpPost]
		public ActionResult TipoTelefone(TipoTelefoneModel model)
		{

			if (ModelState.IsValid)
			{
				var telefone = _cliente.TipoTelefone(model.Telefone, model.codCliente);

				if (telefone == null)
				{
					Warning("Telefone ou Código do Cliente inválidos!", true);
					return View(model); 
				}
				else
				{
					//salvar banco
				}
			}
			else { }
			return View();
		}
	}
}