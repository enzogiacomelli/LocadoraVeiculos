using LocadoraRepositorios.Controller;
using LocadoraRepositorios.Models;

namespace LocadoraViewForms.Views
{
    public partial class ClientesCadastroForm : Form
    {
        ClienteController clienteController;

        public ClientesCadastroForm()
        {
            InitializeComponent();
            clienteController = new ClienteController();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if(textBoxNome.Text == string.Empty || textBoxDocumento.Text == string.Empty || textBoxTelefone.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos corretamente!", "Aviso!");
            }else
            {
                var cliente = new Cliente();
                cliente.Nome = textBoxNome.Text;
                cliente.Documento = textBoxDocumento.Text;
                cliente.Telefone = textBoxTelefone.Text;

                clienteController.Cadastrar(cliente);
                MessageBox.Show("Cliente cadastrado!", "Aviso!");
                this.Close();
            }
        }

    }
}
