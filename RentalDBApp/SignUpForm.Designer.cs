using System;

namespace RentalDBApp
{
    partial class signUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.signUpLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.RichTextBox();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.RichTextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.RichTextBox();
            this.emailTextBox = new System.Windows.Forms.RichTextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLabel.Location = new System.Drawing.Point(16, 22);
            this.signUpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(168, 48);
            this.signUpLabel.TabIndex = 0;
            this.signUpLabel.Text = "Sign Up";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameLabel.Location = new System.Drawing.Point(19, 102);
            this.firstnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(137, 29);
            this.firstnameLabel.TabIndex = 1;
            this.firstnameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.Silver;
            this.firstNameTextBox.Location = new System.Drawing.Point(25, 150);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(572, 46);
            this.firstNameTextBox.TabIndex = 2;
            this.firstNameTextBox.Text = "";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameLabel.Location = new System.Drawing.Point(19, 233);
            this.lastnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(136, 29);
            this.lastnameLabel.TabIndex = 3;
            this.lastnameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.Silver;
            this.lastNameTextBox.Location = new System.Drawing.Point(25, 278);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(572, 46);
            this.lastNameTextBox.TabIndex = 4;
            this.lastNameTextBox.Text = "";
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.LawnGreen;
            this.signUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Image = global::RentalDBApp.Properties.Resources.greenlight__1_;
            this.signUpButton.Location = new System.Drawing.Point(954, 264);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(196, 178);
            this.signUpButton.TabIndex = 5;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Silver;
            this.passwordTextBox.Location = new System.Drawing.Point(25, 410);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(572, 46);
            this.passwordTextBox.TabIndex = 6;
            this.passwordTextBox.Text = "";
            this.passwordTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.Silver;
            this.emailTextBox.Location = new System.Drawing.Point(24, 536);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(582, 46);
            this.emailTextBox.TabIndex = 7;
            this.emailTextBox.Text = "";
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(19, 360);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(124, 29);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(20, 491);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(78, 29);
            this.emailLabel.TabIndex = 9;
            this.emailLabel.Text = "Email";
            // 
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 767);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.signUpLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "signUpForm";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.RichTextBox firstNameTextBox;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.RichTextBox lastNameTextBox;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.RichTextBox passwordTextBox;
        private System.Windows.Forms.RichTextBox emailTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
    }
}