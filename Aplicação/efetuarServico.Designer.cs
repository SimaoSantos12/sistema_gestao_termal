namespace Trabalho
{
    partial class efetuarServico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(efetuarServico));
            this.dsRealizarServico = new Trabalho.dsRealizarServico();
            this.realizaServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.realizaServicoTableAdapter = new Trabalho.dsRealizarServicoTableAdapters.RealizaServicoTableAdapter();
            this.tableAdapterManager = new Trabalho.dsRealizarServicoTableAdapters.TableAdapterManager();
            this.realizaServicoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.realizaServicoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.realizaServicoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsRealizarServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realizaServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realizaServicoBindingNavigator)).BeginInit();
            this.realizaServicoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.realizaServicoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dsRealizarServico
            // 
            this.dsRealizarServico.DataSetName = "dsRealizarServico";
            this.dsRealizarServico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // realizaServicoBindingSource
            // 
            this.realizaServicoBindingSource.DataMember = "RealizaServico";
            this.realizaServicoBindingSource.DataSource = this.dsRealizarServico;
            // 
            // realizaServicoTableAdapter
            // 
            this.realizaServicoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RealizaServicoTableAdapter = this.realizaServicoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Trabalho.dsRealizarServicoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // realizaServicoBindingNavigator
            // 
            this.realizaServicoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.realizaServicoBindingNavigator.BindingSource = this.realizaServicoBindingSource;
            this.realizaServicoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.realizaServicoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.realizaServicoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.realizaServicoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.realizaServicoBindingNavigatorSaveItem});
            this.realizaServicoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.realizaServicoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.realizaServicoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.realizaServicoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.realizaServicoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.realizaServicoBindingNavigator.Name = "realizaServicoBindingNavigator";
            this.realizaServicoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.realizaServicoBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.realizaServicoBindingNavigator.TabIndex = 0;
            this.realizaServicoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover seguinte";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // realizaServicoBindingNavigatorSaveItem
            // 
            this.realizaServicoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.realizaServicoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("realizaServicoBindingNavigatorSaveItem.Image")));
            this.realizaServicoBindingNavigatorSaveItem.Name = "realizaServicoBindingNavigatorSaveItem";
            this.realizaServicoBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.realizaServicoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.realizaServicoBindingNavigatorSaveItem.Click += new System.EventHandler(this.realizaServicoBindingNavigatorSaveItem_Click);
            // 
            // realizaServicoDataGridView
            // 
            this.realizaServicoDataGridView.AutoGenerateColumns = false;
            this.realizaServicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.realizaServicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.IdFuncionario,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.realizaServicoDataGridView.DataSource = this.realizaServicoBindingSource;
            this.realizaServicoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.realizaServicoDataGridView.Location = new System.Drawing.Point(0, 31);
            this.realizaServicoDataGridView.Name = "realizaServicoDataGridView";
            this.realizaServicoDataGridView.RowHeadersWidth = 51;
            this.realizaServicoDataGridView.RowTemplate.Height = 24;
            this.realizaServicoDataGridView.Size = new System.Drawing.Size(800, 419);
            this.realizaServicoDataGridView.TabIndex = 1;
            this.realizaServicoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.realizaServicoDataGridView_CellContentClick);
            this.realizaServicoDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.realizaServicoDataGridView_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DataInicio";
            this.dataGridViewTextBoxColumn1.HeaderText = "DataInicio";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DataFim";
            this.dataGridViewTextBoxColumn2.HeaderText = "DataFim";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // IdFuncionario
            // 
            this.IdFuncionario.DataPropertyName = "refIdFunc";
            this.IdFuncionario.HeaderText = "IDFuncionario";
            this.IdFuncionario.MinimumWidth = 6;
            this.IdFuncionario.Name = "IdFuncionario";
            this.IdFuncionario.ReadOnly = true;
            this.IdFuncionario.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "refIdServico";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdServico";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "refIdCliente";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdCliente";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Preco";
            this.dataGridViewTextBoxColumn6.HeaderText = "Preco";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "refIdProduto";
            this.dataGridViewTextBoxColumn7.HeaderText = "refIdProduto";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // efetuarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.realizaServicoDataGridView);
            this.Controls.Add(this.realizaServicoBindingNavigator);
            this.Name = "efetuarServico";
            this.Text = "efetuarServico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.efetuarServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsRealizarServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realizaServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realizaServicoBindingNavigator)).EndInit();
            this.realizaServicoBindingNavigator.ResumeLayout(false);
            this.realizaServicoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.realizaServicoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsRealizarServico dsRealizarServico;
        private System.Windows.Forms.BindingSource realizaServicoBindingSource;
        private dsRealizarServicoTableAdapters.RealizaServicoTableAdapter realizaServicoTableAdapter;
        private dsRealizarServicoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator realizaServicoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton realizaServicoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView realizaServicoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}