using System.ComponentModel;

namespace UserManager.Forms;

partial class ChangePasswordForm
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
        CurrentPasswordLabel = new System.Windows.Forms.Label();
        CurrentPasswordTextBox = new System.Windows.Forms.TextBox();
        NewPasswordTextBox = new System.Windows.Forms.TextBox();
        NewPasswordLabel = new System.Windows.Forms.Label();
        ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
        ConfirmPasswordLabel = new System.Windows.Forms.Label();
        ChangePasswordButton = new System.Windows.Forms.Button();
        CancelDialogButton = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // CurrentPasswordLabel
        // 
        CurrentPasswordLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        CurrentPasswordLabel.Location = new System.Drawing.Point(41, 121);
        CurrentPasswordLabel.Name = "CurrentPasswordLabel";
        CurrentPasswordLabel.Size = new System.Drawing.Size(169, 23);
        CurrentPasswordLabel.TabIndex = 0;
        CurrentPasswordLabel.Text = "Текущий пароль:";
        // 
        // CurrentPasswordTextBox
        // 
        CurrentPasswordTextBox.Location = new System.Drawing.Point(216, 121);
        CurrentPasswordTextBox.Name = "CurrentPasswordTextBox";
        CurrentPasswordTextBox.Size = new System.Drawing.Size(187, 23);
        CurrentPasswordTextBox.TabIndex = 1;
        CurrentPasswordTextBox.UseSystemPasswordChar = true;
        // 
        // NewPasswordTextBox
        // 
        NewPasswordTextBox.Location = new System.Drawing.Point(216, 161);
        NewPasswordTextBox.Name = "NewPasswordTextBox";
        NewPasswordTextBox.Size = new System.Drawing.Size(187, 23);
        NewPasswordTextBox.TabIndex = 3;
        NewPasswordTextBox.UseSystemPasswordChar = true;
        // 
        // NewPasswordLabel
        // 
        NewPasswordLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        NewPasswordLabel.Location = new System.Drawing.Point(41, 161);
        NewPasswordLabel.Name = "NewPasswordLabel";
        NewPasswordLabel.Size = new System.Drawing.Size(169, 23);
        NewPasswordLabel.TabIndex = 2;
        NewPasswordLabel.Text = "Новый пароль:";
        // 
        // ConfirmPasswordTextBox
        // 
        ConfirmPasswordTextBox.Location = new System.Drawing.Point(216, 201);
        ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
        ConfirmPasswordTextBox.Size = new System.Drawing.Size(187, 23);
        ConfirmPasswordTextBox.TabIndex = 5;
        ConfirmPasswordTextBox.UseSystemPasswordChar = true;
        // 
        // ConfirmPasswordLabel
        // 
        ConfirmPasswordLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        ConfirmPasswordLabel.Location = new System.Drawing.Point(41, 201);
        ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
        ConfirmPasswordLabel.Size = new System.Drawing.Size(169, 23);
        ConfirmPasswordLabel.TabIndex = 4;
        ConfirmPasswordLabel.Text = "Подтверждение:";
        // 
        // ChangePasswordButton
        // 
        ChangePasswordButton.Location = new System.Drawing.Point(216, 243);
        ChangePasswordButton.Name = "ChangePasswordButton";
        ChangePasswordButton.Size = new System.Drawing.Size(187, 33);
        ChangePasswordButton.TabIndex = 6;
        ChangePasswordButton.Text = "Изменить пароль";
        ChangePasswordButton.UseVisualStyleBackColor = true;
        ChangePasswordButton.Click += ChangePasswordButton_Click;
        // 
        // CancelDialogButton
        // 
        CancelDialogButton.Location = new System.Drawing.Point(41, 243);
        CancelDialogButton.Name = "CancelDialogButton";
        CancelDialogButton.Size = new System.Drawing.Size(169, 33);
        CancelDialogButton.TabIndex = 7;
        CancelDialogButton.Text = "Отмена";
        CancelDialogButton.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label1.Location = new System.Drawing.Point(41, 66);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(384, 52);
        label1.TabIndex = 8;
        label1.Text = "Введите данные для смены пароля";
        // 
        // ChangePasswordForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(444, 340);
        Controls.Add(label1);
        Controls.Add(CancelDialogButton);
        Controls.Add(ChangePasswordButton);
        Controls.Add(ConfirmPasswordTextBox);
        Controls.Add(ConfirmPasswordLabel);
        Controls.Add(NewPasswordTextBox);
        Controls.Add(NewPasswordLabel);
        Controls.Add(CurrentPasswordTextBox);
        Controls.Add(CurrentPasswordLabel);
        Text = "Изменение пароля";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button ChangePasswordButton;
    private System.Windows.Forms.Button CancelDialogButton;

    private System.Windows.Forms.TextBox NewPasswordTextBox;
    private System.Windows.Forms.Label NewPasswordLabel;
    private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
    private System.Windows.Forms.Label ConfirmPasswordLabel;

    private System.Windows.Forms.TextBox CurrentPasswordTextBox;

    private System.Windows.Forms.Label CurrentPasswordLabel;

    #endregion
}