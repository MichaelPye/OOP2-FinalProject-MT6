﻿namespace WindowsFormsApp1
{
    partial class ManagerEditForm
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
            this.movieButton = new System.Windows.Forms.Button();
            this.ManagerSettingsIntroLabel = new System.Windows.Forms.Label();
            this.ManagerSettingsShowtimeButton = new System.Windows.Forms.Button();
            this.ManagerSettingsClientButton = new System.Windows.Forms.Button();
            this.ManagerSettingsScreeningRoomsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // movieButton
            // 
            this.movieButton.Location = new System.Drawing.Point(113, 79);
            this.movieButton.Margin = new System.Windows.Forms.Padding(2);
            this.movieButton.Name = "movieButton";
            this.movieButton.Size = new System.Drawing.Size(71, 35);
            this.movieButton.TabIndex = 0;
            this.movieButton.Text = "Movies";
            this.movieButton.UseVisualStyleBackColor = true;
            this.movieButton.Click += new System.EventHandler(this.movieButton_Click);
            // 
            // ManagerSettingsIntroLabel
            // 
            this.ManagerSettingsIntroLabel.AutoSize = true;
            this.ManagerSettingsIntroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerSettingsIntroLabel.Location = new System.Drawing.Point(-1, 34);
            this.ManagerSettingsIntroLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ManagerSettingsIntroLabel.Name = "ManagerSettingsIntroLabel";
            this.ManagerSettingsIntroLabel.Size = new System.Drawing.Size(321, 13);
            this.ManagerSettingsIntroLabel.TabIndex = 1;
            this.ManagerSettingsIntroLabel.Text = "Press On a Corresponding Button To Adjust Its Settings";
            // 
            // ManagerSettingsShowtimeButton
            // 
            this.ManagerSettingsShowtimeButton.Location = new System.Drawing.Point(113, 119);
            this.ManagerSettingsShowtimeButton.Margin = new System.Windows.Forms.Padding(2);
            this.ManagerSettingsShowtimeButton.Name = "ManagerSettingsShowtimeButton";
            this.ManagerSettingsShowtimeButton.Size = new System.Drawing.Size(71, 34);
            this.ManagerSettingsShowtimeButton.TabIndex = 2;
            this.ManagerSettingsShowtimeButton.Text = "Showtimes";
            this.ManagerSettingsShowtimeButton.UseVisualStyleBackColor = true;
            this.ManagerSettingsShowtimeButton.Click += new System.EventHandler(this.ManagerSettingsShowtimeButton_Click);
            // 
            // ManagerSettingsClientButton
            // 
            this.ManagerSettingsClientButton.Location = new System.Drawing.Point(113, 158);
            this.ManagerSettingsClientButton.Margin = new System.Windows.Forms.Padding(2);
            this.ManagerSettingsClientButton.Name = "ManagerSettingsClientButton";
            this.ManagerSettingsClientButton.Size = new System.Drawing.Size(71, 34);
            this.ManagerSettingsClientButton.TabIndex = 3;
            this.ManagerSettingsClientButton.Text = "Clients";
            this.ManagerSettingsClientButton.UseVisualStyleBackColor = true;
            this.ManagerSettingsClientButton.Click += new System.EventHandler(this.ManagerSettingsClientButton_Click);
            // 
            // ManagerSettingsScreeningRoomsButton
            // 
            this.ManagerSettingsScreeningRoomsButton.Location = new System.Drawing.Point(113, 197);
            this.ManagerSettingsScreeningRoomsButton.Margin = new System.Windows.Forms.Padding(2);
            this.ManagerSettingsScreeningRoomsButton.Name = "ManagerSettingsScreeningRoomsButton";
            this.ManagerSettingsScreeningRoomsButton.Size = new System.Drawing.Size(71, 35);
            this.ManagerSettingsScreeningRoomsButton.TabIndex = 4;
            this.ManagerSettingsScreeningRoomsButton.Text = "Screening Rooms";
            this.ManagerSettingsScreeningRoomsButton.UseVisualStyleBackColor = true;
            this.ManagerSettingsScreeningRoomsButton.Click += new System.EventHandler(this.ManagerSettingsScreeningRoomsButton_Click);
            // 
            // ManagerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 240);
            this.Controls.Add(this.ManagerSettingsScreeningRoomsButton);
            this.Controls.Add(this.ManagerSettingsClientButton);
            this.Controls.Add(this.ManagerSettingsShowtimeButton);
            this.Controls.Add(this.ManagerSettingsIntroLabel);
            this.Controls.Add(this.movieButton);
            this.Name = "ManagerEditForm";
            this.Text = "Manager Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button movieButton;
        private System.Windows.Forms.Label ManagerSettingsIntroLabel;
        private System.Windows.Forms.Button ManagerSettingsShowtimeButton;
        private System.Windows.Forms.Button ManagerSettingsClientButton;
        private System.Windows.Forms.Button ManagerSettingsScreeningRoomsButton;
    }
}