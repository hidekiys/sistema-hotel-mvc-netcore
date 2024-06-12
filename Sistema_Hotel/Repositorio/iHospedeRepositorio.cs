using Sistema_Hotel.Models;

namespace Sistema_Hotel.Repositorio
{
    public interface iHospedeRepositorio
    {
        List<HospedeModel> BuscarTodos();
        HospedeModel ListarPorId(int id);
        bool Apagar(int id);
    }
}
