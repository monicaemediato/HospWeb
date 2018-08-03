using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApresentation.Models;

namespace WebApresentation.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
			var model = new List<ClienteModel>();

			model.Add(new ClienteModel()
			{
				nomeCliente = "Monica",
				rgCliente = 197828,
				enderecoCliente = "Rua Flavio",
				bairroCliente = "B",
				cidadeCliente = "Belo Horizonte",
				estadoCliente = "MG",
				CEPCliente = "30494030",
			//	nascimentoCliente = 20130816
			});
            return View(model);
        }

		public ActionResult CadView(int? idCliente)
		{
			try
			{
				if (idCliente == null)
				{
					return View();
				}
				else
				{
					var model = new ClienteModel()
						{
							nomeCliente = "Monica",
							rgCliente = 197828,
							enderecoCliente = "Rua Flavio",
							bairroCliente = "B",
							cidadeCliente = "Belo Horizonte",
							estadoCliente = "MG",
							CEPCliente = "30494030",
						};
					return View(model);
				}
			}
			catch(Exception)
		}
	}
}