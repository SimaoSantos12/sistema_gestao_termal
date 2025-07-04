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
    public partial class tabelaAtividades : Form
    {
        public tabelaAtividades()
        {
            InitializeComponent();
        }

        private void tabelaAtividades_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsAtividade.Atividade'. Você pode movê-la ou removê-la conforme necessário.
            this.atividadeTableAdapter.Fill(this.dsAtividade.Atividade);


            if (Program.categoria.ToLower() == "func")
            {
                atividadeBindingNavigator.Visible = false;
                atividadeDataGridView.ReadOnly = true;
            }

        }

        private void atividadeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.atividadeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsAtividade);

        }
    }
}
