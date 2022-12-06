namespace WindowsFormsApp1
{
    partial class ClientListForm
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
            this.clientListView = new System.Windows.Forms.ListView();
            this.mTDBTESTDataSet = new WindowsFormsApp1.MTDBTESTDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new WindowsFormsApp1.MTDBTESTDataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.MTDBTESTDataSetTableAdapters.TableAdapterManager();
            this.editButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.clientPasswordLabel = new System.Windows.Forms.Label();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.clientPasswordTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mTDBTESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clientListView
            // 
            this.clientListView.FullRowSelect = true;
            this.clientListView.HideSelection = false;
            this.clientListView.Location = new System.Drawing.Point(12, 12);
            this.clientListView.Name = "clientListView";
            this.clientListView.Size = new System.Drawing.Size(322, 303);
            this.clientListView.TabIndex = 0;
            this.clientListView.UseCompatibleStateImageBehavior = false;
            // 
            // mTDBTESTDataSet
            // 
            this.mTDBTESTDataSet.DataSetName = "MTDBTESTDataSet";
            this.mTDBTESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.mTDBTESTDataSet;
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
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.MTDBTESTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            this.tableAdapterManager.UserTicketInfoMoviesTableAdapter = null;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(24, 321);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(84, 33);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Enabled = false;
            this.registerButton.Location = new System.Drawing.Point(127, 321);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(84, 33);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(239, 384);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(84, 33);
            this.finishButton.TabIndex = 3;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Visible = false;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(239, 321);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(84, 33);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(239, 448);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(84, 33);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Location = new System.Drawing.Point(37, 392);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(80, 16);
            this.clientNameLabel.TabIndex = 6;
            this.clientNameLabel.Text = "Client name:";
            // 
            // clientPasswordLabel
            // 
            this.clientPasswordLabel.AutoSize = true;
            this.clientPasswordLabel.Location = new System.Drawing.Point(12, 434);
            this.clientPasswordLabel.Name = "clientPasswordLabel";
            this.clientPasswordLabel.Size = new System.Drawing.Size(105, 16);
            this.clientPasswordLabel.TabIndex = 7;
            this.clientPasswordLabel.Text = "Client password:";
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Enabled = false;
            this.clientNameTextBox.Location = new System.Drawing.Point(123, 389);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(96, 22);
            this.clientNameTextBox.TabIndex = 8;
            // 
            // clientPasswordTextBox
            // 
            this.clientPasswordTextBox.Enabled = false;
            this.clientPasswordTextBox.Location = new System.Drawing.Point(123, 431);
            this.clientPasswordTextBox.Name = "clientPasswordTextBox";
            this.clientPasswordTextBox.Size = new System.Drawing.Size(96, 22);
            this.clientPasswordTextBox.TabIndex = 9;
            // 
            // ClientListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 493);
            this.Controls.Add(this.clientPasswordTextBox);
            this.Controls.Add(this.clientNameTextBox);
            this.Controls.Add(this.clientPasswordLabel);
            this.Controls.Add(this.clientNameLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.clientListView);
            this.Name = "ClientListForm";
            this.Text = "Clients List";
            this.Load += new System.EventHandler(this.ClientListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mTDBTESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView clientListView;
        private MTDBTESTDataSet mTDBTESTDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private MTDBTESTDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private MTDBTESTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.Label clientPasswordLabel;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.TextBox clientPasswordTextBox;
    }
}