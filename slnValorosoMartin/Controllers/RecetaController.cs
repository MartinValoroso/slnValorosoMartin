using Microsoft.AspNetCore.Mvc;
using slnValorosoMartin.Data;
using slnValorosoMartin.Models;
using System.Linq;

namespace slnValorosoMartin.Controllers
{
    public class RecetaController : Controller
    {
        // **** ESTO VA SIEMPRE ****
        private readonly RecetaDBContext context;

        public RecetaController(RecetaDBContext context)
        {
            this.context = context;
        }


        //  GET  /Receta
        [HttpGet]
        public IActionResult Index()
        {
            //lista de operas
            var recetas = context.Recetas.ToList();
            //enviar la lista a la vista
            return View(recetas);
        }



        //****************** CREATE *********************


        //GET Receta/Create
        [HttpGet]
        public ActionResult Create()
        {
            Receta receta = new Receta();

            return View("Create", receta); //devuelve al cliente html(vista)

        }

        //Post: Receta/create
        [HttpPost]
        public ActionResult Create(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Recetas.Add(receta);
                context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(receta);
        }


        //**************** DETAILS *******************

        //GET receta/deatalles/4
        [HttpGet]
        public ActionResult Details(string apellido)
        {
            Receta receta = context.Recetas
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                return View("Details", receta);
            }

        } 

        //************** DELETE ******************

        // opera/delete/1
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var receta = TraerUna(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                return View(receta);
            }
        }
        //POST opera/delete/1
        [ActionName("Delete")]
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var receta = TraerUna(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                context.Recetas.Remove(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


        }






        //´métodos privados
        private Receta TraerUna(int id)
        {
            return context.Recetas.Find(id);
        }


    }
}
