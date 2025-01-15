using System;
using System.Windows.Forms;
using UserManager.Services;
using UserManager.Models;

namespace UserManager.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly IUserService _userService;
        private readonly IPasswordHasher _passwordHasher;

        public RegisterForm(IUserService userService, IPasswordHasher passwordHasher)
        {
            _userService = userService;
            _passwordHasher = passwordHasher;
            InitializeComponent();
        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            var username = UsernameTextBox.Text;
            var password = PasswordTextBox.Text;
            var confirmPassword = ConfirmPasswordTextBox.Text;
            var email = EmailTextBox.Text;

            // Проверка на заполнение всех полей
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || 
                string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Все поля обязательны для заполнения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка совпадения паролей
            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Хешируем пароль через интерфейс IPasswordHasher
                var hashedPassword = _passwordHasher.HashPassword(password);

                // Вызов метода для регистрации пользователя с хешированным паролем
                await _userService.RegisterUserAsync(username, hashedPassword, email);

                MessageBox.Show("Регистрация успешно завершена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Переход на форму логина
                var loginForm = new LoginForm(_userService);
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackToLoginButton_Click(object sender, EventArgs e)
        {
            NavigateToLogin();
        }

        private void NavigateToLogin()
        {
            var loginForm = new LoginForm(_userService);
            loginForm.Show();
            this.Hide();
        }
    }
}