namespace MongoDB_Base
{
    partial class Form_PaySumma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PaySumma));
            this.BNPaySumma = new System.Windows.Forms.BindingNavigator(this.components);
            this.BSPaySumma = new System.Windows.Forms.BindingSource(this.components);
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
            this.DataPaySumma = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAbonent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BNPaySumma)).BeginInit();
            this.BNPaySumma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSPaySumma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPaySumma)).BeginInit();
            this.SuspendLayout();
            // 
            // BNPaySumma
            // 
            this.BNPaySumma.AddNewItem = null;
            this.BNPaySumma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BNPaySumma.BindingSource = this.BSPaySumma;
            this.BNPaySumma.CountItem = this.bindingNavigatorCountItem;
            this.BNPaySumma.DeleteItem = this.bindingNavigatorMoveNextItem;
            this.BNPaySumma.Dock = System.Windows.Forms.DockStyle.None;
            this.BNPaySumma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.BNPaySumma.Location = new System.Drawing.Point(122, 30);
            this.BNPaySumma.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BNPaySumma.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BNPaySumma.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BNPaySumma.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BNPaySumma.Name = "BNPaySumma";
            this.BNPaySumma.PositionItem = this.bindingNavigatorPositionItem;
            this.BNPaySumma.Size = new System.Drawing.Size(588, 25);
            this.BNPaySumma.TabIndex = 23;
            this.BNPaySumma.Text = "bindingNavigator1";
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
            "Лицевой счет",
            "Услуга",
            "Сумма",
            "Расчетный месяц",
            "Расчетный год"});
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
            this.BMain.Location = new System.Drawing.Point(12, 12);
            this.BMain.Name = "BMain";
            this.BMain.Size = new System.Drawing.Size(75, 66);
            this.BMain.TabIndex = 22;
            this.BMain.UseVisualStyleBackColor = true;
            this.BMain.Click += new System.EventHandler(this.BMain_Click);
            // 
            // DataPaySumma
            // 
            this.DataPaySumma.AccessibleName = "";
            this.DataPaySumma.AllowUserToAddRows = false;
            this.DataPaySumma.AllowUserToDeleteRows = false;
            this.DataPaySumma.AllowUserToOrderColumns = true;
            this.DataPaySumma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataPaySumma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPaySumma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnAbonent,
            this.ColumnService,
            this.ColumnSum,
            this.Column_id,
            this.ColumnDate,
            this.ColumnMonth,
            this.ColumnYear});
            this.DataPaySumma.Location = new System.Drawing.Point(12, 85);
            this.DataPaySumma.Name = "DataPaySumma";
            this.DataPaySumma.Size = new System.Drawing.Size(756, 283);
            this.DataPaySumma.TabIndex = 21;
            this.DataPaySumma.Tag = "";
            this.DataPaySumma.UseWaitCursor = true;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "Id";
            this.ColumnId.HeaderText = "Номер";
            this.ColumnId.Name = "ColumnId";
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
            this.ColumnSum.DataPropertyName = "PaySum";
            this.ColumnSum.HeaderText = "Сумма оплаты";
            this.ColumnSum.Name = "ColumnSum";
            // 
            // Column_id
            // 
            this.Column_id.DataPropertyName = "_id";
            this.Column_id.HeaderText = "_id";
            this.Column_id.Name = "Column_id";
            this.Column_id.Visible = false;
            // 
            // ColumnDate
            // 
            this.ColumnDate.DataPropertyName = "PayDate";
            this.ColumnDate.HeaderText = "Дата оплаты";
            this.ColumnDate.Name = "ColumnDate";
            // 
            // ColumnMonth
            // 
            this.ColumnMonth.DataPropertyName = "PayMonth";
            this.ColumnMonth.HeaderText = "Расчетный месяц";
            this.ColumnMonth.Name = "ColumnMonth";
            // 
            // ColumnYear
            // 
            this.ColumnYear.DataPropertyName = "PayYear";
            this.ColumnYear.HeaderText = "Расчетный год";
            this.ColumnYear.Name = "ColumnYear";
            // 
            // Form_PaySumma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 474);
            this.Controls.Add(this.BNPaySumma);
            this.Controls.Add(this.BMain);
            this.Controls.Add(this.DataPaySumma);
            this.Name = "Form_PaySumma";
            this.Text = "Журнал оплат";
            this.Load += new System.EventHandler(this.FormPaySumma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BNPaySumma)).EndInit();
            this.BNPaySumma.ResumeLayout(false);
            this.BNPaySumma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSPaySumma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPaySumma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator BNPaySumma;
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
        private System.Windows.Forms.DataGridView DataPaySumma;
        private System.Windows.Forms.BindingSource BSPaySumma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAbonent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnService;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnYear;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      