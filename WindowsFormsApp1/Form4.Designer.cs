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
            this.titleLabel = new System.Windows.Forms.Label();
            this.addULabel = new System.Windows.Forms.Label();
            this.addPLabel = new System.Windows.Forms.Label();
            this.theUserTextBox = new System.Windows.Forms.TextBox();
            this.thePasswordTextBox = new System.Windows.Forms.TextBox();
            this.theRegisterButton = new System.Windows.Forms.Button();
            this.theCancelButton = new System.Windows.Forms.Button();
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
            this.titleLabel.Location = new System.Drawing.Point(34, 39);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(187, 18);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Put the next information";
            // 
            // addULabel
            // 
            this.addULabel.AutoSize = true;
            this.addULabel.Location = new System.Drawing.Point(57, 114);
            this.addULabel.Name = "addULabel";
            this.addULabel.Size = new System.Drawing.Size(101, 16);
            this.addULabel.TabIndex = 1;
            this.addULabel.Text = "Add Username:";
            // 
            // addPLabel
            // 
            this.addPLabel.AutoSize = true;
            this.addPLabel.Location = new System.Drawing.Point(60, 165);
            this.addPLabel.Name = "addPLabel";
            this.addPLabel.Size = new System.Drawing.Size(98, 16);
            this.addPLabel.TabIndex = 2;
            this.addPLabel.Text = "Add Password:";
            // 
            // theUserTextBox
            // 
            this.theUserTextBox.Location = new System.Drawing.Point(164, 111);
            this.theUserTextBox.Name = "theUserTextBox";
            this.theUserTextBox.Size = new System.Drawing.Size(131, 22);
            this.theUserTextBox.TabIndex = 3;
            // 
            // thePasswordTextBox
            // 
            this.thePasswordTextBox.Location = new System.Drawing.Point(164, 162);
            this.thePasswordTextBox.Name = "thePasswordTextBox";
            this.thePasswordTextBox.Size = new System.Drawing.Size(131, 22);
            this.thePasswordTextBox.TabIndex = 4;
            // 
            // theRegisterButton
            // 
            this.theRegisterButton.Location = new System.Drawing.Point(73, 235);
            this.theRegisterButton.Name = "theRegisterButton";
            this.theRegisterButton.Size = new System.Drawing.Size(91, 32);
            this.theRegisterButton.TabIndex = 5;
            this.theRegisterButton.Text = "Register";
            this.theRegisterButton.UseVisualStyleBackColor = true;
            this.theRegisterButton.Click += new System.EventHandler(this.theRegisterButton_Click);
            // 
            // theCancelButton
            // 
            this.theCancelButton.Location = new System.Drawing.Point(186, 235);
            this.theCancelButton.Name = "theCancelButton";
            this.theCancelButton.Size = new System.Drawing.Size(91, 32);
            this.theCancelButton.TabIndex = 6;
            this.theCancelButton.Text = "Cancel";
            this.theCancelButton.UseVisualStyleBackColor = true;
            this.theCancelButton.Click += new System.EventHandler(this.theCancelButton_Click);
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
            // RegisterForm
            // 
            this.ClientSize = new System.Drawing.Size(372, 340);
            this.Controls.Add(this.theCancelButton);
            this.Controls.Add(this.theRegisterButton);
            this.Controls.Add(this.thePasswordTextBox);
            this.Controls.Add(this.theUserTextBox);
            this.Controls.Add(this.addPLabel);
            this.Controls.Add(this.addULabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.mTDBTESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label addULabel;
        private System.Windows.Forms.Label addPLabel;
        private System.Windows.Forms.TextBox theUserTextBox;
        private System.Windows.Forms.TextBox thePasswordTextBox;
        private System.Windows.Forms.Button theRegisterButton;
        private System.Windows.Forms.Button theCancelButton;
        private MTDBTESTDataSet mTDBTESTDataSet;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private MTDBTESTDataSetTableAdapters.UserTableAdapter userTableAdapter1;
        private MTDBTESTDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}