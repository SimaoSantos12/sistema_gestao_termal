namespace Trabalho
{
    partial class realizarAtividade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(realizarAtividade));
            this.dsAtividadesRealizadas = new Trabalho.dsAtividadesRealizadas();
            this.atividadesRealizadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atividadesRealizadasTableAdapter = new Trabalho.dsAtividadesRealizadasTableAdapters.AtividadesRealizadasTableAdapter();
            this.tableAdapterManager = new Trabalho.dsAtividadesRealizadasTableAdapters.TableAdapterManager();
            this.atividadesRealizadasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.atividadesRealizadasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.atividadesRealizadasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsAtividadesRealizadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadesRealizadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadesRealizadasBindingNavigator)).BeginInit();
            this.atividadesRealizadasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atividadesRealizadasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dsAtividadesRealizadas
            // 
            this.dsAtividadesRealizadas.DataSetName = "dsAtividadesRealizadas";
            this.dsAtividadesRealizadas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // atividadesRealizadasBindingSource
            // 
            this.atividadesRealizadasBindingSource.DataMember = "AtividadesRealizadas";
            this.atividadesRealizadasBindingSource.DataSource = this.dsAtividadesRealizadas;
            // 
            // atividadesRealizadasTableAdapter
            // 
            this.atividadesRealizadasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AtividadesRealizadasTableAdapter = this.atividadesRealizadasTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Trabalho.dsAtividadesRealizadasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // atividadesRealizadasBindingNavigator
            // 
            this.atividadesRealizadasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.atividadesRealizadasBindingNavigator.BindingSource = this.atividadesRealizadasBindingSource;
            this.atividadesRealizadasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.atividadesRealizadasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.atividadesRealizadasBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.atividadesRealizadasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.atividadesRealizadasBindingNavigatorSaveItem});
            this.atividadesRealizadasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.atividadesRealizadasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.atividadesRealizadasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.atividadesRealizadasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.atividadesRealizadasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.atividadesRealizadasBindingNavigator.Name = "atividadesRealizadasBindingNavigator";
            this.atividadesRealizadasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.atividadesRealizadasBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.atividadesRealizadasBindingNavigator.TabIndex = 0;
            this.atividadesRealizadasBindingNavigator.Text = "bindingNavigator1";
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
            // atividadesRealizadasBindingNavigatorSaveItem
            // 
            this.atividadesRealizadasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.atividadesRealizadasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("atividadesRealizadasBindingNavigatorSaveItem.Image")));
            this.atividadesRealizadasBindingNavigatorSaveItem.Name = "atividadesRealizadasBindingNavigatorSaveItem";
            this.atividadesRealizadasBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.atividadesRealizadasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.atividadesRealizadasBindingNavigatorSaveItem.Click += new System.EventHandler(this.atividadesRealizadasBindingNavigatorSaveItem_Click);
            // 
            // atividadesRealizadasDataGridView
            // 
            this.atividadesRealizadasDataGridView.AutoGenerateColumns = false;
            this.atividadesRealizadasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atividadesRealizadasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.atividadesRealizadasDataGridView.DataSource = this.atividadesRealizadasBindingSource;
            this.atividadesRealizadasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.atividadesRealizadasDataGridView.Location = new System.Drawing.Point(0, 27);
            this.atividadesRealizadasDataGridView.Name = "atividadesRealizadasDataGridView";
            this.atividadesRealizadasDataGridView.RowHeadersWidth = 51;
            this.atividadesRealizadasDataGridView.RowTemplate.Height = 24;
            this.atividadesRealizadasDataGridView.Size = new System.Drawing.Size(800, 423);
            this.atividadesRealizadasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "dtHoraInicio";
            this.dataGridViewTextBoxColumn1.HeaderText = "dtHoraInicio";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dtHoraFim";
            this.dataGridViewTextBoxColumn2.HeaderText = "dtHoraFim";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PrecoAtividade";
            this.dataGridViewTextBoxColumn3.HeaderText = "PrecoAtividade";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "refidCliente";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdCliente";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "refIdAtividade";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdAtividade";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // realizarAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.atividadesRealizadasDataGridView);
            this.Controls.Add(this.atividadesRealizadasBindingNavigator);
            this.Name = "realizarAtividade";
            this.Text = "realizarAtividade";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.realizarAtividade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAtividadesRealizadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadesRealizadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadesRealizadasBindingNavigator)).EndInit();
            this.atividadesRealizadasBindingNavigator.ResumeLayout(false);
            this.atividadesRealizadasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atividadesRealizadasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsAtividadesRealizadas dsAtividadesRealizadas;
        private System.Windows.Forms.BindingSource atividadesRealizadasBindingSource;
        private dsAtividadesRealizadasTableAdapters.AtividadesRealizadasTableAdapter atividadesRealizadasTableAdapter;
        private dsAtividadesRealizadasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator atividadesRealizadasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton atividadesRealizadasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView atividadesRealizadasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}