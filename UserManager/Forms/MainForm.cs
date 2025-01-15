using UserManager.Services;
using UserManager.Models;

namespace UserManager.Forms
{
    public partial class MainForm : Form
    {
        private readonly IUserService _userService;
        private readonly IUserProfileService _userProfileService;
        private readonly IAuthenticationService _authenticationService;

        private int _userId;

        public MainForm(IUserService userService, IUserProfileService userProfileService,
            IAuthenticationService authenticationService)
        {
            _userService = userService;
            _userProfileService = userProfileService;
            _authenticationService = authenticationService;
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var loggedInUser = await _authenticationService.GetLoggedInUserAsync();

            if (loggedInUser != null)
            {
                _userId = loggedInUser.UserId;
                // Приветственное сообщение
                WelcomeLabel.Text = $"Добро пожаловать, {loggedInUser.Username}!";

                // Показываем соответствующий интерфейс в зависимости от роли
                if (loggedInUser.Roles.Any(r => r.RoleName == "Admin"))
                {
                    ShowAdminView();
                }
                else
                {
                    ShowUserView();
                }
            }
            else
            {
                // Перенаправление на экран входа
                RedirectToLoginForm();
            }
        }

        private void ShowUserView()
        {
            adminPanelPage.Visible = false;
            userProfilePage.Visible = true;
            hostingPlansPage.Visible = true;
        }

        private void ShowAdminView()
        {
            adminPanelPage.Visible = true;
            userProfilePage.Visible = true;
            hostingPlansPage.Visible = true;
        }

        private void RedirectToLoginForm()
        {
            var loginForm = new LoginForm(_userService, _userProfileService, _authenticationService);
            loginForm.Show();
            this.Hide();
        }

        private async void LogOutButton_Click(object sender, EventArgs e)
        {
            await _authenticationService.LogOutAsync();
            RedirectToLoginForm();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            var changePasswordForm = new ChangePasswordForm(_authenticationService, _userId);
            changePasswordForm.ShowDialog();
        }

        private async void EditUserButton_Click(object sender, EventArgs e)
        {
            var loggedInUser = await _authenticationService.GetLoggedInUserAsync();
            if (loggedInUser == null)
            {
                MessageBox.Show("Ошибка авторизации. Попробуйте войти снова.");
                RedirectToLoginForm();
                return;
            }

            var userProfile = await _userProfileService.GetUserProfileByIdAsync(loggedInUser.UserId);

            var dialog = new UserDialogForm(loggedInUser, userProfile);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                loggedInUser.Username = dialog.Username;
                loggedInUser.Email = dialog.Email;
                userProfile.FirstName = dialog.FirstName;
                userProfile.LastName = dialog.LastName;
                userProfile.Bio = dialog.Bio;

                await _userService.UpdateUserAsync(loggedInUser);
                await _userProfileService.UpdateUserProfileAsync(userProfile);

                MessageBox.Show("Информация успешно обновлена.", "Успех", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
