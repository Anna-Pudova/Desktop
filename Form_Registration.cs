using System;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace MongoDB_Base
{
    public partial class Form_Registration : Form
    {
        /* Переменные, которые будут хранить на протяжение работы программы логин и пароль. */
        public string login = string.Empty;
        public string password = string.Empty;
        private User user = new User(); // Экземпляр класса пользователей.
        public Form_Registration()
        {
            InitializeComponent();
            LoadUsers(); // Метод десериализует класс.
        }

        private void LoadUsers()
        {
            try
            {
                FileStream fs = new FileStream("User.dat", FileMode.Open);

                BinaryFormatter formatter = new BinaryFormatter();

                user = (User)formatter.Deserialize(fs);

                fs.Close();
            }
            catch { return; }
        }

        private void EnterToForm()
        {
            for (int i = 0; i < user.Logins.Count; i++) // Ищем пользователя и проверяем правильность пароля.
            {
                if (user.Logins[i] == loginTextBox.Text && user.Passwords[i] == passwordTextBox.Text)
                {
                    login = user.Logins[i];
                    password = user.Passwords[i];
                    Form Form = new Form_Main();
                    Form.Show();
                    this.Visible = false;
                }
                else if (user.Logins[i] == loginTextBox.Text && passwordTextBox.Text != user.Passwords[i])
                {
                    login = user.Logins[i];
                    MessageBox.Show("Неверный пароль!");
                }
            }
            if (login == "") { MessageBox.Show("Пользователь " + loginTextBox.Text + " не найден!"); }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            EnterToForm();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Закрываем программу.
        }

        private void Form_Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (login == "" | password == "") { Application.Exit(); }
        }
    }
}
