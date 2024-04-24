using LocadoraRepositorios.Controller;
using LocadoraRepositorios.Models;

namespace LocadoraViewForms
{
    public partial class FabricantesForm : Form
    {
        private IFabricanteController controller;
        public FabricantesForm()
        {
            InitializeComponent();
            controller = new FabricanteController();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxFabricante.Text;
            var fabricante = new Fabricante();
            fabricante.Nome = nome;
            controller.Cadastrar(fabricante);
            textBoxFabricante.Clear();
            this.Close();
        }
    }
}
