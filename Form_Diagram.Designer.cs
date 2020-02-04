namespace MongoDB_Base
{
    partial class Form_Diagram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Diagram));
            this.pictureBoxDiagram = new System.Windows.Forms.PictureBox();
            this.BMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiagram)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDiagram
            // 
            this.pictureBoxDiagram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDiagram.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDiagram.Image")));
            this.pictureBoxDiagram.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDiagram.InitialImage")));
            this.pictureBoxDiagram.Location = new System.Drawing.Point(-2, -1);
            this.pictureBoxDiagram.Name = "pictureBoxDiagram";
            this.pictureBoxDiagram.Size = new System.Drawing.Size(752, 695);
            this.pictureBoxDiagram.TabIndex = 0;
            this.pictureBoxDiagram.TabStop = false;
            // 
            // BMain
            // 
            this.BMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BMain.Location = new System.Drawing.Point(620, 617);
            this.BMain.Name = "BMain";
            this.BMain.Size = new System.Drawing.Size(108, 23);
            this.BMain.TabIndex = 1;
            this.BMain.Text = "Главное меню";
            this.BMain.UseVisualStyleBackColor = true;
            this.BMain.Click += new System.EventHandler(this.BMain_Click);
            // 
            // Form_Diagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 652);
            this.Controls.Add(this.BMain);
            this.Controls.Add(this.pictureBoxDiagram);
            this.MaximizeBox = false;
            this.Name = "Form_Diagram";
            this.Text = "Схема данных";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiagram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDiagram;
        private System.Windows.Forms.Button BMain;
    }
}