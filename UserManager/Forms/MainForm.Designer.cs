using System.ComponentModel;

namespace UserManager.Forms;

partial class MainForm
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
        CreatedDateLabel = new System.Windows.Forms.Label();
        EmailLabel = new System.Windows.Forms.Label();
        UsernameLabel = new System.Windows.Forms.Label();
        WelcomeLabel = new System.Windows.Forms.Label();
        tabControl1 = new System.Windows.Forms.TabControl();
        userProfilePage = new System.Windows.Forms.TabPage();
        ChangePasswordButton = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        EditUserButton = new System.Windows.Forms.Button();
        LogoutButton = new System.Windows.Forms.Button();
        BioLabel = new System.Windows.Forms.Label();
        LastNameLabel = new System.Windows.Forms.Label();
        FirstNameLabel = new System.Windows.Forms.Label();
        hostingPlansPage = new System.Windows.Forms.TabPage();
        adminPanelPage = new System.Windows.Forms.TabPage();
        tabControl1.SuspendLayout();
        userProfilePage.SuspendLayout();
        SuspendLayout();
        // 
        // CreatedDateLabel
        // 
        CreatedDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        CreatedDateLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        CreatedDateLabel.Location = new System.Drawing.Point(15, 156);
        CreatedDateLabel.Name = "CreatedDateLabel";
        CreatedDateLabel.Size = new System.Drawing.Size(215, 39);
        CreatedDateLabel.TabIndex = 3;
        // 
        // EmailLabel
        // 
        EmailLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        EmailLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        EmailLabel.Location = new System.Drawing.Point(15, 117);
        EmailLabel.Name = "EmailLabel";
        EmailLabel.Size = new System.Drawing.Size(215, 39);
        EmailLabel.TabIndex = 2;
        // 
        // UsernameLabel
        // 
        UsernameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        UsernameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        UsernameLabel.Location = new System.Drawing.Point(15, 78);
        UsernameLabel.Name = "UsernameLabel";
        UsernameLabel.Size = new System.Drawing.Size(215, 39);
        UsernameLabel.TabIndex = 1;
        // 
        // WelcomeLabel
        // 
        WelcomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        WelcomeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        WelcomeLabel.Location = new System.Drawing.Point(15, 14);
        WelcomeLabel.Name = "WelcomeLabel";
        WelcomeLabel.Size = new System.Drawing.Size(509, 33);
        WelcomeLabel.TabIndex = 0;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(userProfilePage);
        tabControl1.Controls.Add(hostingPlansPage);
        tabControl1.Controls.Add(adminPanelPage);
        tabControl1.Location = new System.Drawing.Point(2, 0);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new System.Drawing.Size(797, 449);
        tabControl1.TabIndex = 1;
        // 
        // userProfilePage
        // 
        userProfilePage.Controls.Add(ChangePasswordButton);
        userProfilePage.Controls.Add(label1);
        userProfilePage.Controls.Add(EditUserButton);
        userProfilePage.Controls.Add(LogoutButton);
        userProfilePage.Controls.Add(BioLabel);
        userProfilePage.Controls.Add(LastNameLabel);
        userProfilePage.Controls.Add(FirstNameLabel);
        userProfilePage.Controls.Add(CreatedDateLabel);
        userProfilePage.Controls.Add(EmailLabel);
        userProfilePage.Controls.Add(UsernameLabel);
        userProfilePage.Controls.Add(WelcomeLabel);
        userProfilePage.Location = new System.Drawing.Point(4, 24);
        userProfilePage.Name = "userProfilePage";
        userProfilePage.Padding = new System.Windows.Forms.Padding(3);
        userProfilePage.Size = new System.Drawing.Size(789, 421);
        userProfilePage.TabIndex = 0;
        userProfilePage.Text = "Профиль";
        userProfilePage.UseVisualStyleBackColor = true;
        // 
        // ChangePasswordButton
        // 
        ChangePasswordButton.Location = new System.Drawing.Point(16, 329);
        ChangePasswordButton.Name = "ChangePasswordButton";
        ChangePasswordButton.Size = new System.Drawing.Size(214, 47);
        ChangePasswordButton.TabIndex = 10;
        ChangePasswordButton.Text = "Сменить пароль";
        ChangePasswordButton.UseVisualStyleBackColor = true;
        ChangePasswordButton.Click += ChangePasswordButton_Click;
        // 
        // label1
        // 
        label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label1.Location = new System.Drawing.Point(246, 90);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(278, 27);
        label1.TabIndex = 9;
        label1.Text = "Дополнительная информация";
        // 
        // EditUserButton
        // 
        EditUserButton.Location = new System.Drawing.Point(15, 276);
        EditUserButton.Name = "EditUserButton";
        EditUserButton.Size = new System.Drawing.Size(214, 47);
        EditUserButton.TabIndex = 8;
        EditUserButton.Text = "Изменить информацию";
        EditUserButton.UseVisualStyleBackColor = true;
        EditUserButton.Click += EditUserButton_Click;
        // 
        // LogoutButton
        // 
        LogoutButton.Location = new System.Drawing.Point(15, 382);
        LogoutButton.Name = "LogoutButton";
        LogoutButton.Size = new System.Drawing.Size(215, 32);
        LogoutButton.TabIndex = 7;
        LogoutButton.Text = "Выйти";
        LogoutButton.UseVisualStyleBackColor = true;
        LogoutButton.Click += LogOutButton_Click;
        // 
        // BioLabel
        // 
        BioLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        BioLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        BioLabel.Location = new System.Drawing.Point(246, 117);
        BioLabel.Name = "BioLabel";
        BioLabel.Size = new System.Drawing.Size(536, 300);
        BioLabel.TabIndex = 6;
        // 
        // LastNameLabel
        // 
        LastNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        LastNameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        LastNameLabel.Location = new System.Drawing.Point(15, 234);
        LastNameLabel.Name = "LastNameLabel";
        LastNameLabel.Size = new System.Drawing.Size(215, 39);
        LastNameLabel.TabIndex = 5;
        // 
        // FirstNameLabel
        // 
        FirstNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        FirstNameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        FirstNameLabel.Location = new System.Drawing.Point(15, 195);
        FirstNameLabel.Name = "FirstNameLabel";
        FirstNameLabel.Size = new System.Drawing.Size(215, 39);
        FirstNameLabel.TabIndex = 4;
        // 
        // hostingPlansPage
        // 
        hostingPlansPage.Location = new System.Drawing.Point(4, 24);
        hostingPlansPage.Name = "hostingPlansPage";
        hostingPlansPage.Padding = new System.Windows.Forms.Padding(3);
        hostingPlansPage.Size = new System.Drawing.Size(789, 421);
        hostingPlansPage.TabIndex = 1;
        hostingPlansPage.Text = "Ценовые планы";
        hostingPlansPage.UseVisualStyleBackColor = true;
        // 
        // adminPanelPage
        // 
        adminPanelPage.Location = new System.Drawing.Point(4, 24);
        adminPanelPage.Name = "adminPanelPage";
        adminPanelPage.Size = new System.Drawing.Size(789, 421);
        adminPanelPage.TabIndex = 2;
        adminPanelPage.Text = "Панель администратора";
        adminPanelPage.UseVisualStyleBackColor = true;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(tabControl1);
        Text = "Главное окно";
        tabControl1.ResumeLayout(false);
        userProfilePage.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button ChangePasswordButton;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button LogoutButton;
    private System.Windows.Forms.Button EditUserButton;

    private System.Windows.Forms.Label BioLabel;
    private System.Windows.Forms.Label LastNameLabel;
    private System.Windows.Forms.Label FirstNameLabel;

    private System.Windows.Forms.Label CreatedDateLabel;

    private System.Windows.Forms.Label UsernameLabel;

    private System.Windows.Forms.Label EmailLabel;

    private System.Windows.Forms.Label WelcomeLabel;

    private System.Windows.Forms.TabPage adminPanelPage;

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage userProfilePage;
    private System.Windows.Forms.TabPage hostingPlansPage;

    #endregion
}