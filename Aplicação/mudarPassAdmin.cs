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
    public partial class mudarPassAdmin : Form
    {
        //string username = "";
        bool existeFunc = false;

        public mudarPassAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            existeFunc = false;

            foreach (DataGridViewRow data in funcionariosDataGridView.Rows)
            {
                if (textBox3.Text.ToString() == data.Cells["username"].Value.ToString())
                {
                    existeFunc = true;
                }
            }

            if (existeFunc == false)
            {
                MessageBox.Show("O username está incorreto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // String de conexão com o SQL Server
                    string connectionString = "Data Source=LENOVO;Initial Catalog=Termas;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                    // Query SQL 
                    string query = "Update Funcionarios set Password=Username where Username='" + textBox3.Text.ToString()+"'";

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

                    MessageBox.Show("Mudança Efetuada!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Deu Erro");
                    Console.WriteLine(erro);
                }
                
            }
        }

        private void mudarPassAdmin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsFuncionarios.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.dsFuncionarios.Funcionarios);

        }
    }
}
