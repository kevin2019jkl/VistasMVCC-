using MVC_Vistas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Vistas.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DatosPersonales(DatosEmail obj)
        {
            if (ModelState.IsValid)
            {
                String email = obj.email;
                String password = obj.password;
                if (email == "kevin@gmail.com" && password == "12345")
                {
                    return View();
                }
                else
                {
                    return View("Index");
                }

            }
            else
            {
                return View("Index");
            }
        }
        public ActionResult MostrarDatos(DatosPersonales obj)
        {
            if (ModelState.IsValid)
            {
                return View(obj);
            }
            else
            {
                return View("DatosPersonales");
            }
        }
    }
}