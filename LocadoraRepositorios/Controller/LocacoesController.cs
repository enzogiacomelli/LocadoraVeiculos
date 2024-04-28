using Dapper;
using LocadoraRepositorios.BancoDados;
using LocadoraRepositorios.Models;

namespace LocadoraRepositorios.Controller
{
    public class LocacoesController : ILocacoesController
    {
        public void Apagar(int id)
        {
            string deleteQuery = "DELETE FROM Locacoes WHERE Id = @Id";
            var connection = sqlDb.CreateConnection();
            var locacao = new Locacao();
            locacao.Id = id;
            connection.Query(deleteQuery, locacao);
        }

        public void Atualizar(Locacao locacao)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Locacao locacao)
        {
            string insertQuery = "INSERT INTO Locacoes (ClienteId, VeiculoId, Diarias, ValorFinal, Inicio, Fim) VALUES (@ClienteId, @VeiculoId, @Diarias, @ValorFinal, @Inicio, @Fim);";
            var connection = sqlDb.CreateConnection();
            connection.Query(insertQuery, locacao);
        }

        public Locacao ObterPorId(int id)
        {
            string selectQuery = "SELECT * FROM Locacoes WHERE Id = @Id;";
            var connection = sqlDb.CreateConnection();
            var locacao = new Locacao();
            locacao.Id = id;
            var loc = connection.QuerySingle<Locacao>(selectQuery, locacao);
            return loc;
        }

        public List<Locacao> ObterTodos()
        {
            string selectQuery = "SELECT * FROM Locacoes ORDER BY Inicio;";
            var connection = sqlDb.CreateConnection();
            var locacoes = connection.Query<Locacao>(selectQuery).ToList();
            return locacoes;
        }
    }
}
