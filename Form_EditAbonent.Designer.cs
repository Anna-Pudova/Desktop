namespace MongoDB_Base
{
    partial class Form_EditAbonent
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
            this.TBHouse = new System.Windows.Forms.TextBox();
            this.LabelHouse = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.TBID = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.TBFlat = new System.Windows.Forms.TextBox();
            this.LabelFlat = new System.Windows.Forms.Label();
            this.TBFio = new System.Windows.Forms.TextBox();
            this.LabelFio = new System.Windows.Forms.Label();
            this.TBPhone = new System.Windows.Forms.TextBox();
            this.LabelPhone = new System.Windows.Forms.Label();
            this.LabelStreet = new System.Windows.Forms.Label();
            this.comboBoxstreet = new System.Windows.Forms.ComboBox();
            this.BSAbonent = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BSAbonent)).BeginInit();
            this.SuspendLayout();
            // 
            // TBHouse
            // 
            this.TBHouse.Location = new System.Drawing.Point(183, 89);
            this.TBHouse.Name = "TBHouse";
            this.TBHouse.Size = new System.Drawing.Size(137, 20);
            this.TBHouse.TabIndex = 116;
            this.TBHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBID_KeyPress);
            // 
            // LabelHouse
            // 
            this.LabelHouse.AutoSize = true;
            this.LabelHouse.Location = new System.Drawing.Point(11, 92);
            this.LabelHouse.Name = "LabelHouse";
            this.LabelHouse.Size = new System.Drawing.Size(70, 13);
            this.LabelHouse.TabIndex = 115;
            this.LabelHouse.Text = "Номер дома";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(11, 15);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(41, 13);
            this.LabelID.TabIndex = 114;
            this.LabelID.Text = "Номер";
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(183, 12);
            this.TBID.Name = "TBID";
            this.TBID.Size = new System.Drawing.Size(137, 20);
            this.TBID.TabIndex = 113;
            this.TBID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBID_KeyPress);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(15, 275);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(128, 23);
            this.buttonCancel.TabIndex = 111;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(195, 275);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 23);
            this.buttonAdd.TabIndex = 112;
            this.buttonAdd.Text = "Сохранить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // TBFlat
            // 
            this.TBFlat.Location = new System.Drawing.Point(183, 134);
            this.TBFlat.Name = "TBFlat";
            this.TBFlat.Size = new System.Drawing.Size(137, 20);
            this.TBFlat.TabIndex = 120;
            this.TBFlat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBID_KeyPress);
            // 
            // LabelFlat
            // 
            this.LabelFlat.AutoSize = true;
            this.LabelFlat.Location = new System.Drawing.Point(11, 137);
            this.LabelFlat.Name = "LabelFlat";
            this.LabelFlat.Size = new System.Drawing.Size(93, 13);
            this.LabelFlat.TabIndex = 119;
            this.LabelFlat.Text = "Номер квартиры";
            // 
            // TBFio
            // 
            this.TBFio.Location = new System.Drawing.Point(184, 177);
            this.TBFio.Name = "TBFio";
            this.TBFio.Size = new System.Drawing.Size(137, 20);
            this.TBFio.TabIndex = 122;
            this.TBFio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFio_KeyPress);
            // 
            // LabelFio
            // 
            this.LabelFio.AutoSize = true;
            this.LabelFio.Location = new System.Drawing.Point(12, 180);
            this.LabelFio.Name = "LabelFio";
            this.LabelFio.Size = new System.Drawing.Size(34, 13);
            this.LabelFio.TabIndex = 121;
            this.LabelFio.Text = "ФИО";
            // 
            // TBPhone
            // 
            this.TBPhone.Location = new System.Drawing.Point(184, 224);
            this.TBPhone.Name = "TBPhone";
            this.TBPhone.Size = new System.Drawing.Size(137, 20);
            this.TBPhone.TabIndex = 124;
            this.TBPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBID_KeyPress);
            // 
            // LabelPhone
            // 
            this.LabelPhone.AutoSize = true;
            this.LabelPhone.Location = new System.Drawing.Point(12, 227);
            this.LabelPhone.Name = "LabelPhone";
            this.LabelPhone.Size = new System.Drawing.Size(52, 13);
            this.LabelPhone.TabIndex = 123;
            this.LabelPhone.Text = "Телефон";
            // 
            // LabelStreet
            // 
            this.LabelStreet.AutoSize = true;
            this.LabelStreet.Location = new System.Drawing.Point(12, 57);
            this.LabelStreet.Name = "LabelStreet";
            this.LabelStreet.Size = new System.Drawing.Size(91, 13);
            this.LabelStreet.TabIndex = 125;
            this.LabelStreet.Text = "Название улицы";
            // 
            // comboBoxstreet
            // 
            this.comboBoxstreet.FormattingEnabled = true;
            this.comboBoxstreet.Items.AddRange(new object[] {
            "ЦИОЛКОВСКОГО УЛИЦА",
            "НОВАЯ УЛИЦА",
            "ВОЙКОВ ПЕРЕУЛОК",
            "ТАТАРСКАЯ УЛИЦА",
            "ГАГАРИНА УЛИЦА",
            "МОСКОВСКАЯ УЛИЦА",
            "КУТУЗОВА УЛИЦА",
            "МОСКОВСКОЕ ШОССЕ"});
            this.comboBoxstreet.Location = new System.Drawing.Point(183, 54);
            this.comboBoxstreet.Name = "comboBoxstreet";
            this.comboBoxstreet.Size = new System.Drawing.Size(137, 21);
            this.comboBoxstreet.TabIndex = 126;
            // 
            // Form_EditAbonent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 310);
            this.Controls.Add(this.comboBoxstreet);
            this.Controls.Add(this.LabelStreet);
            this.Controls.Add(this.TBPhone);
            this.Controls.Add(this.LabelPhone);
            this.Controls.Add(this.TBFio);
            this.Controls.Add(this.LabelFio);
            this.Controls.Add(this.TBFlat);
            this.Controls.Add(this.LabelFlat);
            this.Controls.Add(this.TBHouse);
            this.Controls.Add(this.LabelHouse);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.TBID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.MaximizeBox = false;
            this.Name = "Form_EditAbonent";
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.Form_EditAbonent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BSAbonent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBHouse;
        private System.Windows.Forms.Label LabelHouse;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox TBFlat;
        private System.Windows.Forms.Label LabelFlat;
        private System.Windows.Forms.TextBox TBFio;
        private System.Windows.Forms.Label LabelFio;
        private System.Windows.Forms.TextBox TBPhone;
        private System.Windows.Forms.Label LabelPhone;
        private System.Windows.Forms.Label LabelStreet;
        private System.Windows.Forms.ComboBox comboBoxstreet;
        public System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.BindingSource BSAbonent;
    }
}