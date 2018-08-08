using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movie.Controllers
{
    public class gersonController : Controller
    {
        // GET: gerson
        public ActionResult Index()
        {
            return View();
        }
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hola " + name + ", El numero es : " + ID);
        }
        public string tareaGerson()
        {
            return "Hola soy una tarea";
        }
    }
}