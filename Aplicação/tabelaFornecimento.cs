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
    public partial class tabelaFornecimento : Form
    {
        string idproduto = "";
        string quantidade = "";

        public tabelaFornecimento()
        {
            InitializeComponent();
        }

        private void forneceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            try
            { 
            this.Validate();
            this.forneceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsFornecimento);

            // String de conexão com o SQL Server
            string connectionString = "Data Source=LENOVO;Initial Catalog=Termas;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            // Query SQL parametrizada
            string query = "Update Produtos set QuantidadeStock=QuantidadeStock+"+quantidade+" where IdProdutos=" + idproduto.ToString();

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

        private void tabelaFornecimento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsFornecimento.Fornece'. Você pode movê-la ou removê-la conforme necessário.
            this.forneceTableAdapter.Fill(this.dsFornecimento.Fornece);
            if (Program.categoria.ToLower() == "func" || Program.categoria.ToLower() == "gestor")
            {
                forneceBindingNavigator.Visible = false;
                forneceDataGridView.ReadOnly = true;
            }

        }

        private void forneceDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verifique se a coluna editada é a coluna desejada (opcional)
                if (e.ColumnIndex == 2)
                {
                    // Obtenha o valor da célula da coluna 6 na linha editada
                    idproduto = forneceDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
                if (e.ColumnIndex == 0)
                {
                    // Obtenha o valor da célula da coluna 6 na linha editada
                    quantidade = forneceDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
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
