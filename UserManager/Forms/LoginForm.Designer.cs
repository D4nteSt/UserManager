using System.ComponentModel;

namespace UserManager.Forms;

partial class LoginForm
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
        LoginFormText = new System.Windows.Forms.Label();
        UsernameTextBox = new System.Windows.Forms.TextBox();
        UsernameText = new System.Windows.Forms.Label();
        PasswordText = new System.Windows.Forms.Label();
        PasswordTextBox = new System.Windows.Forms.TextBox();
        LoginButton = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        RegisterButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // LoginFormText
        // 
        LoginFormText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        LoginFormText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        LoginFormText.Location = new System.Drawing.Point(98, 45);
        LoginFormText.Name = "LoginFormText";
        LoginFormText.Size = new System.Drawing.Size(319, 31);
        LoginFormText.TabIndex = 0;
        LoginFormText.Text = "Введите имя пользователя и пароль";
        // 
        // UsernameTextBox
        // 
        UsernameTextBox.Location = new System.Drawing.Point(130, 118);
        UsernameTextBox.Name = "UsernameTextBox";
        UsernameTextBox.Size = new System.Drawing.Size(216, 23);
        UsernameTextBox.TabIndex = 1;
        // 
        // UsernameText
        // 
        UsernameText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        UsernameText.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        UsernameText.Location = new System.Drawing.Point(130, 92);
        UsernameText.Name = "UsernameText";
        UsernameText.Size = new System.Drawing.Size(135, 23);
        UsernameText.TabIndex = 2;
        UsernameText.Text = "Имя пользователя";
        // 
        // PasswordText
        // 
        PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        PasswordText.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        PasswordText.Location = new System.Drawing.Point(130, 170);
        PasswordText.Name = "PasswordText";
        PasswordText.Size = new System.Drawing.Size(61, 23);
        PasswordText.TabIndex = 3;
        PasswordText.Text = "Пароль";
        // 
        // PasswordTextBox
        // 
        PasswordTextBox.Location = new System.Drawing.Point(130, 196);
        PasswordTextBox.Name = "PasswordTextBox";
        PasswordTextBox.Size = new System.Drawing.Size(216, 23);
        PasswordTextBox.TabIndex = 4;
        PasswordTextBox.UseSystemPasswordChar = true;
        // 
        // LoginButton
        // 
        LoginButton.Location = new System.Drawing.Point(130, 225);
        LoginButton.Name = "LoginButton";
        LoginButton.Size = new System.Drawing.Size(216, 35);
        LoginButton.TabIndex = 5;
        LoginButton.Text = "Войти";
        LoginButton.UseVisualStyleBackColor = true;
        LoginButton.Click += LoginButton_Click;
        // 
        // label1
        // 
        label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label1.Location = new System.Drawing.Point(130, 289);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(216, 45);
        label1.TabIndex = 6;
        label1.Text = "Нет профиля? Зарегистрируйтесь!";
        // 
        // RegisterButton
        // 
        RegisterButton.Location = new System.Drawing.Point(130, 346);
        RegisterButton.Name = "RegisterButton";
        RegisterButton.Size = new System.Drawing.Size(216, 35);
        RegisterButton.TabIndex = 7;
        RegisterButton.Text = "Регистрация";
        RegisterButton.UseVisualStyleBackColor = true;
        RegisterButton.Click += RegisterButton_Click;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(514, 421);
        Controls.Add(RegisterButton);
        Controls.Add(label1);
        Controls.Add(LoginButton);
        Controls.Add(PasswordTextBox);
        Controls.Add(PasswordText);
        Controls.Add(UsernameText);
        Controls.Add(UsernameTextBox);
        Controls.Add(LoginFormText);
        Text = "Вход";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button RegisterButton;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button LoginButton;

    private System.Windows.Forms.Label PasswordText;
    private System.Windows.Forms.TextBox PasswordTextBox;

    private System.Windows.Forms.Label UsernameText;

    private System.Windows.Forms.TextBox UsernameTextBox;

    private System.Windows.Forms.Label LoginFormText;

    #endregion
}