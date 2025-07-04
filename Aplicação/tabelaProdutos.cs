﻿using System;
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
    public partial class tabelaProdutos : Form
    {
        public tabelaProdutos()
        {
            InitializeComponent();
        }

        private void produtosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.termasDataSet1);

        }

        private void tabelaProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'termasDataSet1.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.termasDataSet1.Produtos);
            
            if (Program.categoria.ToLower() == "func" || Program.categoria.ToLower() == "gestor")
            {
                produtosBindingNavigator.Visible = false;
                produtosDataGridView.ReadOnly = true;
            }

        }
    }
}
