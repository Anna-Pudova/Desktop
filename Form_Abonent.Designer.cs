namespace MongoDB_Base
{
    partial class Form_Abonent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Abonent));
            this.BNAbonent = new System.Windows.Forms.BindingNavigator(this.components);
            this.BSAbonent = new System.Windows.Forms.BindingSource(this.components);
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
            this.DataAbonent = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BNAbonent)).BeginInit();
            this.BNAbonent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSAbonent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataAbonent)).BeginInit();
            this.SuspendLayout();
            // 
            // BNAbonent
            // 
            this.BNAbonent.AddNewItem = null;
            this.BNAbonent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BNAbonent.BindingSource = this.BSAbonent;
            this.BNAbonent.CountItem = this.bindingNavigatorCountItem;
            this.BNAbonent.DeleteItem = this.bindingNavigatorMoveNextItem;
            this.BNAbonent.Dock = System.Windows.Forms.DockStyle.None;
            this.BNAbonent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.BNAbonent.Location = new System.Drawing.Point(148, 60);
            this.BNAbonent.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BNAbonent.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BNAbonent.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BNAbonent.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BNAbonent.Name = "BNAbonent";
            this.BNAbonent.PositionItem = this.bindingNavigatorPositionItem;
            this.BNAbonent.Size = new System.Drawing.Size(588, 25);
            this.BNAbonent.TabIndex = 17;
            this.BNAbonent.Text = "bindingNavigator1";
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
            this.CBFilter.Items.AddRange(new object[] {
            "Лицевой счет",
            "Улица",
            "Дом",
            "Квартира",
            "ФИО"});
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
            this.BMain.Location = new System.Drawing.Point(12, 19);
            this.BMain.Name = "BMain";
            this.BMain.Size = new System.Drawing.Size(84, 66);
            this.BMain.TabIndex = 16;
            this.BMain.UseVisualStyleBackColor = true;
            this.BMain.Click += new System.EventHandler(this.BMain_Click);
            // 
            // DataAbonent
            // 
            this.DataAbonent.AccessibleName = "";
            this.DataAbonent.AllowUserToAddRows = false;
            this.DataAbonent.AllowUserToDeleteRows = false;
            this.DataAbonent.AllowUserToOrderColumns = true;
            this.DataAbonent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataAbonent.AutoGenerateColumns = false;
            this.DataAbonent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataAbonent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnStreet,
            this.ColumnHouse,
            this.ColumnFlat,
            this.ColumnFio,
            this.ColumnPhone,
            this._id});
            this.DataAbonent.DataSource = this.BSAbonent;
            this.DataAbonent.Location = new System.Drawing.Point(12, 99);
            this.DataAbonent.Name = "DataAbonent";
            this.DataAbonent.Size = new System.Drawing.Size(766, 283);
            this.DataAbonent.TabIndex = 15;
            this.DataAbonent.Tag = "";
            this.DataAbonent.UseWaitCursor = true;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "Id";
            this.ColumnId.HeaderText = "Лицевой счет";
            this.ColumnId.Name = "ColumnId";
            // 
            // ColumnStreet
            // 
            this.ColumnStreet.DataPropertyName = "StreetCD";
            this.ColumnStreet.HeaderText = "Улица";
            this.ColumnStreet.Name = "ColumnStreet";
            // 
            // ColumnHouse
            // 
            this.ColumnHouse.DataPropertyName = "HouseNo";
            this.ColumnHouse.HeaderText = "Дом";
            this.ColumnHouse.Name = "ColumnHouse";
            // 
            // ColumnFlat
            // 
            this.ColumnFlat.DataPropertyName = "FlatNo";
            this.ColumnFlat.HeaderText = "Квартира";
            this.ColumnFlat.Name = "ColumnFlat";
            // 
            // ColumnFio
            // 
            this.ColumnFio.DataPropertyName = "Fio";
            this.ColumnFio.HeaderText = "ФИО";
            this.ColumnFio.Name = "ColumnFio";
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.DataPropertyName = "Phone";
            this.ColumnPhone.HeaderText = "Телефон";
            this.ColumnPhone.Name = "ColumnPhone";
            // 
            // _id
            // 
            this._id.DataPropertyName = "_id";
            this._id.HeaderText = "_id";
            this._id.Name = "_id";
            this._id.Visible = false;
            // 
            // Form_Abonent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 400);
            this.Controls.Add(this.BNAbonent);
            this.Controls.Add(this.BMain);
            this.Controls.Add(this.DataAbonent);
            this.MinimumSize = new System.Drawing.Size(806, 438);
            this.Name = "Form_Abonent";
            this.Text = "Абоненты";
            this.Load += new System.EventHandler(this.FormAbonent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BNAbonent)).EndInit();
            this.BNAbonent.ResumeLayout(false);
            this.BNAbonent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSAbonent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataAbonent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator BNAbonent;
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
        private System.Windows.Forms.DataGridView DataAbonent;
        private System.Windows.Forms.BindingSource BSAbonent;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  