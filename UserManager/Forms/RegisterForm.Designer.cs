using System.ComponentModel;

namespace UserManager.Forms;

partial class RegisterForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        RegisterText = new System.Windows.Forms.Label();
        UsernameText = new System.Windows.Forms.Label();
        UsernameTextBox = new System.Windows.Forms.TextBox();
        PasswordTextBox = new System.Windows.Forms.TextBox();
        PasswordText = new System.Windows.Forms.Label();
        ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
        PasswordConfirmText = new System.Windows.Forms.Label();
        EmailTextBox = new System.Windows.Forms.TextBox();
        EmailText = new System.Windows.Forms.Label();
        RegisterButton = new System.Windows.Forms.Button();
        BackToLoginButton = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // RegisterText
        // 
        RegisterText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        RegisterText.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        RegisterText.Location = new System.Drawing.Point(101, 33);
        RegisterText.Name = "RegisterText";
        RegisterText.Size = new System.Drawing.Size(208, 33);
        RegisterText.TabIndex = 0;
        RegisterText.Text = "Форма регистрации";
        // 
        // UsernameText
        // 
        UsernameText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        UsernameText.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        UsernameText.Location = new System.Drawing.Point(101, 78);
        UsernameText.Name = "UsernameText";
        UsernameText.Size = new System.Drawing.Size(127, 22);
        UsernameText.TabIndex = 1;
        UsernameText.Text = "Имя пользователя";
        // 
        // UsernameTextBox
        // 
        UsernameTextBox.Location = new System.Drawing.Point(101, 103);
        UsernameTextBox.Name = "UsernameTextBox";
        UsernameTextBox.Size = new System.Drawing.Size(207, 23);
        UsernameTextBox.TabIndex = 2;
        // 
        // PasswordTextBox
        // 
        PasswordTextBox.Location = new System.Drawing.Point(101, 160);
        PasswordTextBox.Name = "PasswordTextBox";
        PasswordTextBox.Size = new System.Drawing.Size(207, 23);
        PasswordTextBox.TabIndex = 4;
        PasswordTextBox.UseSystemPasswordChar = true;
        // 
        // PasswordText
        // 
        PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        PasswordText.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        PasswordText.Location = new System.Drawing.Point(101, 135);
        PasswordText.Name = "PasswordText";
        PasswordText.Size = new System.Drawing.Size(58, 22);
        PasswordText.TabIndex = 3;
        PasswordText.Text = "Пароль";
        // 
        // ConfirmPasswordTextBox
        // 
        ConfirmPasswordTextBox.Location = new System.Drawing.Point(101, 216);
        ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
        ConfirmPasswordTextBox.Size = new System.Drawing.Size(207, 23);
        ConfirmPasswordTextBox.TabIndex = 6;
        ConfirmPasswordTextBox.UseSystemPasswordChar = true;
        // 
        // PasswordConfirmText
        // 
        PasswordConfirmText.AccessibleName = "";
        PasswordConfirmText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        PasswordConfirmText.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        PasswordConfirmText.Location = new System.Drawing.Point(101, 191);
        PasswordConfirmText.Name = "PasswordConfirmText";
        PasswordConfirmText.Size = new System.Drawing.Size(166, 22);
        PasswordConfirmText.TabIndex = 5;
        PasswordConfirmText.Text = "Подтверждение пароля";
        // 
        // EmailTextBox
        // 
        EmailTextBox.Location = new System.Drawing.Point(101, 272);
        EmailTextBox.Name = "EmailTextBox";
        EmailTextBox.Size = new System.Drawing.Size(207, 23);
        EmailTextBox.TabIndex = 8;
        // 
        // EmailText
        // 
        EmailText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        EmailText.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        EmailText.Location = new System.Drawing.Point(101, 247);
        EmailText.Name = "EmailText";
        EmailText.Size = new System.Drawing.Size(139, 22);
        EmailText.TabIndex = 7;
        EmailText.Text = "Электронная почта";
        // 
        // RegisterButton
        // 
        RegisterButton.Location = new System.Drawing.Point(101, 308);
        RegisterButton.Name = "RegisterButton";
        RegisterButton.Size = new System.Drawing.Size(208, 32);
        RegisterButton.TabIndex = 9;
        RegisterButton.Text = "Зарегистрироваться";
        RegisterButton.UseVisualStyleBackColor = true;
        RegisterButton.Click += RegisterButton_Click;
        // 
        // BackToLoginButton
        // 
        BackToLoginButton.Location = new System.Drawing.Point(198, 346);
        BackToLoginButton.Name = "BackToLoginButton";
        BackToLoginButton.Size = new System.Drawing.Size(111, 49);
        BackToLoginButton.TabIndex = 10;
        BackToLoginButton.Text = "Войти";
        BackToLoginButton.UseVisualStyleBackColor = true;
        BackToLoginButton.Click += BackToLoginButton_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label1.Location = new System.Drawing.Point(107, 346);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(85, 57);
        label1.TabIndex = 11;
        label1.Text = "Уже есть профиль? Войдите!";
        // 
        // RegisterForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(404, 426);
        Controls.Add(label1);
        Controls.Add(BackToLoginButton);
        Controls.Add(RegisterButton);
        Controls.Add(EmailTextBox);
        Controls.Add(EmailText);
        Controls.Add(ConfirmPasswordTextBox);
        Controls.Add(PasswordConfirmText);
        Controls.Add(PasswordTextBox);
        Controls.Add(PasswordText);
        Controls.Add(UsernameTextBox);
        Controls.Add(UsernameText);
        Controls.Add(RegisterText);
        Text = "Регистрация";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button RegisterButton;
    private System.Windows.Forms.Button BackToLoginButton;

    private System.Windows.Forms.TextBox PasswordTextBox;
    private System.Windows.Forms.Label PasswordText;
    private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
    private System.Windows.Forms.Label PasswordConfirmText;
    private System.Windows.Forms.TextBox EmailTextBox;
    private System.Windows.Forms.Label EmailText;

    private System.Windows.Forms.TextBox UsernameTextBox;

    private System.Windows.Forms.Label UsernameText;

    private System.Windows.Forms.Label RegisterText;

    #endregion
}