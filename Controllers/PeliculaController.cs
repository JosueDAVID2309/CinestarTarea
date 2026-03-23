using Microsoft.AspNetCore.Mvc;
using TareaCinestar.Controllers.dao;

namespace TareaCinestar.Controllers
{
    public class PeliculaController : Controller
    {
        daoPelicula daoPelicula = new daoPelicula();
        public IActionResult verPeliculas(int id)
        {
            return View(daoPelicula.getPeliculas(id));
        }

        public IActionResult verPelicula(int id)
        {
            ViewBag.Model = daoPelicula.getPelicula(id);
            return View();
        }

    }
}
