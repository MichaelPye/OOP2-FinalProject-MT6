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
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.mTDBTESTDataSet = new WindowsFormsApp1.MTDBTESTDataSet();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter1 = new WindowsFormsApp1.MTDBTESTDataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp1.MTDBTESTDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.mTDBTESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 63);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(361, 18);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Welcome to Mike\'s and Gonzalo\'s Movie Stop!";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(39, 136);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(73, 16);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(39, 179);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(70, 16);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(118, 130);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(166, 22);
            this.userTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(115, 173);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(169, 22);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(71, 243);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(85, 33);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(199, 243);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(85, 33);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // mTDBTESTDataSet
            // 
            this.mTDBTESTDataSet.DataSetName = "MTDBTESTDataSet";
            this.mTDBTESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataMember = "User";
            this.userBindingSource1.DataSource = this.mTDBTESTDataSet;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.MoviesTableAdapter = null;
            this.tableAdapterManager1.ScreeningRoomInfoTableAdapter = null;
            this.tableAdapterManager1.ShowTimeInfoTableAdapter = null;
            this.tableAdapterManager1.TicketInfoTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1.MTDBTESTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UserTableAdapter = this.userTableAdapter1;
            this.tableAdapterManager1.UserTicketInfoMoviesTableAdapter = null;
            // 
            // ClientLoginForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 295);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "ClientLoginForm";
            this.Load += new System.EventHandler(this.ClientLoginForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.mTDBTESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
        private MTDBTESTDataSet mTDBTESTDataSet;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private MTDBTESTDataSetTableAdapters.UserTableAdapter userTableAdapter1;
        private MTDBTESTDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}

