using System.Configuration;
using System.Text;

namespace Tarefa2
{
    public partial class CadastroClientes : Form
    {
        private string? UF;
        public CadastroClientes()
        {
            InitializeComponent();
            UF = ConfigurationManager.AppSettings["UF"];
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Favor inserir o nome do cliente.");
                return;
            }


            if (string.IsNullOrEmpty(txtCPF.Text.Replace("_", "").Replace(".", "").Replace("-", "")))
            {
                MessageBox.Show("Favor inserir o CPF do cliente.");
                return;
            }

            if (UF == "PR" && DateTime.Now.AddYears(-18) < dtNascimento.Value)
            {
                MessageBox.Show("Não é permitido o cadastro de pessoas menores de 18 anos do estado do Paraná.");
                return;
            }

            if (UF == "SC" && string.IsNullOrEmpty(txtRG.Text))
            {
                MessageBox.Show("Favor inserir o RG do cliente.");
                return;
            }

            string rg = UF == "SC" ? txtRG.Text : "N/A";

            StringBuilder sbTelefones = new StringBuilder();

            for (int i = 0; i < dgvTelefonesCadastrados.RowCount; i++)
            {
                sbTelefones.AppendLine(dgvTelefonesCadastrados.Rows[i].Cells[0].Value.ToString());
            }

            dgvClientesCadastrados.Rows.Add(txtNome.Text, txtCPF.Text, UF, dtNascimento.Value.ToShortDateString(),
                DateTime.Now.ToShortDateString(), sbTelefones.ToString(), rg);

            txtNome.Clear();
            txtCPF.Clear();
            dtNascimento.Value = DateTime.Now;
            txtRG.Clear();
            dgvTelefonesCadastrados.Rows.Clear();
        }

        private void CadastroClientes_Load(object sender, EventArgs e)
        {
            lbRG.Visible = UF == "SC";
            txtRG.Visible = UF == "SC";
        }

        private void btnAddTelefone_Click(object sender, EventArgs e)
        {
            dgvTelefonesCadastrados.Rows.Add(txtTelefone.Text);
            txtTelefone.Clear();
        }
    }
}