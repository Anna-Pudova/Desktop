using System;
using System.Collections.Generic;

namespace MongoDB_Base
{
    [Serializable]
    public class User // Класс, который хранит регистрационные данные.
    {
        public List<string> Logins = new List<string>(); // Логин.
        public List<string> Passwords = new List<string>(); // Пароль.
    }
}
