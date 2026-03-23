using Microsoft.AspNetCore.Mvc;
using TareaCinestar.Controllers.dao;

namespace TareaCinestar.Controllers
{
    public class CineController : Controller
    {
        daoCine daoCine = new daoCine();
        public IActionResult Inicio()
        {
            return View();
        }

        public IActionResult verCines()
        {
            
            return View(daoCine.getCines());
        }

        public IActionResult verCine(int idCine)
        {
            ViewBag.Cine = daoCine.getCine(idCine);
            ViewBag.CineTarifas = daoCine.getCineTarifas(idCine);
            ViewBag.CinePeliculas = daoCine.getCinePeliculas(idCine);
            return View();
        }
    }
}
