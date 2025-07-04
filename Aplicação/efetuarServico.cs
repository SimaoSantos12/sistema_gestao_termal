using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class efetuarServico : Form
    {
        string idProduto = "";
        public efetuarServico()
        {
            InitializeComponent();
        }

        private void realizaServicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            realizaServicoDataGridView.CurrentRow.Cells[2].Value = Program.idFuncionario.ToString();

            try
            {
                this.Validate();
                this.realizaServicoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dsRealizarServico);

                // String de conexão com o SQL Server
                string connectionString = "Data Source=LENOVO;Initial Catalog=Termas;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                // Query SQL parametrizada
                string query = "Update Produtos set QuantidadeStock=QuantidadeStock-1 where IdProdutos=" + idProduto.ToString();

                // Usar a conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Criar o comando SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        // Abrir a conexão
                        connection.Open();

                        command.ExecuteNonQuery();

                        connection.Close();
                       

                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Deu Erro");
                Console.WriteLine(erro);
            }

        }

        private void efetuarServico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsRealizarServico.RealizaServico'. Você pode movê-la ou removê-la conforme necessário.
            this.realizaServicoTableAdapter.Fill(this.dsRealizarServico.RealizaServico);
            if (Program.categoria.ToLower() == "gestor")
            {
                realizaServicoBindingNavigator.Visible = false;
                realizaServicoDataGridView.ReadOnly = true;
            }

        }

        private void realizaServicoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void realizaServicoDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verifique se a coluna editada é a coluna desejada (opcional)
                if (e.ColumnIndex == 6)
                {
                    // Obtenha o valor da célula da coluna 6 na linha editada
                    idProduto = realizaServicoDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                // Trate quaisquer exceções que possam ocorrer
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
