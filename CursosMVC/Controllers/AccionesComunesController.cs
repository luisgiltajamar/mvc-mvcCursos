using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CursosMVC.Models;

namespace CursosMVC.Controllers
{
    public class AccionesComunesController : Controller
    {
        private DatosEntities db=new DatosEntities();
        public ActionResult ListProfesores()
        {

            var profes = db.Profesor.ToList();
            return View(profes);
        }
    }
}