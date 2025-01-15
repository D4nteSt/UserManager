using System.ComponentModel;

namespace UserManager.Forms;

partial class UserDialogForm
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
        UsernameLabel = new System.Windows.Forms.Label();
        EmailLabel = new System.Windows.Forms.Label();
        FirstNameLabel = new System.Windows.Forms.Label();
        LastNameLabel = new System.Windows.Forms.Label();
        BioLabel = new System.Windows.Forms.Label();
        BioTextBox = new System.Windows.Forms.RichTextBox();
        UsernameTextBox = new System.Windows.Forms.TextBox();
        EmailTextBox = new System.Windows.Forms.TextBox();
        FirstNameTextBox = new System.Windows.Forms.TextBox();
        LastNameTextBox = new System.Windows.Forms.TextBox();
        SaveButton = new System.Windows.Forms.Button();
        DialogCancelButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // UsernameLabel
        // 
        UsernameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        UsernameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        UsernameLabel.Location = new System.Drawing.Point(23, 21);
        UsernameLabel.Name = "UsernameLabel";
        UsernameLabel.Size = new System.Drawing.Size(167, 30);
        UsernameLabel.TabIndex = 0;
        UsernameLabel.Text = "Имя пользователя";
        // 
        // EmailLabel
        // 
        EmailLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        EmailLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        EmailLabel.Location = new System.Drawing.Point(23, 74);
        EmailLabel.Name = "EmailLabel";
        EmailLabel.Size = new System.Drawing.Size(167, 30);
        EmailLabel.TabIndex = 1;
        EmailLabel.Text = "Email";
        // 
        // FirstNameLabel
        // 
        FirstNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        FirstNameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        FirstNameLabel.Location = new System.Drawing.Point(23, 132);
        FirstNameLabel.Name = "FirstNameLabel";
        FirstNameLabel.Size = new System.Drawing.Size(167, 30);
        FirstNameLabel.TabIndex = 2;
        FirstNameLabel.Text = "Имя";
        // 
        // LastNameLabel
        // 
        LastNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        LastNameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        LastNameLabel.Location = new System.Drawing.Point(23, 197);
        LastNameLabel.Name = "LastNameLabel";
        LastNameLabel.Size = new System.Drawing.Size(167, 30);
        LastNameLabel.TabIndex = 3;
        LastNameLabel.Text = "Фамилия";
        // 
        // BioLabel
        // 
        BioLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        BioLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        BioLabel.Location = new System.Drawing.Point(23, 261);
        BioLabel.Name = "BioLabel";
        BioLabel.Size = new System.Drawing.Size(167, 30);
        BioLabel.TabIndex = 4;
        BioLabel.Text = "О вас";
        // 
        // BioTextBox
        // 
        BioTextBox.Location = new System.Drawing.Point(221, 261);
        BioTextBox.Name = "BioTextBox";
        BioTextBox.Size = new System.Drawing.Size(406, 173);
        BioTextBox.TabIndex = 6;
        BioTextBox.Text = "";
        // 
        // UsernameTextBox
        // 
        UsernameTextBox.Location = new System.Drawing.Point(221, 21);
        UsernameTextBox.Name = "UsernameTextBox";
        UsernameTextBox.Size = new System.Drawing.Size(206, 23);
        UsernameTextBox.TabIndex = 7;
        // 
        // EmailTextBox
        // 
        EmailTextBox.Location = new System.Drawing.Point(221, 74);
        EmailTextBox.Name = "EmailTextBox";
        EmailTextBox.Size = new System.Drawing.Size(206, 23);
        EmailTextBox.TabIndex = 8;
        // 
        // FirstNameTextBox
        // 
        FirstNameTextBox.Location = new System.Drawing.Point(221, 132);
        FirstNameTextBox.Name = "FirstNameTextBox";
        FirstNameTextBox.Size = new System.Drawing.Size(206, 23);
        FirstNameTextBox.TabIndex = 9;
        // 
        // LastNameTextBox
        // 
        LastNameTextBox.Location = new System.Drawing.Point(221, 197);
        LastNameTextBox.Name = "LastNameTextBox";
        LastNameTextBox.Size = new System.Drawing.Size(206, 23);
        LastNameTextBox.TabIndex = 10;
        // 
        // SaveButton
        // 
        SaveButton.Location = new System.Drawing.Point(23, 311);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new System.Drawing.Size(167, 36);
        SaveButton.TabIndex = 11;
        SaveButton.Text = "Сохранить";
        SaveButton.UseVisualStyleBackColor = true;
        // 
        // DialogCancelButton
        // 
        DialogCancelButton.Location = new System.Drawing.Point(23, 370);
        DialogCancelButton.Name = "DialogCancelButton";
        DialogCancelButton.Size = new System.Drawing.Size(167, 36);
        DialogCancelButton.TabIndex = 12;
        DialogCancelButton.Text = "Отмена";
        DialogCancelButton.UseVisualStyleBackColor = true;
        DialogCancelButton.Click += DialogCancelButton_Click;
        // 
        // UserDialogForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(639, 445);
        Controls.Add(DialogCancelButton);
        Controls.Add(SaveButton);
        Controls.Add(LastNameTextBox);
        Controls.Add(FirstNameTextBox);
        Controls.Add(EmailTextBox);
        Controls.Add(UsernameTextBox);
        Controls.Add(BioTextBox);
        Controls.Add(BioLabel);
        Controls.Add(LastNameLabel);
        Controls.Add(FirstNameLabel);
        Controls.Add(EmailLabel);
        Controls.Add(UsernameLabel);
        Text = "Изменение";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button DialogCancelButton;

    private System.Windows.Forms.RichTextBox BioTextBox;
    private System.Windows.Forms.TextBox UsernameTextBox;
    private System.Windows.Forms.TextBox EmailTextBox;
    private System.Windows.Forms.TextBox FirstNameTextBox;
    private System.Windows.Forms.TextBox LastNameTextBox;
    private System.Windows.Forms.Button SaveButton;

    private System.Windows.Forms.Label EmailLabel;
    private System.Windows.Forms.Label FirstNameLabel;
    private System.Windows.Forms.Label LastNameLabel;
    private System.Windows.Forms.Label BioLabel;

    private System.Windows.Forms.Label UsernameLabel;

    #endregion
}