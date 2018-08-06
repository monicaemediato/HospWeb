using AppClass.IAppServiços;
using DomainClass.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApresentation.Controllers
{
	public class HomeController : BaseController
	{

		private IAppServ _appCliente;

		public HomeController(IAppServ appCliente)
		{
			_appCliente = appCliente; 
		}

		public ActionResult Index()
		{
			Telefone tel = _appCliente.TipoTelefone(1111.2222 , 1);
			
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}
