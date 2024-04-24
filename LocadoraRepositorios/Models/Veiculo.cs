using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocadoraRepositorios.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public Fabricante Fabricante { get; set; }
        public int FabricanteId { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Placa { get; set; }
        public int Quilometragem { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}
