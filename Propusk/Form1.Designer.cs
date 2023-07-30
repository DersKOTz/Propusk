namespace Propusk
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.propuskDataSet = new Propusk.PropuskDataSet();
            this.group_dbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.group_dbTableAdapter = new Propusk.PropuskDataSetTableAdapters.group_dbTableAdapter();
            this.tableAdapterManager = new Propusk.PropuskDataSetTableAdapters.TableAdapterManager();
            this.group_dbBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.group_dbBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.group_dbDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.propuskDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_dbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_dbBindingNavigator)).BeginInit();
            this.group_dbBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group_dbDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // propuskDataSet
            // 
            this.propuskDataSet.DataSetName = "PropuskDataSet";
            this.propuskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // group_dbBindingSource
            // 
            this.group_dbBindingSource.DataMember = "group_db";
            this.group_dbBindingSource.DataSource = this.propuskDataSet;
            // 
            // group_dbTableAdapter
            // 
            this.group_dbTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.group_dbTableAdapter = this.group_dbTableAdapter;
            this.tableAdapterManager.UpdateOrder = Propusk.PropuskDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // group_dbBindingNavigator
            // 
            this.group_dbBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.group_dbBindingNavigator.BindingSource = this.group_dbBindingSource;
            this.group_dbBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.group_dbBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.group_dbBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.group_dbBindingNavigatorSaveItem});
            this.group_dbBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.group_dbBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.group_dbBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.group_dbBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.group_dbBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.group_dbBindingNavigator.Name = "group_dbBindingNavigator";
            this.group_dbBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.group_dbBindingNavigator.Size = new System.Drawing.Size(448, 25);
            this.group_dbBindingNavigator.TabIndex = 0;
            this.group_dbBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // group_dbBindingNavigatorSaveItem
            // 
            this.group_dbBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.group_dbBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("group_dbBindingNavigatorSaveItem.Image")));
            this.group_dbBindingNavigatorSaveItem.Name = "group_dbBindingNavigatorSaveItem";
            this.group_dbBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.group_dbBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.group_dbBindingNavigatorSaveItem.Click += new System.EventHandler(this.group_dbBindingNavigatorSaveItem_Click);
            // 
            // group_dbDataGridView
            // 
            this.group_dbDataGridView.AllowUserToAddRows = false;
            this.group_dbDataGridView.AllowUserToDeleteRows = false;
            this.group_dbDataGridView.AllowUserToResizeColumns = false;
            this.group_dbDataGridView.AllowUserToResizeRows = false;
            this.group_dbDataGridView.AutoGenerateColumns = false;
            this.group_dbDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.group_dbDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.group_dbDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.group_dbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.group_dbDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.group_dbDataGridView.DataSource = this.group_dbBindingSource;
            this.group_dbDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.group_dbDataGridView.Location = new System.Drawing.Point(179, 66);
            this.group_dbDataGridView.Name = "group_dbDataGridView";
            this.group_dbDataGridView.RowHeadersVisible = false;
            this.group_dbDataGridView.Size = new System.Drawing.Size(204, 298);
            this.group_dbDataGridView.TabIndex = 1;
            this.group_dbDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.group_dbDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Группы:";
            this.dataGridViewTextBoxColumn1.HeaderText = "Группы:";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Пароль:";
            this.dataGridViewTextBoxColumn2.HeaderText = "Пароль:";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(411, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 34);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.group_dbDataGridView);
            this.Controls.Add(this.group_dbBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.propuskDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_dbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_dbBindingNavigator)).EndInit();
            this.group_dbBindingNavigator.ResumeLayout(false);
            this.group_dbBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group_dbDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PropuskDataSet propuskDataSet;
        private System.Windows.Forms.BindingSource group_dbBindingSource;
        private PropuskDataSetTableAdapters.group_dbTableAdapter group_dbTableAdapter;
        private PropuskDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator group_dbBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton group_dbBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView group_dbDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
    }
}

