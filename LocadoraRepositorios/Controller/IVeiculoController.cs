using LocadoraRepositorios.Models;

namespace LocadoraRepositorios.Controller
{
    public interface IVeiculoController
    {
        public void Cadastrar(Veiculo veiculo);
        List<Veiculo> ObterTodos();
        void Apagar(int id);
        Veiculo ObterPorId(int id);
        public int ObterDisponiveis();
    }
}
