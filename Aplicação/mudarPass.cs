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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabalho
{
    public partial class mudarPass : Form
    {
        bool passigual = false;
        public mudarPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passigual = false;

            foreach (DataGridViewRow data in funcionariosDataGridView.Rows)
            {
                if (textBox1.Text.ToString() == textBox2.Text.ToString())
                {
                    passigual = true;
                }
            }

            if (passigual == false)
            {
                MessageBox.Show("As passwords não correspondem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // String de conexão com o SQL Server
                    string connectionString = "Data Source=LENOVO;Initial Catalog=Termas;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                    // Query SQL 

                    Console.WriteLine(Program.nomeUtilizador);
                    Console.WriteLine(textBox1.Text.ToString());
                    string query = "UPDATE Funcionarios SET Password='" + textBox1.Text.ToString() + "' WHERE Username='" + Program.nomeUtilizador + "'";


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

        private void mudarPass_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsFuncionarios.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.dsFuncionarios.Funcionarios);

        }
    }
}
