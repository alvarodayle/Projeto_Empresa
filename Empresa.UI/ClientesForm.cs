using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Empresa.Db;
using Empresa.Models;

namespace Empresa.UI.Windows
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void ExibirGrid()
        {
            listaDataGridView.Visible = true;
            listaDataGridView.Dock = DockStyle.Fill;
            fichaPanel.Visible = false;
            novoButton.Visible = true;
            alterarButton.Visible = true;
            excluirButton.Visible = true;
            voltarButton.Visible = false;
            confirmarAlteracaoButton.Visible = false;
            confirmarExclusaoButton.Visible = false;
            confirmarInclusaoButton.Visible = false;
            sairbutton.Visible = true;

            ClienteDb db = new ClienteDb();
            listaDataGridView.DataSource = db.Listar();
            listaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listaDataGridView.ReadOnly = false;
            listaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listaDataGridView.RowHeadersVisible = false;
            listaDataGridView.EnableHeadersVisualStyles = false;
            listaDataGridView.Columns["Id"].Width = 50;
        }

        private void ExibirFicha()
        {
            listaDataGridView.Visible = false;
            fichaPanel.Visible = true;
            fichaPanel.Dock = DockStyle.Fill;
            novoButton.Visible = false;
            alterarButton.Visible = false;
            excluirButton.Visible = false;
            confirmarAlteracaoButton.Visible = false;
            confirmarExclusaoButton.Visible = false;
            confirmarInclusaoButton.Visible = false;
            voltarButton.Visible = false;
            sairbutton.Visible = false;
        }

        private void LimparFicha()
        {
            idTextBox.Clear();
            nomeTextBox.Clear();
            emailTextBox.Clear();
            telefoneTextBox.Clear();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            ExibirGrid();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            LimparFicha();
            ExibirFicha();

            confirmarInclusaoButton.Visible = true;
            voltarButton.Visible = true;
        }


        private void confirmarInclusaoButton_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();

            cliente.id = Convert.ToInt32(idTextBox.Text);
            cliente.nome = nomeTextBox.Text;
            cliente.email = emailTextBox.Text;
            cliente.telefone = telefoneTextBox.Text;

            var db = new ClienteDb();

            db.Incluir(cliente);

            ExibirGrid();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            LimparFicha();

            var cliente = (Cliente)listaDataGridView.CurrentRow.DataBoundItem;

            idTextBox.Text = cliente.id.ToString();
            nomeTextBox.Text = cliente.nome;
            emailTextBox.Text = cliente.email;
            telefoneTextBox.Text = cliente.telefone;


            ExibirFicha();

            confirmarAlteracaoButton.Visible = true;
            voltarButton.Visible = true;
        }

        private void confirmarAlteracaoButton_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();

            cliente.id = Convert.ToInt32(idTextBox.Text);
            cliente.nome = nomeTextBox.Text;
            cliente.email = emailTextBox.Text;
            cliente.telefone = telefoneTextBox.Text;

            var db = new ClienteDb();

            db.Alterar(cliente);

            ExibirGrid();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            LimparFicha();

            var cliente = (Cliente)listaDataGridView.CurrentRow.DataBoundItem;

            idTextBox.Text = cliente.id.ToString();
            nomeTextBox.Text = cliente.nome;
            emailTextBox.Text = cliente.email;
            telefoneTextBox.Text = cliente.telefone;

            ExibirFicha();

            confirmarExclusaoButton.Visible = true;
            voltarButton.Visible = true;
        }

        private void confirmarExclusaoButton_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();

            cliente.id = Convert.ToInt32(idTextBox.Text);

            var db = new ClienteDb();

            db.Excluir(cliente);

            ExibirGrid();
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            ExibirGrid();
        }

        private void sairbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
