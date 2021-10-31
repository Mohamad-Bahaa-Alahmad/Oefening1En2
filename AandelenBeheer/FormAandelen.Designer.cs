namespace AandelenBeheer
{
    partial class FormAandelen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAandelen));
            System.Windows.Forms.Label aandeelIdLabel;
            System.Windows.Forms.Label symboolLabel;
            System.Windows.Forms.Label naamLabel;
            this.aandelenBeheerDataSet = new AandelenBeheer.AandelenBeheerDataSet();
            this.aandelenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aandelenTableAdapter = new AandelenBeheer.AandelenBeheerDataSetTableAdapters.AandelenTableAdapter();
            this.tableAdapterManager = new AandelenBeheer.AandelenBeheerDataSetTableAdapters.TableAdapterManager();
            this.aandelenBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.aandelenBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.aandeelIdLabel1 = new System.Windows.Forms.Label();
            this.symboolTextBox = new System.Windows.Forms.TextBox();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.transactiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactiesTableAdapter = new AandelenBeheer.AandelenBeheerDataSetTableAdapters.TransactiesTableAdapter();
            this.transactiesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aandeelIdLabel = new System.Windows.Forms.Label();
            symboolLabel = new System.Windows.Forms.Label();
            naamLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aandelenBeheerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aandelenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aandelenBindingNavigator)).BeginInit();
            this.aandelenBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aandelenBeheerDataSet
            // 
            this.aandelenBeheerDataSet.DataSetName = "AandelenBeheerDataSet";
            this.aandelenBeheerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aandelenBindingSource
            // 
            this.aandelenBindingSource.DataMember = "Aandelen";
            this.aandelenBindingSource.DataSource = this.aandelenBeheerDataSet;
            // 
            // aandelenTableAdapter
            // 
            this.aandelenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AandelenTableAdapter = this.aandelenTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TransactiesTableAdapter = this.transactiesTableAdapter;
            this.tableAdapterManager.UpdateOrder = AandelenBeheer.AandelenBeheerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aandelenBindingNavigator
            // 
            this.aandelenBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aandelenBindingNavigator.BindingSource = this.aandelenBindingSource;
            this.aandelenBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aandelenBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aandelenBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.aandelenBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aandelenBindingNavigatorSaveItem});
            this.aandelenBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aandelenBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aandelenBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aandelenBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aandelenBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aandelenBindingNavigator.Name = "aandelenBindingNavigator";
            this.aandelenBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aandelenBindingNavigator.Size = new System.Drawing.Size(852, 27);
            this.aandelenBindingNavigator.TabIndex = 0;
            this.aandelenBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
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
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // aandelenBindingNavigatorSaveItem
            // 
            this.aandelenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aandelenBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aandelenBindingNavigatorSaveItem.Image")));
            this.aandelenBindingNavigatorSaveItem.Name = "aandelenBindingNavigatorSaveItem";
            this.aandelenBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.aandelenBindingNavigatorSaveItem.Text = "Save Data";
            this.aandelenBindingNavigatorSaveItem.Click += new System.EventHandler(this.aandelenBindingNavigatorSaveItem_Click);
            // 
            // aandeelIdLabel
            // 
            aandeelIdLabel.AutoSize = true;
            aandeelIdLabel.Location = new System.Drawing.Point(12, 29);
            aandeelIdLabel.Name = "aandeelIdLabel";
            aandeelIdLabel.Size = new System.Drawing.Size(75, 16);
            aandeelIdLabel.TabIndex = 1;
            aandeelIdLabel.Text = "Aandeel Id:";
            // 
            // aandeelIdLabel1
            // 
            this.aandeelIdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aandelenBindingSource, "AandeelId", true));
            this.aandeelIdLabel1.Location = new System.Drawing.Point(93, 29);
            this.aandeelIdLabel1.Name = "aandeelIdLabel1";
            this.aandeelIdLabel1.Size = new System.Drawing.Size(100, 23);
            this.aandeelIdLabel1.TabIndex = 2;
            this.aandeelIdLabel1.Text = "label1";
            // 
            // symboolLabel
            // 
            symboolLabel.AutoSize = true;
            symboolLabel.Location = new System.Drawing.Point(12, 58);
            symboolLabel.Name = "symboolLabel";
            symboolLabel.Size = new System.Drawing.Size(64, 16);
            symboolLabel.TabIndex = 3;
            symboolLabel.Text = "Symbool:";
            // 
            // symboolTextBox
            // 
            this.symboolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aandelenBindingSource, "Symbool", true));
            this.symboolTextBox.Location = new System.Drawing.Point(93, 55);
            this.symboolTextBox.Name = "symboolTextBox";
            this.symboolTextBox.Size = new System.Drawing.Size(100, 22);
            this.symboolTextBox.TabIndex = 4;
            // 
            // naamLabel
            // 
            naamLabel.AutoSize = true;
            naamLabel.Location = new System.Drawing.Point(12, 86);
            naamLabel.Name = "naamLabel";
            naamLabel.Size = new System.Drawing.Size(47, 16);
            naamLabel.TabIndex = 5;
            naamLabel.Text = "Naam:";
            // 
            // naamTextBox
            // 
            this.naamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aandelenBindingSource, "Naam", true));
            this.naamTextBox.Location = new System.Drawing.Point(93, 83);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(100, 22);
            this.naamTextBox.TabIndex = 6;
            // 
            // transactiesBindingSource
            // 
            this.transactiesBindingSource.DataMember = "FK_AandeelId";
            this.transactiesBindingSource.DataSource = this.aandelenBindingSource;
            // 
            // transactiesTableAdapter
            // 
            this.transactiesTableAdapter.ClearBeforeFill = true;
            // 
            // transactiesDataGridView
            // 
            this.transactiesDataGridView.AllowUserToAddRows = false;
            this.transactiesDataGridView.AllowUserToDeleteRows = false;
            this.transactiesDataGridView.AutoGenerateColumns = false;
            this.transactiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.transactiesDataGridView.DataSource = this.transactiesBindingSource;
            this.transactiesDataGridView.Location = new System.Drawing.Point(12, 111);
            this.transactiesDataGridView.Name = "transactiesDataGridView";
            this.transactiesDataGridView.ReadOnly = true;
            this.transactiesDataGridView.RowHeadersWidth = 51;
            this.transactiesDataGridView.RowTemplate.Height = 24;
            this.transactiesDataGridView.Size = new System.Drawing.Size(808, 220);
            this.transactiesDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TransactieId";
            this.dataGridViewTextBoxColumn1.HeaderText = "TransactieId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AandeelId";
            this.dataGridViewTextBoxColumn2.HeaderText = "AandeelId";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AantalGekocht ";
            this.dataGridViewTextBoxColumn3.HeaderText = "AantalGekocht ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AantalVerkocht";
            this.dataGridViewTextBoxColumn4.HeaderText = "AantalVerkocht";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Koers";
            this.dataGridViewTextBoxColumn5.HeaderText = "Koers";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TransactieDatum";
            this.dataGridViewTextBoxColumn6.HeaderText = "TransactieDatum";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // FormAandelen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 403);
            this.Controls.Add(this.transactiesDataGridView);
            this.Controls.Add(aandeelIdLabel);
            this.Controls.Add(this.aandeelIdLabel1);
            this.Controls.Add(symboolLabel);
            this.Controls.Add(this.symboolTextBox);
            this.Controls.Add(naamLabel);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(this.aandelenBindingNavigator);
            this.Name = "FormAandelen";
            this.Text = "Aandelen";
            this.Load += new System.EventHandler(this.FormAandelen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aandelenBeheerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aandelenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aandelenBindingNavigator)).EndInit();
            this.aandelenBindingNavigator.ResumeLayout(false);
            this.aandelenBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AandelenBeheerDataSet aandelenBeheerDataSet;
        private System.Windows.Forms.BindingSource aandelenBindingSource;
        private AandelenBeheerDataSetTableAdapters.AandelenTableAdapter aandelenTableAdapter;
        private AandelenBeheerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aandelenBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton aandelenBindingNavigatorSaveItem;
        private AandelenBeheerDataSetTableAdapters.TransactiesTableAdapter transactiesTableAdapter;
        private System.Windows.Forms.Label aandeelIdLabel1;
        private System.Windows.Forms.TextBox symboolTextBox;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.BindingSource transactiesBindingSource;
        private System.Windows.Forms.DataGridView transactiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

