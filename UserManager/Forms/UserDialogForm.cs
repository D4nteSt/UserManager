using System;
using System.Windows.Forms;
using UserManager.Models;

namespace UserManager.Forms
{
    public partial class UserDialogForm : Form
    {
        public string Username { get; private set; }
        public string Email { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Bio { get; private set; }

        public UserDialogForm(User user, UserProfile userProfile)
        {
            InitializeComponent();

            // Заполнение полей значениями
            UsernameTextBox.Text = user.Username;
            EmailTextBox.Text = user.Email;
            FirstNameTextBox.Text = userProfile.FirstName;
            LastNameTextBox.Text = userProfile.LastName;
            BioTextBox.Text = userProfile.Bio;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Сохраняем данные из полей в свойства
            Username = UsernameTextBox.Text;
            Email = EmailTextBox.Text;
            FirstName = FirstNameTextBox.Text;
            LastName = LastNameTextBox.Text;
            Bio = BioTextBox.Text;

            DialogResult = DialogResult.OK; // Устанавливаем результат
            Close();
        }

        private void DialogCancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Закрытие без сохранения
            Close();
        }
    }
}