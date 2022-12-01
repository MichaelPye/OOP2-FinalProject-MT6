namespace WindowsFormsApp1
{
    partial class ClientMovieSelectionForm
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
            this.ClientMovieSelectionButton = new System.Windows.Forms.Button();
            this.ClientMovieSelectionLabel = new System.Windows.Forms.Label();
            this.ClientMovieListBox = new System.Windows.Forms.ListBox();
            this.ClientShowTimeListBox = new System.Windows.Forms.ListBox();
            this.ClientIdListBox = new System.Windows.Forms.ListBox();
            this.ClientGenreListBox = new System.Windows.Forms.ListBox();
            this.ClientMovieLabel = new System.Windows.Forms.Label();
            this.ClientGenreLabel = new System.Windows.Forms.Label();
            this.ClientShowTimeLabel = new System.Windows.Forms.Label();
            this.ClientIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClientMovieSelectionButton
            // 
            this.ClientMovieSelectionButton.Location = new System.Drawing.Point(162, 175);
            this.ClientMovieSelectionButton.Name = "ClientMovieSelectionButton";
            this.ClientMovieSelectionButton.Size = new System.Drawing.Size(101, 23);
            this.ClientMovieSelectionButton.TabIndex = 2;
            this.ClientMovieSelectionButton.Text = "Get Your E-Ticket";
            this.ClientMovieSelectionButton.UseVisualStyleBackColor = true;
            this.ClientMovieSelectionButton.Click += new System.EventHandler(this.ClientMovieSelectionButton_Click);
            // 
            // ClientMovieSelectionLabel
            // 
            this.ClientMovieSelectionLabel.AutoSize = true;
            this.ClientMovieSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientMovieSelectionLabel.Location = new System.Drawing.Point(89, 9);
            this.ClientMovieSelectionLabel.Name = "ClientMovieSelectionLabel";
            this.ClientMovieSelectionLabel.Size = new System.Drawing.Size(234, 16);
            this.ClientMovieSelectionLabel.TabIndex = 3;
            this.ClientMovieSelectionLabel.Text = "Here\'s What\'s Playing Right Now";
            // 
            // ClientMovieListBox
            // 
            this.ClientMovieListBox.FormattingEnabled = true;
            this.ClientMovieListBox.Location = new System.Drawing.Point(12, 61);
            this.ClientMovieListBox.Name = "ClientMovieListBox";
            this.ClientMovieListBox.Size = new System.Drawing.Size(120, 108);
            this.ClientMovieListBox.TabIndex = 4;
            // 
            // ClientShowTimeListBox
            // 
            this.ClientShowTimeListBox.FormattingEnabled = true;
            this.ClientShowTimeListBox.Location = new System.Drawing.Point(248, 61);
            this.ClientShowTimeListBox.Name = "ClientShowTimeListBox";
            this.ClientShowTimeListBox.Size = new System.Drawing.Size(120, 108);
            this.ClientShowTimeListBox.TabIndex = 5;
            // 
            // ClientIdListBox
            // 
            this.ClientIdListBox.FormattingEnabled = true;
            this.ClientIdListBox.Location = new System.Drawing.Point(374, 61);
            this.ClientIdListBox.Name = "ClientIdListBox";
            this.ClientIdListBox.Size = new System.Drawing.Size(28, 108);
            this.ClientIdListBox.TabIndex = 6;
            // 
            // ClientGenreListBox
            // 
            this.ClientGenreListBox.FormattingEnabled = true;
            this.ClientGenreListBox.Location = new System.Drawing.Point(138, 61);
            this.ClientGenreListBox.Name = "ClientGenreListBox";
            this.ClientGenreListBox.Size = new System.Drawing.Size(104, 108);
            this.ClientGenreListBox.TabIndex = 7;
            // 
            // ClientMovieLabel
            // 
            this.ClientMovieLabel.AutoSize = true;
            this.ClientMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientMovieLabel.Location = new System.Drawing.Point(25, 45);
            this.ClientMovieLabel.Name = "ClientMovieLabel";
            this.ClientMovieLabel.Size = new System.Drawing.Size(92, 13);
            this.ClientMovieLabel.TabIndex = 8;
            this.ClientMovieLabel.Text = "Current Movies";
            // 
            // ClientGenreLabel
            // 
            this.ClientGenreLabel.AutoSize = true;
            this.ClientGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientGenreLabel.Location = new System.Drawing.Point(171, 45);
            this.ClientGenreLabel.Name = "ClientGenreLabel";
            this.ClientGenreLabel.Size = new System.Drawing.Size(41, 13);
            this.ClientGenreLabel.TabIndex = 9;
            this.ClientGenreLabel.Text = "Genre";
            // 
            // ClientShowTimeLabel
            // 
            this.ClientShowTimeLabel.AutoSize = true;
            this.ClientShowTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientShowTimeLabel.Location = new System.Drawing.Point(278, 45);
            this.ClientShowTimeLabel.Name = "ClientShowTimeLabel";
            this.ClientShowTimeLabel.Size = new System.Drawing.Size(61, 13);
            this.ClientShowTimeLabel.TabIndex = 10;
            this.ClientShowTimeLabel.Text = "Showtime";
            // 
            // ClientIdLabel
            // 
            this.ClientIdLabel.AutoSize = true;
            this.ClientIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientIdLabel.Location = new System.Drawing.Point(371, 45);
            this.ClientIdLabel.Name = "ClientIdLabel";
            this.ClientIdLabel.Size = new System.Drawing.Size(20, 13);
            this.ClientIdLabel.TabIndex = 11;
            this.ClientIdLabel.Text = "ID";
            // 
            // ClientMovieSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 210);
            this.Controls.Add(this.ClientIdLabel);
            this.Controls.Add(this.ClientShowTimeLabel);
            this.Controls.Add(this.ClientGenreLabel);
            this.Controls.Add(this.ClientMovieLabel);
            this.Controls.Add(this.ClientGenreListBox);
            this.Controls.Add(this.ClientIdListBox);
            this.Controls.Add(this.ClientShowTimeListBox);
            this.Controls.Add(this.ClientMovieListBox);
            this.Controls.Add(this.ClientMovieSelectionLabel);
            this.Controls.Add(this.ClientMovieSelectionButton);
            this.Name = "ClientMovieSelectionForm";
            this.Text = "Select Your Movie";
            this.Load += new System.EventHandler(this.ClientMovieSelectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ClientMovieSelectionButton;
        private System.Windows.Forms.Label ClientMovieSelectionLabel;
        private System.Windows.Forms.ListBox ClientMovieListBox;
        private System.Windows.Forms.ListBox ClientShowTimeListBox;
        private System.Windows.Forms.ListBox ClientIdListBox;
        private System.Windows.Forms.ListBox ClientGenreListBox;
        private System.Windows.Forms.Label ClientMovieLabel;
        private System.Windows.Forms.Label ClientGenreLabel;
        private System.Windows.Forms.Label ClientShowTimeLabel;
        private System.Windows.Forms.Label ClientIdLabel;
    }
}