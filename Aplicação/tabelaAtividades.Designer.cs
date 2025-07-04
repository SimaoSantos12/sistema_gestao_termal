namespace Trabalho
{
    partial class tabelaAtividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabelaAtividades));
            this.dsAtividade = new Trabalho.dsAtividade();
            this.atividadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atividadeTableAdapter = new Trabalho.dsAtividadeTableAdapters.AtividadeTableAdapter();
            this.tableAdapterManager = new Trabalho.dsAtividadeTableAdapters.TableAdapterManager();
            this.atividadeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.atividadeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.atividadeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsAtividade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingNavigator)).BeginInit();
            this.atividadeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dsAtividade
            // 
            this.dsAtividade.DataSetName = "dsAtividade";
            this.dsAtividade.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // atividadeBindingSource
            // 
            this.atividadeBindingSource.DataMember = "Atividade";
            this.atividadeBindingSource.DataSource = this.dsAtividade;
            // 
            // atividadeTableAdapter
            // 
            this.atividadeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AtividadeTableAdapter = this.atividadeTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Trabalho.dsAtividadeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // atividadeBindingNavigator
            // 
            this.atividadeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.atividadeBindingNavigator.BindingSource = this.atividadeBindingSource;
            this.atividadeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.atividadeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.atividadeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.atividadeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.atividadeBindingNavigatorSaveItem});
            this.atividadeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.atividadeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.atividadeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.atividadeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.atividadeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.atividadeBindingNavigator.Name = "atividadeBindingNavigator";
            this.atividadeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.atividadeBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.atividadeBindingNavigator.TabIndex = 0;
            this.atividadeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 20);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // atividadeBindingNavigatorSaveItem
            // 
            this.atividadeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.atividadeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("atividadeBindingNavigatorSaveItem.Image")));
            this.atividadeBindingNavigatorSaveItem.Name = "atividadeBindingNavigatorSaveItem";
            this.atividadeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.atividadeBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.atividadeBindingNavigatorSaveItem.Click += new System.EventHandler(this.atividadeBindingNavigatorSaveItem_Click);
            // 
            // atividadeDataGridView
            // 
            this.atividadeDataGridView.AutoGenerateColumns = false;
            this.atividadeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atividadeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.atividadeDataGridView.DataSource = this.atividadeBindingSource;
            this.atividadeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.atividadeDataGridView.Location = new System.Drawing.Point(0, 27);
            this.atividadeDataGridView.Name = "atividadeDataGridView";
            this.atividadeDataGridView.RowHeadersWidth = 51;
            this.atividadeDataGridView.RowTemplate.Height = 24;
            this.atividadeDataGridView.Size = new System.Drawing.Size(800, 423);
            this.atividadeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdAtividade";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdAtividade";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DescricaoAtividade";
            this.dataGridViewTextBoxColumn2.HeaderText = "DescricaoAtividade";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // tabelaAtividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.atividadeDataGridView);
            this.Controls.Add(this.atividadeBindingNavigator);
            this.Name = "tabelaAtividades";
            this.Text = "tabelaAtividades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tabelaAtividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAtividade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingNavigator)).EndInit();
            this.atividadeBindingNavigator.ResumeLayout(false);
            this.atividadeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsAtividade dsAtividade;
        private System.Windows.Forms.BindingSource atividadeBindingSource;
        private dsAtividadeTableAdapters.AtividadeTableAdapter atividadeTableAdapter;
        private dsAtividadeTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator atividadeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton atividadeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView atividadeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}