using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApresentation.Helpers;

namespace WebApresentation.Controllers
{
    public class BaseController : Controller
    {
		

	
		public void AddAlert (string alertStyle, string message, bool dismissable)
		{
			var alerts = TempData.ContainsKey(Alert.TempDataKey) ?  //se o tempdata é a chave que foi denifida
				(List<Alert>)TempData[Alert.TempDataKey] //então
				: new List<Alert>(); //se não

			alerts.Add(new Alert
			{
				AlertStyle = alertStyle,
				Dismissable = dismissable,
				Message = message
			});

			TempData[Alert.TempDataKey] = alerts;

		}

		public void Success (string message, bool dismissable = false)
		{
			AddAlert(AlertStyles.Sucess, message, dismissable);
		}

		public void Information(string message, bool dismissable = false)
		{
			AddAlert(AlertStyles.Information, message, dismissable);
		}

		public void Warning(string message, bool dismissable = false)
		{
			AddAlert(AlertStyles.Warning, message, dismissable);
		}

		public void Danger(string message, bool dismissable = false)
		{
			AddAlert(AlertStyles.Danger, message, dismissable);
		}

		//public ActionResult Index()
        //{
        //    return View();
        //}
    }
}