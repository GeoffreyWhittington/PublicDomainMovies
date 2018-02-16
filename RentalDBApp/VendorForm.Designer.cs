namespace RentalDBApp
{
    partial class VendorForm
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
            this.vendornameLabel = new System.Windows.Forms.Label();
            this.vendorrepLabel = new System.Windows.Forms.Label();
            this.vendorrepemailLabel = new System.Windows.Forms.Label();
            this.vendorrepphoneLabel = new System.Windows.Forms.Label();
            this.vendornameTextBox = new System.Windows.Forms.TextBox();
            this.vendorrepTextBox = new System.Windows.Forms.TextBox();
            this.vendorrepemailTextBox = new System.Windows.Forms.TextBox();
            this.vendorrepphoneTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vendornameLabel
            // 
            this.vendornameLabel.AutoSize = true;
            this.vendornameLabel.Location = new System.Drawing.Point(23, 35);
            this.vendornameLabel.Name = "vendornameLabel";
            this.vendornameLabel.Size = new System.Drawing.Size(72, 13);
            this.vendornameLabel.TabIndex = 0;
            this.vendornameLabel.Text = "Vendor Name";
            // 
            // vendorrepLabel
            // 
            this.vendorrepLabel.AutoSize = true;
            this.vendorrepLabel.Location = new System.Drawing.Point(23, 87);
            this.vendorrepLabel.Name = "vendorrepLabel";
            this.vendorrepLabel.Size = new System.Drawing.Size(64, 13);
            this.vendorrepLabel.TabIndex = 1;
            this.vendorrepLabel.Text = "Vendor Rep";
            // 
            // vendorrepemailLabel
            // 
            this.vendorrepemailLabel.AutoSize = true;
            this.vendorrepemailLabel.Location = new System.Drawing.Point(23, 140);
            this.vendorrepemailLabel.Name = "vendorrepemailLabel";
            this.vendorrepemailLabel.Size = new System.Drawing.Size(92, 13);
            this.vendorrepemailLabel.TabIndex = 2;
            this.vendorrepemailLabel.Text = "Vendor Rep Email";
            // 
            // vendorrepphoneLabel
            // 
            this.vendorrepphoneLabel.AutoSize = true;
            this.vendorrepphoneLabel.Location = new System.Drawing.Point(23, 199);
            this.vendorrepphoneLabel.Name = "vendorrepphoneLabel";
            this.vendorrepphoneLabel.Size = new System.Drawing.Size(98, 13);
            this.vendorrepphoneLabel.TabIndex = 3;
            this.vendorrepphoneLabel.Text = "Vendor Rep Phone";
            // 
            // vendornameTextBox
            // 
            this.vendornameTextBox.Location = new System.Drawing.Point(101, 32);
            this.vendornameTextBox.Name = "vendornameTextBox";
            this.vendornameTextBox.Size = new System.Drawing.Size(100, 20);
            this.vendornameTextBox.TabIndex = 4;
            // 
            // vendorrepTextBox
            // 
            this.vendorrepTextBox.Location = new System.Drawing.Point(101, 84);
            this.vendorrepTextBox.Name = "vendorrepTextBox";
            this.vendorrepTextBox.Size = new System.Drawing.Size(100, 20);
            this.vendorrepTextBox.TabIndex = 5;
            // 
            // vendorrepemailTextBox
            // 
            this.vendorrepemailTextBox.Location = new System.Drawing.Point(121, 137);
            this.vendorrepemailTextBox.Name = "vendorrepemailTextBox";
            this.vendorrepemailTextBox.Size = new System.Drawing.Size(100, 20);
            this.vendorrepemailTextBox.TabIndex = 6;
            // 
            // vendorrepphoneTextBox
            // 
            this.vendorrepphoneTextBox.Location = new System.Drawing.Point(131, 196);
            this.vendorrepphoneTextBox.Name = "vendorrepphoneTextBox";
            this.vendorrepphoneTextBox.Size = new System.Drawing.Size(90, 20);
            this.vendorrepphoneTextBox.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(26, 239);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 49);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
          //  this.addButton.Click += new System.EventHandler(this.addButton.Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(131, 239);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 49);
            this.findButton.TabIndex = 9;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(236, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 49);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(341, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 49);
            this.button4.TabIndex = 11;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // VendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 310);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.vendorrepphoneTextBox);
            this.Controls.Add(this.vendorrepemailTextBox);
            this.Controls.Add(this.vendorrepTextBox);
            this.Controls.Add(this.vendornameTextBox);
            this.Controls.Add(this.vendorrepphoneLabel);
            this.Controls.Add(this.vendorrepemailLabel);
            this.Controls.Add(this.vendorrepLabel);
            this.Controls.Add(this.vendornameLabel);
            this.Name = "VendorForm";
            this.Text = "Vendor Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vendornameLabel;
        private System.Windows.Forms.Label vendorrepLabel;
        private System.Windows.Forms.Label vendorrepemailLabel;
        private System.Windows.Forms.Label vendorrepphoneLabel;
        private System.Windows.Forms.TextBox vendornameTextBox;
        private System.Windows.Forms.TextBox vendorrepTextBox;
        private System.Windows.Forms.TextBox vendorrepemailTextBox;
        private System.Windows.Forms.TextBox vendorrepphoneTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}