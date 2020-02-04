namespace MongoDB_Base
{
    partial class Form_EditPaySumma
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
            this.TBYear = new System.Windows.Forms.TextBox();
            this.TBMonth = new System.Windows.Forms.TextBox();
            this.TBSum = new System.Windows.Forms.TextBox();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelStreetCD = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.TBID = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxAbonent = new System.Windows.Forms.ComboBox();
            this.LAbonent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBYear
            // 
            this.TBYear.Location = new System.Drawing.Point(148, 280);
            this.TBYear.Name = "TBYear";
            this.TBYear.Size = new System.Drawing.Size(178, 20);
            this.TBYear.TabIndex = 188;
            this.TBYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBID_KeyPress);
            // 
            // TBMonth
            // 
            this.TBMonth.Location = new System.Drawing.Point(148, 233);
            this.TBMonth.Name = "TBMonth";
            this.TBMonth.Size = new System.Drawing.Size(178, 20);
            this.TBMonth.TabIndex = 187;
            this.TBMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBMonth_KeyPress);
            // 
            // TBSum
            // 
            this.TBSum.Location = new System.Drawing.Point(145, 147);
            this.TBSum.Name = "TBSum";
            this.TBSum.Size = new System.Drawing.Size(178, 20);
            this.TBSum.TabIndex = 186;
            this.TBSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBSum_KeyPress);
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Items.AddRange(new object[] {
            "Водоснабжение",
            "Теплоснабжение",
            "Электроснабжение",
            "Газоснабжение"});
            this.comboBoxService.Location = new System.Drawing.Point(145, 102);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(178, 21);
            this.comboBoxService.TabIndex = 185;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 182;
            this.label3.Text = "Расчетный год";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 181;
            this.label2.Text = "Расчетный месяц";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 180;
            this.label1.Text = "Сумма";
            // 
            // LabelStreetCD
            // 
            this.LabelStreetCD.AutoSize = true;
            this.LabelStreetCD.Location = new System.Drawing.Point(14, 105);
            this.LabelStreetCD.Name = "LabelStreetCD";
            this.LabelStreetCD.Size = new System.Drawing.Size(43, 13);
            this.LabelStreetCD.TabIndex = 177;
            this.LabelStreetCD.Text = "Услуга";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(14, 28);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(41, 13);
            this.LabelID.TabIndex = 176;
            this.LabelID.Text = "Номер";
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(145, 25);
            this.TBID.Name = "TBID";
            this.TBID.Size = new System.Drawing.Size(178, 20);
            this.TBID.TabIndex = 175;
            this.TBID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBID_KeyPress);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(20, 354);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(126, 23);
            this.buttonCancel.TabIndex = 173;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(201, 354);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 23);
            this.buttonAdd.TabIndex = 174;
            this.buttonAdd.Text = "Сохранить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(144, 188);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(178, 20);
            this.dateTimePickerDate.TabIndex = 190;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 189;
            this.label5.Text = "Дата оплаты";
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
            this.comboBoxAbonent.Location = new System.Drawing.Point(144, 67);
            this.comboBoxAbonent.Name = "comboBoxAbonent";
            this.comboBoxAbonent.Size = new System.Drawing.Size(178, 21);
            this.comboBoxAbonent.TabIndex = 192;
            // 
            // LAbonent
            // 
            this.LAbonent.AutoSize = true;
            this.LAbonent.Location = new System.Drawing.Point(14, 70);
            this.LAbonent.Name = "LAbonent";
            this.LAbonent.Size = new System.Drawing.Size(49, 13);
            this.LAbonent.TabIndex = 191;
            this.LAbonent.Text = "Абонент";
            // 
            // Form_EditPaySumma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 389);
            this.Controls.Add(this.comboBoxAbonent);
            this.Controls.Add(this.LAbonent);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBYear);
            this.Controls.Add(this.TBMonth);
            this.Controls.Add(this.TBSum);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelStreetCD);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.TBID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.MaximizeBox = false;
            this.Name = "Form_EditPaySumma";
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.Form_EditPaySumma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBYear;
        private System.Windows.Forms.TextBox TBMonth;
        private System.Windows.Forms.TextBox TBSum;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelStreetCD;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxAbonent;
        private System.Windows.Forms.Label LAbonent;
    }
}