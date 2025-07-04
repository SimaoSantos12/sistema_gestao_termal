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
    public partial class tabelaFornecedor : Form
    {
        public tabelaFornecedor()
        {
            InitializeComponent();
        }

        private void fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsFornecedor);

        }

        private void tabelaFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsFornecedor.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.dsFornecedor.Fornecedor);

            if (Program.categoria.ToLower() == "func" || Program.categoria.ToLower() == "gestor")
            {
                fornecedorBindingNavigator.Visible = false;
                fornecedorDataGridView.ReadOnly = true;
            }

        }
    }
}
