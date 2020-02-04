namespace MongoDB_Base
{
    partial class Form_NachislSumma
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NachislSumma));
            this.BNNachislSumma = new System.Windows.Forms.BindingNavigator(this.components);
            this.BSNachislSumma = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripBupdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelFilter = new System.Windows.Forms.ToolStripLabel();
            this.CBFilter = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBoxFilter = new System.Windows.Forms.ToolStripTextBox();
            this.BMain = new System.Windows.Forms.Button();
            this.DataNachislSumma = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAbonent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BNNachislSumma)).BeginInit();
            this.BNNachislSumma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSNachislSumma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataNachislSumma)).BeginInit();
            this.SuspendLayout();
            // 
            // BNNachislSumma
            // 
            this.BNNachislSumma.AddNewItem = null;
            this.BNNachislSumma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BNNachislSumma.BindingSource = this.BSNachislSumma;
            this.BNNachislSumma.CountItem = this.bindingNavigatorCountItem;
            this.BNNachislSumma.DeleteItem = this.bindingNavigatorMoveNextItem;
            this.BNNachislSumma.Dock = System.Windows.Forms.DockStyle.None;
            this.BNNachislSumma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButtonAdd,
            this.toolStripBupdate,
            this.toolStripButtonDelete,
            this.toolStripLabelFilter,
            this.CBFilter,
            this.toolStripTextBoxFilter});
            this.BNNachislSumma.Location = new System.Drawing.Point(162, 40);
            this.BNNachislSumma.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BNNachislSumma.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BNNachislSumma.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BNNachislSumma.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BNNachislSumma.Name = "BNNachislSumma";
            this.BNNachislSumma.PositionItem = this.bindingNavigatorPositionItem;
            this.BNNachislSumma.Size = new System.Drawing.Size(619, 25);
            this.BNNachislSumma.TabIndex = 23;
            this.BNNachislSumma.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd.Text = "toolStripButtonAdd";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripBupdate
            // 
            this.toolStripBupdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBupdate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBupdate.Image")));
            this.toolStripBupdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBupdate.Name = "toolStripBupdate";
            this.toolStripBupdate.Size = new System.Drawing.Size(23, 22);
            this.toolStripBupdate.Text = "toolStripButton2";
            this.toolStripBupdate.Click += new System.EventHandler(this.toolStripBupdate_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDelete.Text = "Удаление";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripLabelFilter
            // 
            this.toolStripLabelFilter.Name = "toolStripLabelFilter";
            this.toolStripLabelFilter.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabelFilter.Text = "Фильтрация:";
            // 
            // CBFilter
            // 
            this.CBFilter.AutoCompleteCustomSource.AddRange(new string[] {
            "Номер",
            "Название"});
            this.CBFilter.Items.AddRange(new object[] {
            "Номер",
            "ФИО абонента",
            "Услуга",
            "Сумма",
            "Месяц",
            "Год"});
            this.CBFilter.Name = "CBFilter";
            this.CBFilter.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripTextBoxFilter
            // 
            this.toolStripTextBoxFilter.Name = "toolStripTextBoxFilter";
            this.toolStripTextBoxFilter.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxFilter.TextChanged += new System.EventHandler(this.toolStripTextBoxFilter_TextChanged);
            // 
            // BMain
            // 
            this.BMain.Image = ((System.Drawing.Image)(resources.GetObject("BMain.Image")));
            this.BMain.Location = new System.Drawing.Point(12, 8);
            this.BMain.Name = "BMain";
            this.BMain.Size = new System.Drawing.Size(70, 66);
            this.BMain.TabIndex = 22;
            this.BMain.UseVisualStyleBackColor = true;
            this.BMain.Click += new System.EventHandler(this.BMain_Click);
            // 
            // DataNachislSumma
            // 
            this.DataNachislSumma.AccessibleName = "";
            this.DataNachislSumma.AllowUserToAddRows = false;
            this.DataNachislSumma.AllowUserToDeleteRows = false;
            this.DataNachislSumma.AllowUserToOrderColumns = true;
            this.DataNachislSumma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataNachislSumma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataNachislSumma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.Column_id,
            this.ColumnAbonent,
            this.ColumnService,
            this.ColumnSum,
            this.ColumnMonth,
            this.ColumnYear});
            this.DataNachislSumma.Location = new System.Drawing.Point(12, 80);
            this.DataNachislSumma.Name = "DataNachislSumma";
            this.DataNachislSumma.Size = new System.Drawing.Size(777, 283);
            this.DataNachislSumma.TabIndex = 21;
            this.DataNachislSumma.Tag = "";
            this.DataNachislSumma.UseWaitCursor = true;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "Id";
            this.ColumnId.HeaderText = "Номер";
            this.ColumnId.Name = "ColumnId";
            // 
            // Column_id
            // 
            this.Column_id.DataPropertyName = "_id";
            this.Column_id.HeaderText = "_id";
            this.Column_id.Name = "Column_id";
            this.Column_id.Visible = false;
            // 
            // ColumnAbonent
            // 
            this.ColumnAbonent.DataPropertyName = "AccountCD";
            this.ColumnAbonent.HeaderText = "ФИО абонента";
            this.ColumnAbonent.Name = "ColumnAbonent";
            // 
            // ColumnService
            // 
            this.ColumnService.DataPropertyName = "ServiceCD";
            this.ColumnService.HeaderText = "Услуга";
            this.ColumnService.Name = "ColumnService";
            // 
            // ColumnSum
            // 
            this.ColumnSum.DataPropertyName = "NachislSum";
            this.ColumnSum.HeaderText = "Начисленная сумма";
            this.ColumnSum.Name = "ColumnSum";
            // 
            // ColumnMonth
            // 
            this.ColumnMonth.DataPropertyName = "NachislMonth";
            this.ColumnMonth.HeaderText = "Месяц";
            this.ColumnMonth.Name = "ColumnMonth";
            // 
            // ColumnYear
            // 
            this.ColumnYear.DataPropertyName = "NachislYear";
            this.ColumnYear.HeaderText = "Год";
            this.ColumnYear.Name = "ColumnYear";
            // 
            // Form_NachislSumma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 471);
            this.Controls.Add(this.BNNachislSumma);
            this.Controls.Add(this.BMain);
            this.Controls.Add(this.DataNachislSumma);
            this.MinimumSize = new System.Drawing.Size(806, 438);
            this.Name = "Form_NachislSumma";
            this.Text = "Журнал начислений";
            this.Load += new System.EventHandler(this.FormNachislSumma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BNNachislSumma)).EndInit();
            this.BNNachislSumma.ResumeLayout(false);
            this.BNNachislSumma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSNachislSumma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataNachislSumma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator BNNachislSumma;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBupdate;
        private System.Windows.Forms.ToolStripLabel toolStripLabelFilter;
        private System.Windows.Forms.ToolStripComboBox CBFilter;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFilter;
        private System.Windows.Forms.Button BMain;
        private System.Windows.Forms.DataGridView DataNachislSumma;
        private System.Windows.Forms.BindingSource BSNachislSumma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAbonent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnService;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnYear;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           