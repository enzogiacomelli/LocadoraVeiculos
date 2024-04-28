using Azure.Core;
using LocadoraRepositorios.Controller;
using LocadoraRepositorios.Models;


namespace LocadoraViewForms.Views
{
    public partial class VeiculosListagemForm : Form
    {
        IVeiculoController veiculoController;
        IFabricanteController fabricanteController;
        public VeiculosListagemForm()
        {
            InitializeComponent();
            veiculoController = new VeiculoController();
            fabricanteController = new FabricanteController();
            CarregarListagemVeiculos();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            var form = new VeiculoCadastroForm();
            form.ShowDialog();
            CarregarListagemVeiculos();
        }

        private void CarregarListagemVeiculos()
        {
            dataGridViewVeiculos.Rows.Clear();
            var veiculos = veiculoController.ObterTodos();

            foreach (Veiculo veiculo in veiculos)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewVeiculos.Rows[0].Clone();
                veiculo.Fabricante = fabricanteController.ObterPorId(veiculo.FabricanteId);
                row.Cells[0].Value = veiculo.Fabricante.Nome;
                row.Cells[1].Value = veiculo.Nome;
                row.Cells[2].Value = veiculo.Placa;
                row.Cells[3].Value = veiculo.Quilometragem;
                row.Cells[4].Value = veiculo.ValorDiaria;
                row.Cells[5].Value = veiculo.Tipo;
                row.Cells[6].Value = veiculo.Id;

                dataGridViewVeiculos.Rows.Add(row);
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            CarregarListagemVeiculos();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewVeiculos.SelectedRows.Count > 0)
            {
                var dialogResult = MessageBox.Show("Deseja continuar?", "Aviso!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var row = dataGridViewVeiculos.CurrentRow;
                    var id = Convert.ToInt32(row.Cells[6].Value);
                    veiculoController.Apagar(id);
                    MessageBox.Show("Registro excluido com sucesso!");
                    CarregarListagemVeiculos();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
                else
                {
                    MessageBox.Show("Selecione uma linha!", "Aviso!");
                }
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edição!");
        }
    }
}
