using Sistema_Hotel.Controllers;
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
        public List<HospedeModel> BuscarTodosHospedes()
        {
            return _bancoContext.Hospedes.ToList();
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
            List<HospedeModel> hospedes = _bancoContext.Hospedes.ToList();

            foreach (var hospede in hospedes)
            {
                if (quarto.AtualCPF == hospede.CPF)
                {
                    quartoDb.AtualCPF = hospede.CPF;
                    quartoDb.AtualNome = hospede.Nome;
                }
            }
            quartoDb.ObjHospede = quarto.ObjHospede;
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

            quartoDb.AtualCPF = 0;
            quartoDb.AtualNome = null;
            quartoDb.DataIn = quarto.DataIn;
            quartoDb.DataOut = quarto.DataOut;
            quartoDb.Status = false;

            _bancoContext.Quartos.Update(quartoDb);
            _bancoContext.SaveChanges();

            return quartoDb;
        }

        public HospedeModel AdicionarHospede(HospedeModel hospede)
        {
            _bancoContext.Hospedes.Add(hospede);
            _bancoContext.SaveChanges();
            return hospede;
        }

        public bool Apagar(int id)
        {
            QuartoModel quartoDb = ListarPorId(id);
            if (quartoDb == null) throw new System.Exception("Houve um erro na deleção do quarto");

            _bancoContext.Quartos.Remove(quartoDb);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
