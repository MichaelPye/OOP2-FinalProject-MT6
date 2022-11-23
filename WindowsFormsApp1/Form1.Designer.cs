namespace WindowsFormsApp1
{
    partial class ClientLoginForm
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
            this.NewUserButton = new System.Windows.Forms.Button();
            this.ClientLoginButton = new System.Windows.Forms.Button();
            this.ClientManagerSwitchButton = new System.Windows.Forms.Button();
            this.ClientUserNameTextBox = new System.Windows.Forms.TextBox();
            this.ClientPassWordTextBox = new System.Windows.Forms.TextBox();
            this.ClientUserNameLabel = new System.Windows.Forms.Label();
            this.ClientPassWordLabel = new System.Windows.Forms.Label();
            this.ClientLoginIntroLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewUserButton
            // 
            this.NewUserButton.Location = new System.Drawing.Point(12, 240);
            this.NewUserButton.Name = "NewUserButton";
            this.NewUserButton.Size = new System.Drawing.Size(112, 23);
            this.NewUserButton.TabIndex = 0;
            this.NewUserButton.Text = "New User?";
            this.NewUserButton.UseVisualStyleBackColor = true;
            // 
            // ClientLoginButton
            // 
            this.ClientLoginButton.Location = new System.Drawing.Point(12, 211);
            this.ClientLoginButton.Name = "ClientLoginButton";
            this.ClientLoginButton.Size = new System.Drawing.Size(112, 23);
            this.ClientLoginButton.TabIndex = 1;
            this.ClientLoginButton.Text = "Login";
            this.ClientLoginButton.UseVisualStyleBackColor = true;
            // 
            // ClientManagerSwitchButton
            // 
            this.ClientManagerSwitchButton.Location = new System.Drawing.Point(166, 264);
            this.ClientManagerSwitchButton.Name = "ClientManagerSwitchButton";
            this.ClientManagerSwitchButton.Size = new System.Drawing.Size(138, 23);
            this.ClientManagerSwitchButton.TabIndex = 2;
            this.ClientManagerSwitchButton.Text = "Switch To Manager Login";
            this.ClientManagerSwitchButton.UseVisualStyleBackColor = true;
            // 
            // ClientUserNameTextBox
            // 
            this.ClientUserNameTextBox.Location = new System.Drawing.Point(77, 112);
            this.ClientUserNameTextBox.Name = "ClientUserNameTextBox";
            this.ClientUserNameTextBox.Size = new System.Drawing.Size(203, 20);
            this.ClientUserNameTextBox.TabIndex = 3;
            // 
            // ClientPassWordTextBox
            // 
            this.ClientPassWordTextBox.Location = new System.Drawing.Point(77, 152);
            this.ClientPassWordTextBox.Name = "ClientPassWordTextBox";
            this.ClientPassWordTextBox.Size = new System.Drawing.Size(203, 20);
            this.ClientPassWordTextBox.TabIndex = 4;
            // 
            // ClientUserNameLabel
            // 
            this.ClientUserNameLabel.AutoSize = true;
            this.ClientUserNameLabel.Location = new System.Drawing.Point(13, 115);
            this.ClientUserNameLabel.Name = "ClientUserNameLabel";
            this.ClientUserNameLabel.Size = new System.Drawing.Size(58, 13);
            this.ClientUserNameLabel.TabIndex = 5;
            this.ClientUserNameLabel.Text = "Username:";
            // 
            // ClientPassWordLabel
            // 
            this.ClientPassWordLabel.AutoSize = true;
            this.ClientPassWordLabel.Location = new System.Drawing.Point(15, 155);
            this.ClientPassWordLabel.Name = "ClientPassWordLabel";
            this.ClientPassWordLabel.Size = new System.Drawing.Size(56, 13);
            this.ClientPassWordLabel.TabIndex = 6;
            this.ClientPassWordLabel.Text = "Password:";
            // 
            // ClientLoginIntroLabel
            // 
            this.ClientLoginIntroLabel.AutoSize = true;
            this.ClientLoginIntroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientLoginIntroLabel.Location = new System.Drawing.Point(9, 34);
            this.ClientLoginIntroLabel.Name = "ClientLoginIntroLabel";
            this.ClientLoginIntroLabel.Size = new System.Drawing.Size(296, 15);
            this.ClientLoginIntroLabel.TabIndex = 7;
            this.ClientLoginIntroLabel.Text = "Welcome To Mike And Gonzalo\'s Movie Stop!";
            // 
            // ClientLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 299);
            this.Controls.Add(this.ClientLoginIntroLabel);
            this.Controls.Add(this.ClientPassWordLabel);
            this.Controls.Add(this.ClientUserNameLabel);
            this.Controls.Add(this.ClientPassWordTextBox);
            this.Controls.Add(this.ClientUserNameTextBox);
            this.Controls.Add(this.ClientManagerSwitchButton);
            this.Controls.Add(this.ClientLoginButton);
            this.Controls.Add(this.NewUserButton);
            this.Name = "ClientLoginForm";
            this.Text = "Client Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewUserButton;
        private System.Windows.Forms.Button ClientLoginButton;
        private System.Windows.Forms.Button ClientManagerSwitchButton;
        private System.Windows.Forms.TextBox ClientUserNameTextBox;
        private System.Windows.Forms.TextBox ClientPassWordTextBox;
        private System.Windows.Forms.Label ClientUserNameLabel;
        private System.Windows.Forms.Label ClientPassWordLabel;
        private System.Windows.Forms.Label ClientLoginIntroLabel;
    }
}

