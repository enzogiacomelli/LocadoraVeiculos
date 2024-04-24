using LocadoraRepositorios.Models;

namespace LocadoraRepositorios.Controller
{
    public interface IFabricanteController
    {
        public void Cadastrar(Fabricante fabricante);
        List<Fabricante> ObterTodos();
        void Apagar(int id);
        Fabricante ObterPorId(int id);
    }
}
