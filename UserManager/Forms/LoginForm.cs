using System;
using System.Windows.Forms;
using UserManager.Services;

namespace UserManager.Forms;

public partial class LoginForm : Form
{
    private readonly IUserService _userService;
    private readonly IAuthenticationService _authenticationService;
    private readonly IUserProfileService _userProfileService;
    private readonly IPasswordHasher _passwordHasher;

    public LoginForm(IUserService userService, IUserProfileService userProfileService, IAuthenticationService authenticationService, IPasswordHasher passwordHasher)
    {
        _userService = userService;
        _userProfileService = userProfileService;
        _authenticationService = authenticationService;
        _passwordHasher = passwordHasher; // Внедрение интерфейса для работы с паролями
        InitializeComponent();
    }

    private async void LoginButton_Click(object sender, EventArgs e)
    {
        var username = UsernameTextBox.Text.Trim();
        var password = PasswordTextBox.Text;

        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            MessageBox.Show("Введите имя пользователя и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            // Попытка аутентификации
            var user = await _authenticationService.AuthenticateAsync(username, password);

            if (user != null)
            {
                MessageBox.Show("Вход выполнен успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Переход к основной форме
                var mainForm = new MainForm(_userService, _userProfileService, _authenticationService);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверные имя пользователя или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void RegisterButton_Click(object sender, EventArgs e)
    {
        // Переход к форме регистрации
        var registerForm = new RegisterForm(_userService, _authenticationService);
        registerForm.Show();
        this.Hide();
    }
}