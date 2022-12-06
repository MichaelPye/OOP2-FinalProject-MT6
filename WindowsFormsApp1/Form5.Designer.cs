namespace WindowsFormsApp1
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
            this.SuspendLayout();
            // 
            // movieButton
            // 
            this.movieButton.Location = new System.Drawing.Point(62, 98);
            this.movieButton.Name = "movieButton";
            this.movieButton.Size = new System.Drawing.Size(95, 43);
            this.movieButton.TabIndex = 0;
            this.movieButton.Text = "Movies";
            this.movieButton.UseVisualStyleBackColor = true;
            this.movieButton.Click += new System.EventHandler(this.movieButton_Click);
            // 
            // ManagerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 463);
            this.Controls.Add(this.movieButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManagerEditForm";
            this.Text = "Manager Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button movieButton;
    }
}