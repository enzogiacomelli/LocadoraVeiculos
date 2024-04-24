using Dapper;
using LocadoraRepositorios.BancoDados;
using LocadoraRepositorios.Models;

namespace LocadoraRepositorios.Controller
{
    public class FabricanteController : IFabricanteController
    {
        public FabricanteController() { }

        public void Apagar(int id)
        {
           var fabricante = ObterPorId(id);
           string deleteQuery = "DELETE FROM Fabricantes WHERE Id = @Id;";
           var connection = sqlDb.CreateConnection();
           connection.Query(deleteQuery, fabricante);
        }

        public void Cadastrar(Fabricante fabricante)
        {
            string insertQuery = "INSERT INTO Fabricantes (Nome) VALUES (@Nome);";
            var connection = sqlDb.CreateConnection();
            connection.Query(insertQuery, fabricante);
        }

        public Fabricante ObterPorId(int id)
        {
            string selectQuery = "SELECT * FROM Fabricantes WHERE Id = @Id;";
            var connection = sqlDb.CreateConnection();
            Fabricante fabricante = new Fabricante();
            fabricante.Id = id;
            fabricante = connection.QuerySingle<Fabricante>(selectQuery, fabricante);
            return fabricante;
        }

        public List<Fabricante> ObterTodos()
        {
            string selectQuery = "SELECT * FROM Fabricantes ORDER BY Nome;";
            var connection = sqlDb.CreateConnection();
            List<Fabricante> fabricantes = connection.Query<Fabricante>(selectQuery).ToList();
            return fabricantes;
        }
        //fazer o update
    }
}
