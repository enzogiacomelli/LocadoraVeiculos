using LocadoraRepositorios.Controller;
using LocadoraRepositorios.Models;

namespace LocadoraViewForms
{
    public partial class VeiculoCadastroForm : Form
    {
        IFabricanteController fabricanteController;
        IVeiculoController veiculoController;

        public VeiculoCadastroForm()
        {
            InitializeComponent();
            fabricanteController = new FabricanteController();
            veiculoController = new VeiculoController();
        }

        private void VeiculoCadastroForm_Load(object sender, EventArgs e)
        {
            CarregarFabricantesComboBox();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var tipo = "";
            if (checkBoxEhCarro.Checked)
            {
                tipo = "Carro";
            }
            else if (checkBoxEhMoto.Checked)
            {
                tipo = "Moto";
            }
            var veiculo = new Veiculo();
            veiculo.Nome = textBoxNome.Text;
            veiculo.Placa = textBoxPlaca.Text;
            veiculo.Quilometragem = Convert.ToInt32(textBoxKm.Text);
            veiculo.ValorDiaria = Convert.ToDecimal(textBoxValorDiaria.Text);
            veiculo.Tipo = tipo;
            veiculo.Fabricante = (Fabricante)comboBoxFabricante.SelectedItem;
            veiculo.FabricanteId = veiculo.Fabricante.Id;

            veiculoController.Cadastrar(veiculo);
            Limpar();
            this.Close();
        }

        public void Limpar()
        {
            textBoxNome.Clear();
            checkBoxEhCarro.Checked = false;
            checkBoxEhMoto.Checked = false;
            textBoxPlaca.Clear();
            textBoxKm.Clear();
            textBoxValorDiaria.Clear();
            comboBoxFabricante.SelectedIndex = -1;
        }

        private void buttonNovaFabricante_Click(object sender, EventArgs e)
        {
            Form form = new FabricantesForm();
            form.ShowDialog();
        }

        private void CarregarFabricantesComboBox()
        {
            var fabricantes = fabricanteController.ObterTodos();
            comboBoxFabricante.Items.Clear();
            comboBoxFabricante.DisplayMember = "Nome";

            foreach (Fabricante fabricante in fabricantes)
            {
                comboBoxFabricante.Items.Add(fabricante);
            }
        }

        private void comboBoxFabricante_DropDown(object sender, EventArgs e)
        {
            CarregarFabricantesComboBox();
        }
    }
}
