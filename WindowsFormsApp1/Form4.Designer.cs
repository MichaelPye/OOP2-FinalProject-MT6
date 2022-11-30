namespace WindowsFormsApp1
{
    partial class RegisterForm
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
            this.RegisterLoginIntroLabel = new System.Windows.Forms.Label();
            this.RegisterUserNameLabel = new System.Windows.Forms.Label();
            this.RegisterPassWordLabel = new System.Windows.Forms.Label();
            this.RegisterUserNameTextBox = new System.Windows.Forms.TextBox();
            this.RegisterPassWordTextBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.UserTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.DataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterLoginIntroLabel
            // 
            this.RegisterLoginIntroLabel.AutoSize = true;
            this.RegisterLoginIntroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLoginIntroLabel.Location = new System.Drawing.Point(37, 75);
            this.RegisterLoginIntroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegisterLoginIntroLabel.Name = "RegisterLoginIntroLabel";
            this.RegisterLoginIntroLabel.Size = new System.Drawing.Size(187, 18);
            this.RegisterLoginIntroLabel.TabIndex = 8;
            this.RegisterLoginIntroLabel.Text = "Put the next information";
            // 
            // RegisterUserNameLabel
            // 
            this.RegisterUserNameLabel.AutoSize = true;
            this.RegisterUserNameLabel.Location = new System.Drawing.Point(54, 142);
            this.RegisterUserNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegisterUserNameLabel.Name = "RegisterUserNameLabel";
            this.RegisterUserNameLabel.Size = new System.Drawing.Size(101, 16);
            this.RegisterUserNameLabel.TabIndex = 9;
            this.RegisterUserNameLabel.Text = "Add Username:";
            // 
            // RegisterPassWordLabel
            // 
            this.RegisterPassWordLabel.AutoSize = true;
            this.RegisterPassWordLabel.Location = new System.Drawing.Point(57, 187);
            this.RegisterPassWordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegisterPassWordLabel.Name = "RegisterPassWordLabel";
            this.RegisterPassWordLabel.Size = new System.Drawing.Size(98, 16);
            this.RegisterPassWordLabel.TabIndex = 10;
            this.RegisterPassWordLabel.Text = "Add Password:";
            // 
            // RegisterUserNameTextBox
            // 
            this.RegisterUserNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.RegisterUserNameTextBox.Location = new System.Drawing.Point(163, 139);
            this.RegisterUserNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterUserNameTextBox.Name = "RegisterUserNameTextBox";
            this.RegisterUserNameTextBox.Size = new System.Drawing.Size(269, 22);
            this.RegisterUserNameTextBox.TabIndex = 11;
            // 
            // RegisterPassWordTextBox
            // 
            this.RegisterPassWordTextBox.Location = new System.Drawing.Point(163, 184);
            this.RegisterPassWordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterPassWordTextBox.Name = "RegisterPassWordTextBox";
            this.RegisterPassWordTextBox.Size = new System.Drawing.Size(269, 22);
            this.RegisterPassWordTextBox.TabIndex = 12;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(88, 266);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(149, 28);
            this.RegisterButton.TabIndex = 13;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(255, 266);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(149, 28);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
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
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 357);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.RegisterPassWordTextBox);
            this.Controls.Add(this.RegisterUserNameTextBox);
            this.Controls.Add(this.RegisterPassWordLabel);
            this.Controls.Add(this.RegisterUserNameLabel);
            this.Controls.Add(this.RegisterLoginIntroLabel);
            this.Name = "RegisterForm";
            this.Text = "Time to Register!";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegisterLoginIntroLabel;
        private System.Windows.Forms.Label RegisterUserNameLabel;
        private System.Windows.Forms.Label RegisterPassWordLabel;
        private System.Windows.Forms.TextBox RegisterUserNameTextBox;
        private System.Windows.Forms.TextBox RegisterPassWordTextBox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button CancelButton;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DataSet1TableAdapters.UserTableAdapter userTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
    }
}