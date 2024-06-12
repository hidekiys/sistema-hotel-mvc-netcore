using Sistema_Hotel.Data;
using Sistema_Hotel.Models;

namespace Sistema_Hotel.Repositorio
{
    public class HospedeRepositorio : iHospedeRepositorio
    {
        private readonly BancoContext _bancoContext;
        public HospedeRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public List<HospedeModel> BuscarTodos()
        {
            return _bancoContext.Hospedes.ToList();
        }
        public HospedeModel ListarPorId(int id)
        {
            return _bancoContext.Hospedes.FirstOrDefault(x => x.CPF == id);
        }
        public bool Apagar(int id)
        {
            HospedeModel hospedeDb = ListarPorId(id);
            if (hospedeDb == null) throw new System.Exception("Houve um erro na deleção do quarto");

            _bancoContext.Hospedes.Remove(hospedeDb);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
