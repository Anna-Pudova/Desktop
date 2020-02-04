namespace MongoDB_Base
{
    partial class Form_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Registration));
            this.LPassword = new System.Windows.Forms.Label();
            this.LLogin = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.LInfo = new System.Windows.Forms.Label();
            this.LINFOS = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LPassword.Location = new System.Drawing.Point(83, 165);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(76, 24);
            this.LPassword.TabIndex = 12;
            this.LPassword.Text = "Пароль";
            // 
            // LLogin
            // 
            this.LLogin.AutoSize = true;
            this.LLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LLogin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LLogin.Location = new System.Drawing.Point(83, 104);
            this.LLogin.Name = "LLogin";
            this.LLogin.Size = new System.Drawing.Size(64, 24);
            this.LLogin.TabIndex = 11;
            this.LLogin.Text = "Логин";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(204, 165);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(194, 20);
            this.passwordTextBox.TabIndex = 10;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(204, 104);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(194, 20);
            this.loginTextBox.TabIndex = 9;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.exitButton.Location = new System.Drawing.Point(425, 157);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(89, 32);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Отмена";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.enterButton.Location = new System.Drawing.Point(425, 101);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(89, 33);
            this.enterButton.TabIndex = 7;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // LInfo
            // 
            this.LInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LInfo.AutoSize = true;
            this.LInfo.BackColor = System.Drawing.SystemColors.Control;
            this.LInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LInfo.Location = new System.Drawing.Point(82, 19);
            this.LInfo.Name = "LInfo";
            this.LInfo.Size = new System.Drawing.Size(427, 20);
            this.LInfo.TabIndex = 13;
            this.LInfo.Text = "Демонстрационное приложение учебной БД \"Абонент\"";
            // 
            // LINFOS
            // 
            this.LINFOS.AutoSize = true;
            this.LINFOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LINFOS.Location = new System.Drawing.Point(84, 64);
            this.LINFOS.Name = "LINFOS";
            this.LINFOS.Size = new System.Drawing.Size(203, 17);
            this.LINFOS.TabIndex = 14;
            this.LINFOS.Text = "Введите Ваш логин и пароль:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 73);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 213);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LINFOS);
            this.Controls.Add(this.LInfo);
            this.Controls.Add(this.LPassword);
            this.Controls.Add(this.LLogin);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.enterButton);
            this.MaximizeBox = false;
            this.Name = "Form_Registration";
            this.Text = "Ввод пароля";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Registration_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.Label LLogin;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label LInfo;
        private System.Windows.Forms.Label LINFOS;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}