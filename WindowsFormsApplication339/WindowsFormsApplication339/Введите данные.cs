using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Linq;

namespace WindowsFormsApplication339
{
    public partial class Form1 : Form
    {
        private Users users;
        private string fileName;

        public Form1()
        {
            InitializeComponent();

            //получаем папку, где хранятся данные
            var fileDir = AppDomain.CurrentDomain.BaseDirectory;

            //получаем имя файла
            fileName = Path.Combine(fileDir, "users.bin");

            //если файл существует - загружаем его, если нет - создаем новый объект Users
            if (File.Exists(fileName))
                using (var fs = File.OpenRead(fileName))
                    users = (Users)new BinaryFormatter().Deserialize(fs);
            else
                users = new Users();
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbSignup.Checked)
                {
                    //регстрация нового юзера
                    users.SignupNewUser(tbUser.Text, tbPassword.Text);
                    //сохраняем юзеров в файл
                    using (var fs = File.OpenWrite(fileName))
                        new BinaryFormatter().Serialize(fs, users);
                }else
                {
                    //вход существующего юзера
                    users.SignIn(tbUser.Text, tbPassword.Text);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;//выходим из метода, не открыв главную форму приложения
            }

            //открываем главную форму приложения...
            Hide();
            new Form2().ShowDialog(this);
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }
    }

    /// <summary>
    /// Пользователи
    /// </summary>
    [Serializable]
    class Users : List<User>
    {
        /// <summary>
        /// Вход пользователя
        /// </summary>
        public bool SignIn(string login, string password)
        {
            //ищем юзера по логину
            var user = this.FirstOrDefault(u=>u.Login == login);
            if (user == null) throw new Exception("User login is unknown.");

            //проверяем пароль
            if (user.PasswordHash != password.GetHashCode()) throw new Exception("User password is incorrect.");

            return true;
        }

        /// <summary>
        /// Регистрация нового пользователя
        /// </summary>
        public void SignupNewUser(string login, string password)
        {
            //проверяем, нет ли такого пользователя
            if (this.Any(u => u.Login == login))
                throw new Exception("User with same name exists already.");

            Add(new User(login, password));
        }
    }

    /// <summary>
    /// Пользователь
    /// </summary>
    [Serializable]
    class User
    {
        public string Login;
        public int PasswordHash;

        public User(string login, string password)
        {
            Login = login;
            PasswordHash = password.GetHashCode();
        }
      

        
    }
    }

