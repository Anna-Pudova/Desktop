namespace MongoDB_Base
{
    partial class Form_EditNachislSumma
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
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelStreetCD = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.TBID = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.TBSum = new System.Windows.Forms.TextBox();
            this.TBMonth = new System.Windows.Forms.TextBox();
            this.TBYear = new System.Windows.Forms.TextBox();
            this.comboBoxAbonent = new System.Windows.Forms.ComboBox();
            this.LAbonent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Items.AddRange(new object[] {
            "Водоснабжение",
            "Теплоснабжение",
            "Электроснабжение",
            "Газоснабжение"});
            this.comboBoxService.Location = new System.Drawing.Point(143, 93);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(178, 21);
            this.comboBoxService.TabIndex = 165;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 160;
            this.label3.Text = "Год";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 159;
            this.label2.Text = "Месяц";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 158;
            this.label1.Text = "Сумма";
            // 
            // LabelStreetCD
            // 
            this.LabelStreetCD.AutoSize = true;
            this.LabelStreetCD.Location = new System.Drawing.Point(12, 96);
            this.LabelStreetCD.Name = "LabelStreetCD";
            this.LabelStreetCD.Size = new System.Drawing.Size(43, 13);
            this.LabelStreetCD.TabIndex = 155;
            this.LabelStreetCD.Text = "Услуга";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(12, 19);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(41, 13);
            this.LabelID.TabIndex = 154;
            this.LabelID.Text = "Номер";
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(143, 16);
            this.TBID.Name = "TBID";
            this.TBID.Size = new System.Drawing.Size(178, 20);
            this.TBID.TabIndex = 153;
            this.TBID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBID_KeyPress);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(15, 302);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(126, 23);
            this.buttonCancel.TabIndex = 151;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(196, 302);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 23);
            this.buttonAdd.TabIndex = 152;
            this.buttonAdd.Text = "Сохранить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // TBSum
            // 
            this.TBSum.Location = new System.Drawing.Point(143, 138);
            this.TBSum.Name = "TBSum";
            this.TBSum.Size = new System.Drawing.Size(178, 20);
            this.TBSum.TabIndex = 170;
            this.TBSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBSum_KeyPress);
            // 
            // TBMonth
            // 
            this.TBMonth.Location = new System.Drawing.Point(143, 187);
            this.TBMonth.Name = "TBMonth";
            this.TBMonth.Size = new System.Drawing.Size(178, 20);
            this.TBMonth.TabIndex = 171;
            this.TBMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBMonth_KeyPress);
            // 
            // TBYear
            // 
            this.TBYear.Location = new System.Drawing.Point(143, 234);
            this.TBYear.Name = "TBYear";
            this.TBYear.Size = new System.Drawing.Size(178, 20);
            this.TBYear.TabIndex = 172;
            this.TBYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBID_KeyPress);
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
            this.comboBoxAbonent.Location = new System.Drawing.Point(143, 53);
            this.comboBoxAbonent.Name = "comboBoxAbonent";
            this.comboBoxAbonent.Size = new System.Drawing.Size(178, 21);
            this.comboBoxAbonent.TabIndex = 174;
            // 
            // LAbonent
            // 
            this.LAbonent.AutoSize = true;
            this.LAbonent.Location = new System.Drawing.Point(12, 61);
            this.LAbonent.Name = "LAbonent";
            this.LAbonent.Size = new System.Drawing.Size(49, 13);
            this.LAbonent.TabIndex = 173;
            this.LAbonent.Text = "Абонент";
            // 
            // Form_EditNachislSumma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 337);
            this.Controls.Add(this.comboBoxAbonent);
            this.Controls.Add(this.LAbonent);
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
            this.Name = "Form_EditNachislSumma";
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.Form_EditNachislSumma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelStreetCD;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox TBSum;
        private System.Windows.Forms.TextBox TBMonth;
        private System.Windows.Forms.TextBox TBYear;
        private System.Windows.Forms.ComboBox comboBoxAbonent;
        private System.Windows.Forms.Label LAbonent;
    }
}