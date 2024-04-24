using LocadoraRepositorios.Models;

namespace LocadoraRepositorios.Controller
{
    public interface ILocacoesController
    {
        public void Cadastrar(Locacao locacao);
        public List<Locacao> ObterTodos();
        public Locacao ObterPorId(int id);
        public void Apagar(int id);
        public void Atualizar(Locacao locacao);

    }
}
