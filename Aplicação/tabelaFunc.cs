using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class tabelaFunc : Form
    {

        int numeroAleatorio = 0;
        string username = "", nome="";

        public tabelaFunc()
        {
            InitializeComponent();
        }

        private void funcionariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();

                // Gera um número inteiro aleatório entre 10000 (inclusivo) e 99999 (exclusivo)
                numeroAleatorio = random.Next(10000, 99999);
                username = nome + numeroAleatorio.ToString();

                funcionariosDataGridView.CurrentRow.Cells[3].Value = username;
                funcionariosDataGridView.CurrentRow.Cells[4].Value = username;

                this.Validate();
                this.funcionariosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dsFuncionarios);
            }
            catch (Exception erro) 
            { 
                Console.WriteLine(erro);
            }

        }

        private void tabelaFunc_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsFuncionarios.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.dsFuncionarios.Funcionarios);

            if (Program.categoria.ToLower()=="func" || Program.categoria.ToLower() == "gestor")
            {
                funcionariosBindingNavigator.Visible = false;
                funcionariosDataGridView.ReadOnly = true;
            }

        }

        private void funcionariosDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verifique se a coluna editada é a coluna desejada (opcional)
                if (e.ColumnIndex == 1)
                {
                    // Obtenha o valor da célula da coluna 6 na linha editada
                    nome = funcionariosDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
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
