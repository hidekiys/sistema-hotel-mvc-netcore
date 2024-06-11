using Microsoft.AspNetCore.Mvc;
using Sistema_Hotel.Models;
using Sistema_Hotel.Repositorio;

namespace Sistema_Hotel.Controllers
{
    public class Quartos : Controller
    {
        private readonly iQuartoRepositorio _quartoRepositorio;
        public Quartos(iQuartoRepositorio quartoRepositorio)
        {
            _quartoRepositorio = quartoRepositorio;
        }
        public IActionResult Index()
        {
            List<QuartoModel> quartos = _quartoRepositorio.BuscarTodos();
            return View(quartos);
        }
        public IActionResult Criar(int id)
        {
            QuartoModel quarto = _quartoRepositorio.ListarPorId(id);
            return View(quarto);
        }
        public IActionResult Editar()
        { 
            return View();
        }
        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(QuartoModel quarto) 
        {
            _quartoRepositorio.Adicionar(quarto);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(QuartoModel quarto)
        {
            _quartoRepositorio.Atualizar(quarto);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult CheckingOut(QuartoModel quarto)
        {
            _quartoRepositorio.CheckOut(quarto);
            return RedirectToAction("Index");
        }

    }
}
