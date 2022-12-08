namespace WindowsFormsApp1
{
    partial class MovieListForm
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
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.movieLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.releaseDateLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.finishButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.moviesTableAdapter1 = new WindowsFormsApp1.MTDBTESTDataSetTableAdapters.MoviesTableAdapter();
            this.showTimeInfoTableAdapter1 = new WindowsFormsApp1.MTDBTESTDataSetTableAdapters.ShowTimeInfoTableAdapter();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 10);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(355, 201);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(38, 215);
            this.editButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(74, 32);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(146, 215);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(74, 32);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(259, 215);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(74, 32);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Location = new System.Drawing.Point(20, 266);
            this.movieLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(68, 13);
            this.movieLabel.TabIndex = 5;
            this.movieLabel.Text = "Movie name:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(48, 297);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(39, 13);
            this.genreLabel.TabIndex = 6;
            this.genreLabel.Text = "Genre:";
            // 
            // releaseDateLabel
            // 
            this.releaseDateLabel.AutoSize = true;
            this.releaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseDateLabel.Location = new System.Drawing.Point(14, 327);
            this.releaseDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.releaseDateLabel.Name = "releaseDateLabel";
            this.releaseDateLabel.Size = new System.Drawing.Size(73, 13);
            this.releaseDateLabel.TabIndex = 7;
            this.releaseDateLabel.Text = "Release date:";
            // 
            // genreComboBox
            // 
            this.genreComboBox.Enabled = false;
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "Action",
            "Crime",
            "Comedy",
            "Horror",
            "Fantasy",
            "Drama"});
            this.genreComboBox.Location = new System.Drawing.Point(88, 294);
            this.genreComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(106, 21);
            this.genreComboBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(88, 263);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(106, 20);
            this.nameTextBox.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 323);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(259, 266);
            this.finishButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(74, 32);
            this.finishButton.TabIndex = 17;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Visible = false;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(259, 327);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(74, 32);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // moviesTableAdapter1
            // 
            this.moviesTableAdapter1.ClearBeforeFill = true;
            // 
            // showTimeInfoTableAdapter1
            // 
            this.showTimeInfoTableAdapter1.ClearBeforeFill = true;
            // 
            // MovieListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 382);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.releaseDateLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.movieLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MovieListForm";
            this.Text = "Movie List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label releaseDateLabel;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private MTDBTESTDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button closeButton;
        private MTDBTESTDataSetTableAdapters.ShowTimeInfoTableAdapter showTimeInfoTableAdapter1;
    }
}