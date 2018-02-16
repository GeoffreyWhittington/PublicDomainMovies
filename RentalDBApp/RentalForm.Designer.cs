namespace RentalDBApp
{
    partial class RentalForm
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
            this.movieLabel = new System.Windows.Forms.Label();
            this.memberLabel = new System.Windows.Forms.Label();
            this.checkoutLabel = new System.Windows.Forms.Label();
            this.returndateLabel = new System.Windows.Forms.Label();
            this.movieTextBox = new System.Windows.Forms.TextBox();
            this.memberTextBox = new System.Windows.Forms.TextBox();
            this.checkoutTextBox = new System.Windows.Forms.TextBox();
            this.returndateTextBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Location = new System.Drawing.Point(47, 50);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(36, 13);
            this.movieLabel.TabIndex = 0;
            this.movieLabel.Text = "Movie";
            // 
            // memberLabel
            // 
            this.memberLabel.AutoSize = true;
            this.memberLabel.Location = new System.Drawing.Point(47, 124);
            this.memberLabel.Name = "memberLabel";
            this.memberLabel.Size = new System.Drawing.Size(45, 13);
            this.memberLabel.TabIndex = 1;
            this.memberLabel.Text = "MEMBER";
            // 
            // checkoutLabel
            // 
            this.checkoutLabel.AutoSize = true;
            this.checkoutLabel.Location = new System.Drawing.Point(47, 204);
            this.checkoutLabel.Name = "checkoutLabel";
            this.checkoutLabel.Size = new System.Drawing.Size(79, 13);
            this.checkoutLabel.TabIndex = 2;
            this.checkoutLabel.Text = "Checkout Date";
            // 
            // returndateLabel
            // 
            this.returndateLabel.AutoSize = true;
            this.returndateLabel.Location = new System.Drawing.Point(47, 284);
            this.returndateLabel.Name = "returndateLabel";
            this.returndateLabel.Size = new System.Drawing.Size(65, 13);
            this.returndateLabel.TabIndex = 3;
            this.returndateLabel.Text = "Return Date";
            // 
            // movieTextBox
            // 
            this.movieTextBox.Location = new System.Drawing.Point(104, 47);
            this.movieTextBox.Name = "movieTextBox";
            this.movieTextBox.Size = new System.Drawing.Size(100, 20);
            this.movieTextBox.TabIndex = 4;
            // 
            // memberTextBox
            // 
            this.memberTextBox.Location = new System.Drawing.Point(104, 121);
            this.memberTextBox.Name = "memberTextBox";
            this.memberTextBox.Size = new System.Drawing.Size(100, 20);
            this.memberTextBox.TabIndex = 5;
            // 
            // checkoutTextBox
            // 
            this.checkoutTextBox.Location = new System.Drawing.Point(132, 201);
            this.checkoutTextBox.Name = "checkoutTextBox";
            this.checkoutTextBox.Size = new System.Drawing.Size(72, 20);
            this.checkoutTextBox.TabIndex = 6;
            // 
            // returndateTextBox
            // 
            this.returndateTextBox.Location = new System.Drawing.Point(132, 281);
            this.returndateTextBox.Name = "returndateTextBox";
            this.returndateTextBox.Size = new System.Drawing.Size(72, 20);
            this.returndateTextBox.TabIndex = 7;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(211, 355);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 52);
            this.findButton.TabIndex = 9;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(437, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 52);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(539, 355);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 52);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(104, 355);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 52);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 419);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.returndateTextBox);
            this.Controls.Add(this.checkoutTextBox);
            this.Controls.Add(this.memberTextBox);
            this.Controls.Add(this.movieTextBox);
            this.Controls.Add(this.returndateLabel);
            this.Controls.Add(this.checkoutLabel);
            this.Controls.Add(this.memberLabel);
            this.Controls.Add(this.movieLabel);
            this.Name = "RentalForm";
            this.Text = "Rental Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.Label memberLabel;
        private System.Windows.Forms.Label checkoutLabel;
        private System.Windows.Forms.Label returndateLabel;
        private System.Windows.Forms.TextBox movieTextBox;
        private System.Windows.Forms.TextBox memberTextBox;
        private System.Windows.Forms.TextBox checkoutTextBox;
        private System.Windows.Forms.TextBox returndateTextBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addButton;
    }
}