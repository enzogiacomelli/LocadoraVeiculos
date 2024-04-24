using Dapper;
using LocadoraRepositorios.BancoDados;
using LocadoraRepositorios.Models;

namespace LocadoraRepositorios.Controller
{
    public class ClienteController : IClienteController
    {
        public void Apagar(int id)
        {
            var cliente = ObterPorId(id);
            string deleteQuery = "DELETE FROM Clientes WHERE Id = @Id;";
            var connection = sqlDb.CreateConnection();
            connection.Query(deleteQuery, cliente);
        }

        public void Atualizar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Cliente cliente)
        {
            string insertQuery = "INSERT INTO Clientes (Nome, Documento, Telefone) VALUES (@Nome, @Documento, @Telefone);";
            var connection = sqlDb.CreateConnection();
            connection.Query(insertQuery, cliente);
        }

        public Cliente ObterPorId(int id)
        {
            string selectQuery = "SELECT * FROM Clientes WHERE Id = @Id;";
            var connection = sqlDb.CreateConnection();
            Cliente cliente = new Cliente();
            cliente.Id = id;
            cliente = connection.QuerySingle<Cliente>(selectQuery, cliente);
            return cliente;
        }

        public List<Cliente> ObterTodos()
        {
            string selectQuery = "SELECT * FROM Clientes ORDER BY Nome;";
            var connection = sqlDb.CreateConnection();
            List<Cliente> clientes = connection.Query<Cliente>(selectQuery).ToList();
            return clientes;
        }

        public int ObterTotal()
        {
            string selectQuery = "SELECT * FROM Clientes;";
            var connection = sqlDb.CreateConnection();
            var totalDeClientes = connection.Query(selectQuery);
            return totalDeClientes.Count();
        }
    }
}
