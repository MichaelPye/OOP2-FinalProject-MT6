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
            this.NewUserButton = new System.Windows.Forms.Button();
            this.ClientLoginButton = new System.Windows.Forms.Button();
            this.ClientManagerSwitchButton = new System.Windows.Forms.Button();
            this.ClientUserNameTextBox = new System.Windows.Forms.TextBox();
            this.ClientPassWordTextBox = new System.Windows.Forms.TextBox();
            this.ClientUserNameLabel = new System.Windows.Forms.Label();
            this.ClientPassWordLabel = new System.Windows.Forms.Label();
            this.ClientLoginIntroLabel = new System.Windows.Forms.Label();
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.UserTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.DataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NewUserButton
            // 
            this.NewUserButton.Location = new System.Drawing.Point(16, 295);
            this.NewUserButton.Margin = new System.Windows.Forms.Padding(4);
            this.NewUserButton.Name = "NewUserButton";
            this.NewUserButton.Size = new System.Drawing.Size(149, 28);
            this.NewUserButton.TabIndex = 0;
            this.NewUserButton.Text = "New User?";
            this.NewUserButton.UseVisualStyleBackColor = true;
            this.NewUserButton.Click += new System.EventHandler(this.NewUserButton_Click);
            // 
            // ClientLoginButton
            // 
            this.ClientLoginButton.Location = new System.Drawing.Point(16, 260);
            this.ClientLoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClientLoginButton.Name = "ClientLoginButton";
            this.ClientLoginButton.Size = new System.Drawing.Size(149, 28);
            this.ClientLoginButton.TabIndex = 1;
            this.ClientLoginButton.Text = "Login";
            this.ClientLoginButton.UseVisualStyleBackColor = true;
            this.ClientLoginButton.Click += new System.EventHandler(this.ClientLoginButton_Click);
            // 
            // ClientManagerSwitchButton
            // 
            this.ClientManagerSwitchButton.Location = new System.Drawing.Point(221, 325);
            this.ClientManagerSwitchButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClientManagerSwitchButton.Name = "ClientManagerSwitchButton";
            this.ClientManagerSwitchButton.Size = new System.Drawing.Size(184, 28);
            this.ClientManagerSwitchButton.TabIndex = 2;
            this.ClientManagerSwitchButton.Text = "Switch To Manager Login";
            this.ClientManagerSwitchButton.UseVisualStyleBackColor = true;
            // 
            // ClientUserNameTextBox
            // 
            this.ClientUserNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ClientUserNameTextBox.Location = new System.Drawing.Point(103, 138);
            this.ClientUserNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClientUserNameTextBox.Name = "ClientUserNameTextBox";
            this.ClientUserNameTextBox.Size = new System.Drawing.Size(269, 22);
            this.ClientUserNameTextBox.TabIndex = 3;
            // 
            // ClientPassWordTextBox
            // 
            this.ClientPassWordTextBox.Location = new System.Drawing.Point(103, 187);
            this.ClientPassWordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClientPassWordTextBox.Name = "ClientPassWordTextBox";
            this.ClientPassWordTextBox.Size = new System.Drawing.Size(269, 22);
            this.ClientPassWordTextBox.TabIndex = 4;
            // 
            // ClientUserNameLabel
            // 
            this.ClientUserNameLabel.AutoSize = true;
            this.ClientUserNameLabel.Location = new System.Drawing.Point(17, 142);
            this.ClientUserNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientUserNameLabel.Name = "ClientUserNameLabel";
            this.ClientUserNameLabel.Size = new System.Drawing.Size(73, 16);
            this.ClientUserNameLabel.TabIndex = 5;
            this.ClientUserNameLabel.Text = "Username:";
            // 
            // ClientPassWordLabel
            // 
            this.ClientPassWordLabel.AutoSize = true;
            this.ClientPassWordLabel.Location = new System.Drawing.Point(20, 191);
            this.ClientPassWordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientPassWordLabel.Name = "ClientPassWordLabel";
            this.ClientPassWordLabel.Size = new System.Drawing.Size(70, 16);
            this.ClientPassWordLabel.TabIndex = 6;
            this.ClientPassWordLabel.Text = "Password:";
            // 
            // ClientLoginIntroLabel
            // 
            this.ClientLoginIntroLabel.AutoSize = true;
            this.ClientLoginIntroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientLoginIntroLabel.Location = new System.Drawing.Point(12, 42);
            this.ClientLoginIntroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientLoginIntroLabel.Name = "ClientLoginIntroLabel";
            this.ClientLoginIntroLabel.Size = new System.Drawing.Size(354, 18);
            this.ClientLoginIntroLabel.TabIndex = 7;
            this.ClientLoginIntroLabel.Text = "Welcome To Mike And Gonzalo\'s Movie Stop!";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.dataSet1;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MoviesTableAdapter = null;
            this.tableAdapterManager.ScreeningRoomInfoTableAdapter = null;
            this.tableAdapterManager.ShowTimeInfoTableAdapter = null;
            this.tableAdapterManager.TicketInfoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            this.tableAdapterManager.UserTicketInfoMoviesTableAdapter = null;
            // 
            // ClientLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 373);
            this.Controls.Add(this.ClientLoginIntroLabel);
            this.Controls.Add(this.ClientPassWordLabel);
            this.Controls.Add(this.ClientUserNameLabel);
            this.Controls.Add(this.ClientPassWordTextBox);
            this.Controls.Add(this.ClientUserNameTextBox);
            this.Controls.Add(this.ClientManagerSwitchButton);
            this.Controls.Add(this.ClientLoginButton);
            this.Controls.Add(this.NewUserButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientLoginForm";
            this.Text = "Client Login";
            this.Load += new System.EventHandler(this.ClientLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
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
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DataSet1TableAdapters.UserTableAdapter userTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
    }
}

