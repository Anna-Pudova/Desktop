﻿namespace MongoDB_Base
{
    partial class Form_EditStreet
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
            this.TBName = new System.Windows.Forms.TextBox();
            this.LabelStreetCD = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.TBID = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(184, 48);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(137, 20);
            this.TBName.TabIndex = 108;
            this.TBName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBName_KeyPress);
            // 
            // LabelStreetCD
            // 
            this.LabelStreetCD.AutoSize = true;
            this.LabelStreetCD.Location = new System.Drawing.Point(12, 51);
            this.LabelStreetCD.Name = "LabelStreetCD";
            this.LabelStreetCD.Size = new System.Drawing.Size(57, 13);
            this.LabelStreetCD.TabIndex = 107;
            this.LabelStreetCD.Text = "Название";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(12, 19);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(41, 13);
            this.LabelID.TabIndex = 106;
            this.LabelID.Text = "Номер";
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(184, 16);
            this.TBID.Name = "TBID";
            this.TBID.Size = new System.Drawing.Size(137, 20);
            this.TBID.TabIndex = 105;
            this.TBID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBID_KeyPress);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(12, 101);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(126, 23);
            this.buttonCancel.TabIndex = 103;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(196, 101);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 23);
            this.buttonAdd.TabIndex = 104;
            this.buttonAdd.Text = "Сохранить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form_EditStreet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 137);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.LabelStreetCD);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.TBID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.MaximizeBox = false;
            this.Name = "Form_EditStreet";
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.Form_EditStreet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label LabelStreetCD;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
    }
}