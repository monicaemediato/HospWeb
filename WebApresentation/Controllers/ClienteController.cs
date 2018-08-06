using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApresentation.Models;

namespace WebApresentation.Controllers
{
	public class ClienteController : BaseController
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
			model.Add(new ClienteModel()
			{
				nomeCliente = "Maria",
				rgCliente = 827536172,
				enderecoCliente = "Rua Marques",
				bairroCliente = "C",
				cidadeCliente = "Belo Horizonte",
				estadoCliente = "MG",
				CEPCliente = "45678932",
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
					//consulta
					var model = new ClienteModel()
						{
							//teste
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
			catch (Exception)
			{
				throw;
			}
		}

		[HttpPost]
		public ActionResult CadView(ClienteModel model) //requisição post por parametro
		{
			try
			{
				if (ModelState.IsValid)
				{
					//salva o model no banco
					Success("Cliente cadastrado com sucessso!", true);
					return RedirectToAction("Index");
				}
				else
				{
					Warning("Verifique todos os campos!", true);
					return View(model);
				}
			}
			catch(Exception )
			{
				Danger("Ocorreu um erro, entre em contato com o Administrador do sistema.", true);
				throw;
			}
		}

		public JsonResult getNome()
		{
			return Json("Lista", JsonRequestBehavior.AllowGet);
		}

		public JsonResult VerificaCliente(int idCliente)
		{
			string retorno = "Monica";

			return Json(retorno, JsonRequestBehavior.AllowGet); 
		}

		[HttpPost]
		public ActionResult setCliente(string nomeCliente)
		{
			string retorno = nomeCliente;

			return null;
		}
	}


} 