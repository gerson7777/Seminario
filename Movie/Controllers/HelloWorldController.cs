using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movie.Controllers
{
    public class HelloWorldController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        // GET: HelloWorld
        // public String  Index()
        //{

        //   return "Hola a todos";
        //}

        // public String welcome(string nombre, int numTimes=1)
        //{
        //  return "es la bienvenida de la pagina"+ nombre + " "+numTimes;
        // }
        //public ActionResult Welcome (string name, int  ID=1)
        //{
        //    ViewBag.numTimes = ID;
        //    ViewBag.Message = name;

        //    return View();
        //    //return "id has a value of" + id.ToString();
        //}
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}