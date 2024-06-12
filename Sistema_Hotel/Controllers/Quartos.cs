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
        public IActionResult ApagarConfirmacao(int id)
        {
            QuartoModel quarto = _quartoRepositorio.ListarPorId(id);
            return View(quarto);
        }


        public IActionResult Criar(int id)
        {
            List<HospedeModel> oListHospede = _quartoRepositorio.BuscarTodosHospedes();

            QuartoModel quarto = _quartoRepositorio.ListarPorId(id);
            
            return View(quarto);
        }

        public IActionResult Editar(int id)
        {
            QuartoModel quarto = _quartoRepositorio.ListarPorId(id);

            return View(quarto);
        }
        public IActionResult Novo()
        {
            return View();
        }
        public IActionResult NovoHospede(int id)
        {
            return View();
        }
        public IActionResult Apagar(int id)
        {
            _quartoRepositorio.Apagar(id);
            return RedirectToAction("Index");
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
        [HttpPost]
        public IActionResult NewHospede(HospedeModel hospede)
        {
             _quartoRepositorio.AdicionarHospede(hospede);
             return RedirectToAction("Index");

        }

    }
}
