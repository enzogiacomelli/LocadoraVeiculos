using LocadoraRepositorios.Controller;

namespace LocadoraViewForms.Views
{
    public partial class LocacoesListagemForm : Form
    {
        IVeiculoController veiculoController;
        IClienteController clienteController;
        ILocacoesController locacoesController;

        public LocacoesListagemForm()
        {
            InitializeComponent();
            veiculoController = new VeiculoController();
            clienteController = new ClienteController();
            locacoesController = new LocacoesController();
            CarregarListagemLocacoes();
        }


        private void CarregarListagemLocacoes()
        {
            dataGridViewLocacoes.Rows.Clear();
            var locacoes = locacoesController.ObterTodos();

            foreach (var locacao in locacoes)
            {
                var cliente = clienteController.ObterPorId(locacao.ClienteId);
                var veiculo = veiculoController.ObterPorId(locacao.VeiculoId);
                var row = (DataGridViewRow)dataGridViewLocacoes.Rows[0].Clone();

                row.Cells[0].Value = cliente.Nome;
                row.Cells[1].Value = veiculo.Nome;
                row.Cells[2].Value = locacao.Diarias;
                row.Cells[3].Value = locacao.ValorFinal;
                row.Cells[4].Value = locacao.Inicio;
                row.Cells[5].Value = locacao.Fim;
                row.Cells[6].Value = locacao.Id;

                dataGridViewLocacoes.Rows.Add(row);
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var form = new LocacoesCadastroForm();
            form.ShowDialog();
            CarregarListagemLocacoes();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ainda n fiz");
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewLocacoes.SelectedRows.Count > 0)
            {
                var dialogResult = MessageBox.Show("Deseja continuar?", "Aviso!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var row = (DataGridViewRow)dataGridViewLocacoes.SelectedRows[0];
                    var id = Convert.ToInt32(row.Cells[6].Value);

                    locacoesController.Apagar(id);
                    MessageBox.Show("Registro excluido com sucesso!");
                    CarregarListagemLocacoes();
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
    }
}
