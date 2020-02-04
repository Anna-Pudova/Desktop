namespace MongoDB_Base
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.абонентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналНачисленийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналОплатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналЗаявокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.улицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.неисправностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.слесариToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.схемаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.профильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelInfoS = new System.Windows.Forms.Label();
            this.BLogo = new System.Windows.Forms.Button();
            this.BAbonent = new System.Windows.Forms.Button();
            this.BRequest = new System.Windows.Forms.Button();
            this.BNachislSum = new System.Windows.Forms.Button();
            this.BPaySum = new System.Windows.Forms.Button();
            this.BServices = new System.Windows.Forms.Button();
            this.BStreet = new System.Windows.Forms.Button();
            this.BExecutor = new System.Windows.Forms.Button();
            this.BDisrepair = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетыToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.профильToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.абонентыToolStripMenuItem,
            this.журналНачисленийToolStripMenuItem,
            this.журналОплатToolStripMenuItem,
            this.журналЗаявокToolStripMenuItem});
            this.отчетыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("отчетыToolStripMenuItem.Image")));
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // абонентыToolStripMenuItem
            // 
            this.абонентыToolStripMenuItem.Name = "абонентыToolStripMenuItem";
            this.абонентыToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.абонентыToolStripMenuItem.Text = "Абоненты";
            this.абонентыToolStripMenuItem.Click += new System.EventHandler(this.абонентыToolStripMenuItem_Click);
            // 
            // журналНачисленийToolStripMenuItem
            // 
            this.журналНачисленийToolStripMenuItem.Name = "журналНачисленийToolStripMenuItem";
            this.журналНачисленийToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.журналНачисленийToolStripMenuItem.Text = "Журнал начислений";
            this.журналНачисленийToolStripMenuItem.Click += new System.EventHandler(this.журналНачисленийToolStripMenuItem_Click);
            // 
            // журналОплатToolStripMenuItem
            // 
            this.журналОплатToolStripMenuItem.Name = "журналОплатToolStripMenuItem";
            this.журналОплатToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.журналОплатToolStripMenuItem.Text = "Журнал оплат";
            this.журналОплатToolStripMenuItem.Click += new System.EventHandler(this.журналОплатToolStripMenuItem_Click);
            // 
            // журналЗаявокToolStripMenuItem
            // 
            this.журналЗаявокToolStripMenuItem.Name = "журналЗаявокToolStripMenuItem";
            this.журналЗаявокToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.журналЗаявокToolStripMenuItem.Text = "Журнал заявок";
            this.журналЗаявокToolStripMenuItem.Click += new System.EventHandler(this.журналЗаявокToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.улицыToolStripMenuItem,
            this.неисправностиToolStripMenuItem,
            this.слесариToolStripMenuItem,
            this.услугиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("справочникиToolStripMenuItem.Image")));
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // улицыToolStripMenuItem
            // 
            this.улицыToolStripMenuItem.Name = "улицыToolStripMenuItem";
            this.улицыToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.улицыToolStripMenuItem.Text = "Улицы";
            this.улицыToolStripMenuItem.Click += new System.EventHandler(this.улицыToolStripMenuItem_Click);
            // 
            // неисправностиToolStripMenuItem
            // 
            this.неисправностиToolStripMenuItem.Name = "неисправностиToolStripMenuItem";
            this.неисправностиToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.неисправностиToolStripMenuItem.Text = "Неисправности";
            this.неисправностиToolStripMenuItem.Click += new System.EventHandler(this.неисправностиToolStripMenuItem_Click);
            // 
            // слесариToolStripMenuItem
            // 
            this.слесариToolStripMenuItem.Name = "слесариToolStripMenuItem";
            this.слесариToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.слесариToolStripMenuItem.Text = "Слесари";
            this.слесариToolStripMenuItem.Click += new System.EventHandler(this.слесариToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.услугиToolStripMenuItem.Text = "Услуги";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.схемаДанныхToolStripMenuItem});
            this.справкаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("справкаToolStripMenuItem.Image")));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // схемаДанныхToolStripMenuItem
            // 
            this.схемаДанныхToolStripMenuItem.Name = "схемаДанныхToolStripMenuItem";
            this.схемаДанныхToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.схемаДанныхToolStripMenuItem.Text = "Схема данных";
            this.схемаДанныхToolStripMenuItem.Click += new System.EventHandler(this.схемаДанныхToolStripMenuItem_Click);
            // 
            // профильToolStripMenuItem
            // 
            this.профильToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.профильToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("профильToolStripMenuItem.Image")));
            this.профильToolStripMenuItem.Name = "профильToolStripMenuItem";
            this.профильToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.профильToolStripMenuItem.Text = "Профиль";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // labelZ
            // 
            this.labelZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelZ.AutoSize = true;
            this.labelZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZ.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelZ.Location = new System.Drawing.Point(276, 94);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(792, 37);
            this.labelZ.TabIndex = 3;
            this.labelZ.Text = "Демонстрационное приложение учебной БД \"Абонент\"";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelInfo.Location = new System.Drawing.Point(12, 206);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(330, 31);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "Суммарная информация";
            // 
            // labelInfoS
            // 
            this.labelInfoS.AutoSize = true;
            this.labelInfoS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoS.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelInfoS.Location = new System.Drawing.Point(12, 463);
            this.labelInfoS.Name = "labelInfoS";
            this.labelInfoS.Size = new System.Drawing.Size(405, 31);
            this.labelInfoS.TabIndex = 5;
            this.labelInfoS.Text = "Информация по справочникам";
            // 
            // BLogo
            // 
            this.BLogo.Image = ((System.Drawing.Image)(resources.GetObject("BLogo.Image")));
            this.BLogo.Location = new System.Drawing.Point(16, 37);
            this.BLogo.Name = "BLogo";
            this.BLogo.Size = new System.Drawing.Size(109, 112);
            this.BLogo.TabIndex = 14;
            this.BLogo.UseVisualStyleBackColor = true;
            this.BLogo.Click += new System.EventHandler(this.BLogo_Click);
            // 
            // BAbonent
            // 
            this.BAbonent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.BAbonent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAbonent.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BAbonent.Location = new System.Drawing.Point(28, 260);
            this.BAbonent.MaximumSize = new System.Drawing.Size(400, 90);
            this.BAbonent.Name = "BAbonent";
            this.BAbonent.Size = new System.Drawing.Size(281, 90);
            this.BAbonent.TabIndex = 15;
            this.BAbonent.Text = "Абонентов: 12";
            this.BAbonent.UseVisualStyleBackColor = true;
            this.BAbonent.Click += new System.EventHandler(this.абонентыToolStripMenuItem_Click);
            // 
            // BRequest
            // 
            this.BRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BRequest.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BRequest.Location = new System.Drawing.Point(315, 260);
            this.BRequest.MaximumSize = new System.Drawing.Size(400, 90);
            this.BRequest.Name = "BRequest";
            this.BRequest.Size = new System.Drawing.Size(281, 90);
            this.BRequest.TabIndex = 16;
            this.BRequest.Text = "Заявок: 21";
            this.BRequest.UseVisualStyleBackColor = true;
            this.BRequest.Click += new System.EventHandler(this.журналЗаявокToolStripMenuItem_Click);
            // 
            // BNachislSum
            // 
            this.BNachislSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BNachislSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BNachislSum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BNachislSum.Location = new System.Drawing.Point(602, 260);
            this.BNachislSum.MaximumSize = new System.Drawing.Size(400, 90);
            this.BNachislSum.Name = "BNachislSum";
            this.BNachislSum.Size = new System.Drawing.Size(281, 90);
            this.BNachislSum.TabIndex = 17;
            this.BNachislSum.Text = "Всего начислено: 12950";
            this.BNachislSum.UseVisualStyleBackColor = true;
            this.BNachislSum.Click += new System.EventHandler(this.журналНачисленийToolStripMenuItem_Click);
            // 
            // BPaySum
            // 
            this.BPaySum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BPaySum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BPaySum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BPaySum.Location = new System.Drawing.Point(891, 260);
            this.BPaySum.MaximumSize = new System.Drawing.Size(400, 90);
            this.BPaySum.Name = "BPaySum";
            this.BPaySum.Size = new System.Drawing.Size(281, 90);
            this.BPaySum.TabIndex = 18;
            this.BPaySum.Text = "Всего оплачено: 12409";
            this.BPaySum.UseVisualStyleBackColor = true;
            this.BPaySum.Click += new System.EventHandler(this.журналОплатToolStripMenuItem_Click);
            // 
            // BServices
            // 
            this.BServices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BServices.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BServices.Location = new System.Drawing.Point(891, 522);
            this.BServices.MaximumSize = new System.Drawing.Size(400, 90);
            this.BServices.Name = "BServices";
            this.BServices.Size = new System.Drawing.Size(281, 90);
            this.BServices.TabIndex = 22;
            this.BServices.Text = "Услуг: 4";
            this.BServices.UseVisualStyleBackColor = true;
            this.BServices.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // BStreet
            // 
            this.BStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BStreet.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BStreet.Location = new System.Drawing.Point(602, 522);
            this.BStreet.MaximumSize = new System.Drawing.Size(400, 90);
            this.BStreet.Name = "BStreet";
            this.BStreet.Size = new System.Drawing.Size(281, 90);
            this.BStreet.TabIndex = 21;
            this.BStreet.Text = "Улиц: 8";
            this.BStreet.UseVisualStyleBackColor = true;
            this.BStreet.Click += new System.EventHandler(this.улицыToolStripMenuItem_Click);
            // 
            // BExecutor
            // 
            this.BExecutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BExecutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BExecutor.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BExecutor.Location = new System.Drawing.Point(315, 522);
            this.BExecutor.MaximumSize = new System.Drawing.Size(400, 90);
            this.BExecutor.Name = "BExecutor";
            this.BExecutor.Size = new System.Drawing.Size(281, 90);
            this.BExecutor.TabIndex = 20;
            this.BExecutor.Text = "Слесарей: 5";
            this.BExecutor.UseVisualStyleBackColor = true;
            this.BExecutor.Click += new System.EventHandler(this.слесариToolStripMenuItem_Click);
            // 
            // BDisrepair
            // 
            this.BDisrepair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.BDisrepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BDisrepair.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BDisrepair.Location = new System.Drawing.Point(28, 522);
            this.BDisrepair.MaximumSize = new System.Drawing.Size(400, 90);
            this.BDisrepair.Name = "BDisrepair";
            this.BDisrepair.Size = new System.Drawing.Size(281, 90);
            this.BDisrepair.TabIndex = 19;
            this.BDisrepair.Text = "Неисправностей: 9";
            this.BDisrepair.UseVisualStyleBackColor = true;
            this.BDisrepair.Click += new System.EventHandler(this.неисправностиToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 750);
            this.Controls.Add(this.BServices);
            this.Controls.Add(this.BStreet);
            this.Controls.Add(this.BExecutor);
            this.Controls.Add(this.BDisrepair);
            this.Controls.Add(this.BPaySum);
            this.Controls.Add(this.BNachislSum);
            this.Controls.Add(this.BRequest);
            this.Controls.Add(this.BAbonent);
            this.Controls.Add(this.BLogo);
            this.Controls.Add(this.labelInfoS);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1200, 726);
            this.Name = "Form_Main";
            this.Text = "Главное меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абонентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналНачисленийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналОплатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналЗаявокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem улицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem неисправностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem слесариToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem схемаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem профильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelInfoS;
        private System.Windows.Forms.Button BLogo;
        private System.Windows.Forms.Button BAbonent;
        private System.Windows.Forms.Button BRequest;
        private System.Windows.Forms.Button BNachislSum;
        private System.Windows.Forms.Button BPaySum;
        private System.Windows.Forms.Button BServices;
        private System.Windows.Forms.Button BStreet;
        private System.Windows.Forms.Button BExecutor;
        private System.Windows.Forms.Button BDisrepair;
    }
}

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  