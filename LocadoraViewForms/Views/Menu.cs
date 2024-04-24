

using LocadoraRepositorios.Controller;

namespace LocadoraViewForms.Views
{
    public partial class Menu : Form
    {
        IClienteController clienteController;
        IVeiculoController veiculoController;
        public Menu()
        {
            InitializeComponent();
            clienteController = new ClienteController();
            veiculoController = new VeiculoController();
            AtualizarDados();
        }

        private void AtualizarDados()
        {
            labelLocacoesAtivas.Text = "0";
            labelTotalClientes.Text = clienteController.ObterTotal().ToString();
            labelVeiculosDisponiveis.Text = veiculoController.ObterDisponiveis().ToString();
        }


        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void locaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new ClientesListagemForm();
            form.ShowDialog();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ClientesCadastroForm();
            form.ShowDialog();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new VeiculoCadastroForm();
            form.ShowDialog();
        }

        private void veículosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new VeiculosListagemForm();
            form.ShowDialog();
        }

        private void novaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LocacoesCadastroForm();
            form.ShowDialog();
        }

        private void locaçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new LocacoesListagemForm();
            form.ShowDialog();
        }
    }
}
