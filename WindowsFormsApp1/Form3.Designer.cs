namespace WindowsFormsApp1
{
    partial class ClientEticketQrCodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientEticketQrCodeForm));
            this.ClientThankYouLabel = new System.Windows.Forms.Label();
            this.ClientQrCodePictureBox = new System.Windows.Forms.PictureBox();
            this.ClientQrCodeVerifyLabel = new System.Windows.Forms.Label();
            this.ClientQrCodeCloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientQrCodePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientThankYouLabel
            // 
            this.ClientThankYouLabel.AutoSize = true;
            this.ClientThankYouLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientThankYouLabel.Location = new System.Drawing.Point(132, 25);
            this.ClientThankYouLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientThankYouLabel.Name = "ClientThankYouLabel";
            this.ClientThankYouLabel.Size = new System.Drawing.Size(213, 18);
            this.ClientThankYouLabel.TabIndex = 0;
            this.ClientThankYouLabel.Text = "Thank you for choosing us!";
            // 
            // ClientQrCodePictureBox
            // 
            this.ClientQrCodePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientQrCodePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClientQrCodePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ClientQrCodePictureBox.Image")));
            this.ClientQrCodePictureBox.Location = new System.Drawing.Point(111, 79);
            this.ClientQrCodePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientQrCodePictureBox.Name = "ClientQrCodePictureBox";
            this.ClientQrCodePictureBox.Size = new System.Drawing.Size(287, 250);
            this.ClientQrCodePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClientQrCodePictureBox.TabIndex = 1;
            this.ClientQrCodePictureBox.TabStop = false;
            // 
            // ClientQrCodeVerifyLabel
            // 
            this.ClientQrCodeVerifyLabel.AutoSize = true;
            this.ClientQrCodeVerifyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientQrCodeVerifyLabel.Location = new System.Drawing.Point(17, 354);
            this.ClientQrCodeVerifyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientQrCodeVerifyLabel.Name = "ClientQrCodeVerifyLabel";
            this.ClientQrCodeVerifyLabel.Size = new System.Drawing.Size(430, 24);
            this.ClientQrCodeVerifyLabel.TabIndex = 2;
            this.ClientQrCodeVerifyLabel.Text = "Here is your QR Code to verify your E-Ticket.";
            // 
            // ClientQrCodeCloseButton
            // 
            this.ClientQrCodeCloseButton.Location = new System.Drawing.Point(196, 393);
            this.ClientQrCodeCloseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientQrCodeCloseButton.Name = "ClientQrCodeCloseButton";
            this.ClientQrCodeCloseButton.Size = new System.Drawing.Size(100, 28);
            this.ClientQrCodeCloseButton.TabIndex = 3;
            this.ClientQrCodeCloseButton.Text = "Close";
            this.ClientQrCodeCloseButton.UseVisualStyleBackColor = true;
            this.ClientQrCodeCloseButton.Click += new System.EventHandler(this.ClientQrCodeCloseButton_Click);
            // 
            // ClientEticketQrCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 436);
            this.Controls.Add(this.ClientQrCodeCloseButton);
            this.Controls.Add(this.ClientQrCodeVerifyLabel);
            this.Controls.Add(this.ClientQrCodePictureBox);
            this.Controls.Add(this.ClientThankYouLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ClientEticketQrCodeForm";
            this.Text = "Thank You!";
            ((System.ComponentModel.ISupportInitialize)(this.ClientQrCodePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientThankYouLabel;
        private System.Windows.Forms.PictureBox ClientQrCodePictureBox;
        private System.Windows.Forms.Label ClientQrCodeVerifyLabel;
        private System.Windows.Forms.Button ClientQrCodeCloseButton;
    }
}