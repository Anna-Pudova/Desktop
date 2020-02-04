namespace MongoDB_Base
{
    partial class Form_Request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Request));
            this.BNRequest = new System.Windows.Forms.BindingNavigator(this.components);
            this.BSRequest = new System.Windows.Forms.BindingSource(this.components);
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
            this.DataRequest = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAbonent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDisrepair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExecutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BNRequest)).BeginInit();
            this.BNRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // BNRequest
            // 
            this.BNRequest.AddNewItem = null;
            this.BNRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BNRequest.BindingSource = this.BSRequest;
            this.BNRequest.CountItem = this.bindingNavigatorCountItem;
            this.BNRequest.DeleteItem = this.bindingNavigatorMoveNextItem;
            this.BNRequest.Dock = System.Windows.Forms.DockStyle.None;
            this.BNRequest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.BNRequest.Location = new System.Drawing.Point(162, 49);
            this.BNRequest.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BNRequest.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BNRequest.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BNRequest.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BNRequest.Name = "BNRequest";
            this.BNRequest.PositionItem = this.bindingNavigatorPositionItem;
            this.BNRequest.Size = new System.Drawing.Size(619, 25);
            this.BNRequest.TabIndex = 20;
            this.BNRequest.Text = "bindingNavigator1";
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
            "Слесарь",
            "Неисправность",
            "Признак выполнения"});
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
            this.BMain.TabIndex = 19;
            this.BMain.UseVisualStyleBackColor = true;
            this.BMain.Click += new System.EventHandler(this.BMain_Click);
            // 
            // DataRequest
            // 
            this.DataRequest.AccessibleName = "";
            this.DataRequest.AllowUserToAddRows = false;
            this.DataRequest.AllowUserToDeleteRows = false;
            this.DataRequest.AllowUserToOrderColumns = true;
            this.DataRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.Column_id,
            this.ColumnAbonent,
            this.ColumnDisrepair,
            this.ColumnExecutor,
            this.ColumnDateP,
            this.ColumnDateV,
            this.ColumnFlag});
            this.DataRequest.Location = new System.Drawing.Point(12, 80);
            this.DataRequest.Name = "DataRequest";
            this.DataRequest.Size = new System.Drawing.Size(766, 283);
            this.DataRequest.TabIndex = 18;
            this.DataRequest.Tag = "";
            this.DataRequest.UseWaitCursor = true;
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
            // ColumnDisrepair
            // 
            this.ColumnDisrepair.DataPropertyName = "FailureCD";
            this.ColumnDisrepair.HeaderText = "Неисправность";
            this.ColumnDisrepair.Name = "ColumnDisrepair";
            // 
            // ColumnExecutor
            // 
            this.ColumnExecutor.DataPropertyName = "ExecutorCD";
            this.ColumnExecutor.HeaderText = "Слесарь";
            this.ColumnExecutor.Name = "ColumnExecutor";
            // 
            // ColumnDateP
            // 
            this.ColumnDateP.DataPropertyName = "IncomingDate";
            this.ColumnDateP.HeaderText = "Дата принятия";
            this.ColumnDateP.Name = "ColumnDateP";
            // 
            // ColumnDateV
            // 
            this.ColumnDateV.DataPropertyName = "ExecutionDate";
            this.ColumnDateV.HeaderText = "Дата выполнения";
            this.ColumnDateV.Name = "ColumnDateV";
            // 
            // ColumnFlag
            // 
            this.ColumnFlag.DataPropertyName = "Executed";
            this.ColumnFlag.HeaderText = "Признак выполнения";
            this.ColumnFlag.Name = "ColumnFlag";
            // 
            // Form_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 475);
            this.Controls.Add(this.BNRequest);
            this.Controls.Add(this.BMain);
            this.Controls.Add(this.DataRequest);
            this.MinimumSize = new System.Drawing.Size(806, 438);
            this.Name = "Form_Request";
            this.Text = "Заявки";
            this.Load += new System.EventHandler(this.FormRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BNRequest)).EndInit();
            this.BNRequest.ResumeLayout(false);
            this.BNRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator BNRequest;
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
        private System.Windows.Forms.DataGridView DataRequest;
        private System.Windows.Forms.BindingSource BSRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAbonent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDisrepair;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExecutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFlag;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           