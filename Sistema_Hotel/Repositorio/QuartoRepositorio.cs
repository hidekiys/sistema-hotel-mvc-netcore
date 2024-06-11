using Sistema_Hotel.Data;
using Sistema_Hotel.Models;

namespace Sistema_Hotel.Repositorio
{
    public class QuartoRepositorio : iQuartoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public QuartoRepositorio(BancoContext bancoContext) 
        { 
            _bancoContext = bancoContext;
        }
        public QuartoModel ListarPorId(int id)
        {
            return _bancoContext.Quartos.FirstOrDefault(x => x.Id == id);
        }
        public List<QuartoModel> BuscarTodos()
        {
            return _bancoContext.Quartos.ToList();
        }
        public QuartoModel Adicionar(QuartoModel quarto)
        {
            _bancoContext.Quartos.Add(quarto);
            _bancoContext.SaveChanges();
            return quarto;
        }

        public QuartoModel Atualizar(QuartoModel quarto)
        {
            QuartoModel quartoDb = ListarPorId(quarto.Id);

            if (quartoDb == null) throw new System.Exception("Houve um erro na atualização do quarto");

            quartoDb.Hospede = quarto.Hospede;
            quartoDb.DataIn = quarto.DataIn;
            quartoDb.DataOut = quarto.DataOut;
            quartoDb.Status = quarto.Status;

            _bancoContext.Quartos.Update(quartoDb);
            _bancoContext.SaveChanges();

            return quartoDb;
        }

        public QuartoModel CheckOut(QuartoModel quarto)
        {
            QuartoModel quartoDb = ListarPorId(quarto.Id);

            if (quartoDb == null) throw new System.Exception("Houve um erro no check out do quarto");

            quartoDb.Hospede = null;
            quartoDb.DataOut = quarto.DataOut;
            quartoDb.Status = false;

            _bancoContext.Quartos.Update(quartoDb);
            _bancoContext.SaveChanges();

            return quartoDb;
        }
    }
}
