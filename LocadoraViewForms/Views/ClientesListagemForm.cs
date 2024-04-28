using LocadoraRepositorios.Controller;
using LocadoraRepositorios.Models;

namespace LocadoraViewForms.Views
{
    public partial class ClientesListagemForm : Form
    {
        IClienteController clienteController;
        public ClientesListagemForm()
        {
            InitializeComponent();
            clienteController = new ClienteController();
            CarregaListagemClientes();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            var form = new ClientesCadastroForm();
            form.ShowDialog();
            CarregaListagemClientes();
        }


        public void CarregaListagemClientes()
        {
            dataGridViewClientes.Rows.Clear();
            var clientes = clienteController.ObterTodos();

            foreach (Cliente cliente in clientes)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewClientes.Rows[0].Clone();//cria uma row e clona a linha vazia do meu datagrid
                row.Cells[0].Value = cliente.Nome;
                row.Cells[1].Value = cliente.Documento;
                row.Cells[2].Value = cliente.Telefone;
                row.Cells[3].Value = cliente.Id;

                dataGridViewClientes.Rows.Add(row);
            }
        }

        private void ButtonAtualizarLista_Click(object sender, EventArgs e)
        {
            CarregaListagemClientes();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                var dialogResult = MessageBox.Show("Deseja continuar?", "Aviso!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var row = this.dataGridViewClientes.CurrentRow;
                    var id = Convert.ToInt32(row.Cells[3].Value);

                    clienteController.Apagar(id);

                    MessageBox.Show("Registro excluido com sucesso!");
                    CarregaListagemClientes();
                }
                else if (dialogResult == DialogResult.No) 
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha!", "Aviso!");
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edição");
        }
    }
}
