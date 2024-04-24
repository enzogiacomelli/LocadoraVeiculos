using Dapper;
using LocadoraRepositorios.BancoDados;
using LocadoraRepositorios.Models;

namespace LocadoraRepositorios.Controller
{
    public class VeiculoController : IVeiculoController
    {

        public VeiculoController() { }

        public void Apagar(int id)
        {
           var veiculo = ObterPorId(id);
           string deleteQuery = "DELETE FROM Veiculos WHERE Id = @Id;";
           var connection = sqlDb.CreateConnection();
           connection.Query(deleteQuery, veiculo);
        }

        public void Cadastrar(Veiculo veiculo)
        {
            string insertQuery = "INSERT INTO Veiculos (FabricanteId, Tipo, Nome, Placa, Quilometragem, ValorDiaria) VALUES (@FabricanteId, @Tipo, @Nome, @Placa, @Quilometragem, @ValorDiaria);";
            var connection = sqlDb.CreateConnection();
            connection.Query(insertQuery, veiculo);
        }

        public Veiculo ObterPorId(int id)
        {
            string selectQuery = "SELECT * FROM Veiculos WHERE Id = @Id;";
            var connection = sqlDb.CreateConnection();
            Veiculo veiculo = new Veiculo();
            veiculo.Id = id;
            veiculo = connection.QuerySingle<Veiculo>(selectQuery, veiculo);
            return veiculo;
        }

        public List<Veiculo> ObterTodos()
        {
            string selectQuery = "SELECT * FROM Veiculos ORDER BY Nome;";
            var connection = sqlDb.CreateConnection();
            List<Veiculo> veiculos = connection.Query<Veiculo>(selectQuery).ToList();
            return veiculos;
        }

        public int ObterDisponiveis()
        {
            return 0;//implementar dps
        }

        //fazer update
    }
}
