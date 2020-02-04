namespace MongoDB_Base
{
    partial class Form_EditRequest
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelStreetCD = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.TBID = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerdateV = new System.Windows.Forms.DateTimePicker();
            this.comboBoxexecutor = new System.Windows.Forms.ComboBox();
            this.comboBoxdisrepair = new System.Windows.Forms.ComboBox();
            this.dateTimePickerdateP = new System.Windows.Forms.DateTimePicker();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.comboBoxAbonent = new System.Windows.Forms.ComboBox();
            this.LAbonent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 139;
            this.label3.Text = "Дата принятия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 137;
            this.label2.Text = "Дата выполнения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 135;
            this.label1.Text = "Неисправность";
            // 
            // LabelStreetCD
            // 
            this.LabelStreetCD.AutoSize = true;
            this.LabelStreetCD.Location = new System.Drawing.Point(3, 96);
            this.LabelStreetCD.Name = "LabelStreetCD";
            this.LabelStreetCD.Size = new System.Drawing.Size(50, 13);
            this.LabelStreetCD.TabIndex = 131;
            this.LabelStreetCD.Text = "Слесарь";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(3, 19);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(41, 13);
            this.LabelID.TabIndex = 130;
            this.LabelID.Text = "Номер";
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(134, 16);
            this.TBID.Name = "TBID";
            this.TBID.Size = new System.Drawing.Size(178, 20);
            this.TBID.TabIndex = 129;
            this.TBID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBID_KeyPress);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(6, 333);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(126, 23);
            this.buttonCancel.TabIndex = 127;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(186, 333);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 23);
            this.buttonAdd.TabIndex = 128;
            this.buttonAdd.Text = "Сохранить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 143;
            this.label5.Text = "Признак выполнения";
            // 
            // dateTimePickerdateV
            // 
            this.dateTimePickerdateV.Location = new System.Drawing.Point(134, 178);
            this.dateTimePickerdateV.Name = "dateTimePickerdateV";
            this.dateTimePickerdateV.Size = new System.Drawing.Size(178, 20);
            this.dateTimePickerdateV.TabIndex = 145;
            // 
            // comboBoxexecutor
            // 
            this.comboBoxexecutor.FormattingEnabled = true;
            this.comboBoxexecutor.Items.AddRange(new object[] {
            "Стародубцев Е.М.",
            "Шубин В.Г.",
            "Шлюков М.К.",
            "Булгаков Т.И.",
            "Школьников С.М."});
            this.comboBoxexecutor.Location = new System.Drawing.Point(134, 93);
            this.comboBoxexecutor.Name = "comboBoxexecutor";
            this.comboBoxexecutor.Size = new System.Drawing.Size(178, 21);
            this.comboBoxexecutor.TabIndex = 146;
            // 
            // comboBoxdisrepair
            // 
            this.comboBoxdisrepair.FormattingEnabled = true;
            this.comboBoxdisrepair.Items.AddRange(new object[] {
            "Засорилась водогрейная колонка",
            "Не горит АГВ",
            "Течет из водогрейной колонки",
            "Несправная печная горелка",
            "Неисправный газовый счетчик",
            "Плохое поступление газа на горелку плиты",
            "Туго поворачивается пробка крана плиты",
            "При закрытии краника горелка плиты не гаснет",
            "Неизвестна"});
            this.comboBoxdisrepair.Location = new System.Drawing.Point(134, 133);
            this.comboBoxdisrepair.Name = "comboBoxdisrepair";
            this.comboBoxdisrepair.Size = new System.Drawing.Size(178, 21);
            this.comboBoxdisrepair.TabIndex = 147;
            // 
            // dateTimePickerdateP
            // 
            this.dateTimePickerdateP.Location = new System.Drawing.Point(134, 224);
            this.dateTimePickerdateP.Name = "dateTimePickerdateP";
            this.dateTimePickerdateP.Size = new System.Drawing.Size(178, 20);
            this.dateTimePickerdateP.TabIndex = 148;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(134, 271);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(40, 17);
            this.radioButtonYes.TabIndex = 149;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Да";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(196, 271);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(44, 17);
            this.radioButtonNo.TabIndex = 150;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "Нет";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // comboBoxAbonent
            // 
            this.comboBoxAbonent.FormattingEnabled = true;
            this.comboBoxAbonent.Items.AddRange(new object[] {
            "Аксенов С.А.",
            "Мищенко Е.В.",
            "Конюхов В.С.",
            "Тулупова М.И.",
            "Свирина З.А.",
            "Стародубцев Е.В.",
            "Шмаков С.В.",
            "Маркова В.П.",
            "Денисова Е.К.",
            "Лукашина Р.М.",
            "Шубина Т.П.",
            "Тимошкина Н.Г."});
            this.comboBoxAbonent.Location = new System.Drawing.Point(133, 58);
            this.comboBoxAbonent.Name = "comboBoxAbonent";
            this.comboBoxAbonent.Size = new System.Drawing.Size(178, 21);
            this.comboBoxAbonent.TabIndex = 166;
            // 
            // LAbonent
            // 
            this.LAbonent.AutoSize = true;
            this.LAbonent.Location = new System.Drawing.Point(3, 61);
            this.LAbonent.Name = "LAbonent";
            this.LAbonent.Size = new System.Drawing.Size(49, 13);
            this.LAbonent.TabIndex = 165;
            this.LAbonent.Text = "Абонент";
            // 
            // Form_EditRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 367);
            this.Controls.Add(this.comboBoxAbonent);
            this.Controls.Add(this.LAbonent);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.radioButtonYes);
            this.Controls.Add(this.dateTimePickerdateP);
            this.Controls.Add(this.comboBoxdisrepair);
            this.Controls.Add(this.comboBoxexecutor);
            this.Controls.Add(this.dateTimePickerdateV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelStreetCD);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.TBID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.MaximizeBox = false;
            this.Name = "Form_EditRequest";
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.Form_EditRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelStreetCD;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerdateV;
        private System.Windows.Forms.ComboBox comboBoxexecutor;
        private System.Windows.Forms.ComboBox comboBoxdisrepair;
        private System.Windows.Forms.DateTimePicker dateTimePickerdateP;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.ComboBox comboBoxAbonent;
        private System.Windows.Forms.Label LAbonent;
    }
}