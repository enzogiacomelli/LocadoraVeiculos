using LocadoraRepositorios.Models;

namespace LocadoraRepositorios.Controller
{
    public interface IClienteController
    {
        public void Cadastrar(Cliente cliente);
        List<Cliente> ObterTodos();
        void Apagar(int id);
        Cliente ObterPorId(int id);

        public void Atualizar(Cliente cliente);

        public int ObterTotal();
    }
}
