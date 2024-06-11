using Sistema_Hotel.Models;

namespace Sistema_Hotel.Repositorio
{
    public interface iQuartoRepositorio
    {
        QuartoModel ListarPorId(int id);
        List<QuartoModel> BuscarTodos();
        QuartoModel Adicionar(QuartoModel quarto);
        QuartoModel Atualizar(QuartoModel quarto);

        QuartoModel CheckOut(QuartoModel quarto);
    }
}
