namespace Trabalho
{
    partial class TabelaServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabelaServicos));
            this.dsServicos = new Trabalho.dsServicos();
            this.servicosPrestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicosPrestadosTableAdapter = new Trabalho.dsServicosTableAdapters.ServicosPrestadosTableAdapter();
            this.tableAdapterManager = new Trabalho.dsServicosTableAdapters.TableAdapterManager();
            this.servicosPrestadosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.servicosPrestadosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.servicosPrestadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosPrestadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosPrestadosBindingNavigator)).BeginInit();
            this.servicosPrestadosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicosPrestadosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dsServicos
            // 
            this.dsServicos.DataSetName = "dsServicos";
            this.dsServicos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicosPrestadosBindingSource
            // 
            this.servicosPrestadosBindingSource.DataMember = "ServicosPrestados";
            this.servicosPrestadosBindingSource.DataSource = this.dsServicos;
            // 
            // servicosPrestadosTableAdapter
            // 
            this.servicosPrestadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ServicosPrestadosTableAdapter = this.servicosPrestadosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Trabalho.dsServicosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // servicosPrestadosBindingNavigator
            // 
            this.servicosPrestadosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.servicosPrestadosBindingNavigator.BindingSource = this.servicosPrestadosBindingSource;
            this.servicosPrestadosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.servicosPrestadosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.servicosPrestadosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.servicosPrestadosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.servicosPrestadosBindingNavigatorSaveItem});
            this.servicosPrestadosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.servicosPrestadosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.servicosPrestadosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.servicosPrestadosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.servicosPrestadosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.servicosPrestadosBindingNavigator.Name = "servicosPrestadosBindingNavigator";
            this.servicosPrestadosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.servicosPrestadosBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.servicosPrestadosBindingNavigator.TabIndex = 0;
            this.servicosPrestadosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover seguinte";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // servicosPrestadosBindingNavigatorSaveItem
            // 
            this.servicosPrestadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.servicosPrestadosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("servicosPrestadosBindingNavigatorSaveItem.Image")));
            this.servicosPrestadosBindingNavigatorSaveItem.Name = "servicosPrestadosBindingNavigatorSaveItem";
            this.servicosPrestadosBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.servicosPrestadosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.servicosPrestadosBindingNavigatorSaveItem.Click += new System.EventHandler(this.servicosPrestadosBindingNavigatorSaveItem_Click);
            // 
            // servicosPrestadosDataGridView
            // 
            this.servicosPrestadosDataGridView.AutoGenerateColumns = false;
            this.servicosPrestadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicosPrestadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.servicosPrestadosDataGridView.DataSource = this.servicosPrestadosBindingSource;
            this.servicosPrestadosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.servicosPrestadosDataGridView.Location = new System.Drawing.Point(0, 27);
            this.servicosPrestadosDataGridView.Name = "servicosPrestadosDataGridView";
            this.servicosPrestadosDataGridView.RowHeadersWidth = 51;
            this.servicosPrestadosDataGridView.RowTemplate.Height = 24;
            this.servicosPrestadosDataGridView.Size = new System.Drawing.Size(800, 423);
            this.servicosPrestadosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdServico";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdServico";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TipoDeServico";
            this.dataGridViewTextBoxColumn2.HeaderText = "TipoDeServico";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // TabelaServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.servicosPrestadosDataGridView);
            this.Controls.Add(this.servicosPrestadosBindingNavigator);
            this.Name = "TabelaServicos";
            this.Text = "Serviços";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Servicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosPrestadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosPrestadosBindingNavigator)).EndInit();
            this.servicosPrestadosBindingNavigator.ResumeLayout(false);
            this.servicosPrestadosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicosPrestadosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsServicos dsServicos;
        private System.Windows.Forms.BindingSource servicosPrestadosBindingSource;
        private dsServicosTableAdapters.ServicosPrestadosTableAdapter servicosPrestadosTableAdapter;
        private dsServicosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator servicosPrestadosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton servicosPrestadosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView servicosPrestadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}