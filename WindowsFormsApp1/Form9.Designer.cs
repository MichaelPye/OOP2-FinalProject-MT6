namespace WindowsFormsApp1
{
    partial class ScreeningRoomListForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.editButton = new System.Windows.Forms.Button();
            this.room1Button = new System.Windows.Forms.Button();
            this.room2Button = new System.Windows.Forms.Button();
            this.room3Button = new System.Windows.Forms.Button();
            this.room4Button = new System.Windows.Forms.Button();
            this.room5Button = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.screeningRoomInfoTableAdapter1 = new WindowsFormsApp1.MTDBTESTDataSetTableAdapters.ScreeningRoomInfoTableAdapter();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Enabled = false;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(125, 228);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(143, 12);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(255, 228);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(36, 257);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(83, 33);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // room1Button
            // 
            this.room1Button.Enabled = false;
            this.room1Button.Location = new System.Drawing.Point(79, 305);
            this.room1Button.Name = "room1Button";
            this.room1Button.Size = new System.Drawing.Size(75, 23);
            this.room1Button.TabIndex = 3;
            this.room1Button.Text = "ROOM1";
            this.room1Button.UseVisualStyleBackColor = true;
            this.room1Button.Click += new System.EventHandler(this.room1Button_Click);
            // 
            // room2Button
            // 
            this.room2Button.Enabled = false;
            this.room2Button.Location = new System.Drawing.Point(160, 305);
            this.room2Button.Name = "room2Button";
            this.room2Button.Size = new System.Drawing.Size(75, 23);
            this.room2Button.TabIndex = 4;
            this.room2Button.Text = "ROOM2";
            this.room2Button.UseVisualStyleBackColor = true;
            this.room2Button.Click += new System.EventHandler(this.room2Button_Click);
            // 
            // room3Button
            // 
            this.room3Button.Enabled = false;
            this.room3Button.Location = new System.Drawing.Point(241, 305);
            this.room3Button.Name = "room3Button";
            this.room3Button.Size = new System.Drawing.Size(75, 23);
            this.room3Button.TabIndex = 5;
            this.room3Button.Text = "ROOM3";
            this.room3Button.UseVisualStyleBackColor = true;
            this.room3Button.Click += new System.EventHandler(this.room3Button_Click);
            // 
            // room4Button
            // 
            this.room4Button.Enabled = false;
            this.room4Button.Location = new System.Drawing.Point(119, 334);
            this.room4Button.Name = "room4Button";
            this.room4Button.Size = new System.Drawing.Size(75, 23);
            this.room4Button.TabIndex = 6;
            this.room4Button.Text = "ROOM4";
            this.room4Button.UseVisualStyleBackColor = true;
            this.room4Button.Click += new System.EventHandler(this.room4Button_Click);
            // 
            // room5Button
            // 
            this.room5Button.Enabled = false;
            this.room5Button.Location = new System.Drawing.Point(200, 334);
            this.room5Button.Name = "room5Button";
            this.room5Button.Size = new System.Drawing.Size(75, 23);
            this.room5Button.TabIndex = 7;
            this.room5Button.Text = "ROOM5";
            this.room5Button.UseVisualStyleBackColor = true;
            this.room5Button.Click += new System.EventHandler(this.room5Button_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(269, 257);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(83, 33);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(157, 366);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(83, 33);
            this.finishButton.TabIndex = 9;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Visible = false;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(294, 366);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(83, 33);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // screeningRoomInfoTableAdapter1
            // 
            this.screeningRoomInfoTableAdapter1.ClearBeforeFill = true;
            // 
            // ScreeningRoomListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 411);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.room5Button);
            this.Controls.Add(this.room4Button);
            this.Controls.Add(this.room3Button);
            this.Controls.Add(this.room2Button);
            this.Controls.Add(this.room1Button);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "ScreeningRoomListForm";
            this.Text = "Screening Room List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button room1Button;
        private System.Windows.Forms.Button room2Button;
        private System.Windows.Forms.Button room3Button;
        private System.Windows.Forms.Button room4Button;
        private System.Windows.Forms.Button room5Button;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button closeButton;
        private MTDBTESTDataSetTableAdapters.ScreeningRoomInfoTableAdapter screeningRoomInfoTableAdapter1;
    }
}