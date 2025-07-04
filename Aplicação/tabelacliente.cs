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
    public partial class TabelaCliente : Form
    {
        public TabelaCliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.termasDataSet);

        }

        private void TabelaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'termasDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.termasDataSet.Cliente);

            if (Program.categoria.ToLower() == "func" || Program.categoria.ToLower() == "gestor")
            {
                clienteBindingNavigator.Visible = false;
                clienteDataGridView.ReadOnly = true;
            }

        }
    }
}
