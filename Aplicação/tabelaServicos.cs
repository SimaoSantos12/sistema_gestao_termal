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
    public partial class TabelaServicos : Form
    {
        public TabelaServicos()
        {
            InitializeComponent();
        }

        private void servicosPrestadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicosPrestadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsServicos);

        }

        private void Servicos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsServicos.ServicosPrestados'. Você pode movê-la ou removê-la conforme necessário.
            this.servicosPrestadosTableAdapter.Fill(this.dsServicos.ServicosPrestados);
            
            if (Program.categoria.ToLower() == "func" || Program.categoria.ToLower() == "gestor")
            {
                servicosPrestadosBindingNavigator.Visible = false;
                servicosPrestadosDataGridView.ReadOnly = true;
            }

        }
    }
}
