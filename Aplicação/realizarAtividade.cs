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
    public partial class realizarAtividade : Form
    {
        public realizarAtividade()
        {
            InitializeComponent();
        }

        private void atividadesRealizadasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.atividadesRealizadasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsAtividadesRealizadas);

        }

        private void realizarAtividade_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsAtividadesRealizadas.AtividadesRealizadas'. Você pode movê-la ou removê-la conforme necessário.
            this.atividadesRealizadasTableAdapter.Fill(this.dsAtividadesRealizadas.AtividadesRealizadas);
            if (Program.categoria.ToLower() == "func")
            {
                atividadesRealizadasBindingNavigator.Visible = false;
                atividadesRealizadasDataGridView.ReadOnly = true;
            }
        }
    }
}
