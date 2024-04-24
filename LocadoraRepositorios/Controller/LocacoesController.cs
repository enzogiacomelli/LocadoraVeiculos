﻿using Dapper;
using LocadoraRepositorios.BancoDados;
using LocadoraRepositorios.Models;

namespace LocadoraRepositorios.Controller
{
    public class LocacoesController : ILocacoesController
    {
        public void Apagar(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public List<Locacao> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}