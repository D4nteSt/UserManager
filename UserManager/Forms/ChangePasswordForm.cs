using UserManager.Services;

namespace UserManager.Forms;

public partial class ChangePasswordForm : Form
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly int _userId;

        public ChangePasswordForm(IAuthenticationService authenticationService, int userId)
        {
            _authenticationService = authenticationService;
            _userId = userId;
            InitializeComponent();
        }

        private async void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            var oldPassword = CurrentPasswordTextBox.Text;
            var newPassword = NewPasswordTextBox.Text;
            var confirmPassword = ConfirmPasswordTextBox.Text;

            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Все поля обязательны для заполнения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка совпадения нового пароля с подтверждением
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Вызов метода для изменения пароля через сервис аутентификации
                await _authenticationService.ChangePasswordAsync(_userId, oldPassword, newPassword);

                MessageBox.Show("Пароль успешно изменен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Закрытие формы после успешного изменения пароля
                this.Close();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Текущий пароль введен неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

