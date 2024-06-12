using Microsoft.AspNetCore.Mvc;
using Sistema_Hotel.Models;
using Sistema_Hotel.Repositorio;

namespace Sistema_Hotel.Controllers
{
    public class Hospedes : Controller
    {

        private readonly iHospedeRepositorio _hospedeRepositorio;
        public Hospedes(iHospedeRepositorio hospedeRepositorio)
        {
            _hospedeRepositorio = hospedeRepositorio;
        }
        public IActionResult Index()
        {
            List<HospedeModel> hospedes = _hospedeRepositorio.BuscarTodos();
            return View(hospedes);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            HospedeModel hospede = _hospedeRepositorio.ListarPorId(id);
            return View(hospede);
        }
        public IActionResult Apagar(int id)
        {
            _hospedeRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }
    }
}
