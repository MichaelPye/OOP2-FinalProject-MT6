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
            this.ClientMovieDataGridView = new System.Windows.Forms.DataGridView();
            this.ClientMovieShowTimeDataGridView = new System.Windows.Forms.DataGridView();
            this.ClientMovieSelectionButton = new System.Windows.Forms.Button();
            this.ClientMovieSelectionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientMovieDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientMovieShowTimeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientMovieDataGridView
            // 
            this.ClientMovieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientMovieDataGridView.Location = new System.Drawing.Point(12, 54);
            this.ClientMovieDataGridView.Name = "ClientMovieDataGridView";
            this.ClientMovieDataGridView.Size = new System.Drawing.Size(232, 213);
            this.ClientMovieDataGridView.TabIndex = 0;
            // 
            // ClientMovieShowTimeDataGridView
            // 
            this.ClientMovieShowTimeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientMovieShowTimeDataGridView.Location = new System.Drawing.Point(284, 54);
            this.ClientMovieShowTimeDataGridView.Name = "ClientMovieShowTimeDataGridView";
            this.ClientMovieShowTimeDataGridView.Size = new System.Drawing.Size(240, 213);
            this.ClientMovieShowTimeDataGridView.TabIndex = 1;
            // 
            // ClientMovieSelectionButton
            // 
            this.ClientMovieSelectionButton.Location = new System.Drawing.Point(215, 292);
            this.ClientMovieSelectionButton.Name = "ClientMovieSelectionButton";
            this.ClientMovieSelectionButton.Size = new System.Drawing.Size(101, 23);
            this.ClientMovieSelectionButton.TabIndex = 2;
            this.ClientMovieSelectionButton.Text = "Get Your E-Ticket";
            this.ClientMovieSelectionButton.UseVisualStyleBackColor = true;
            // 
            // ClientMovieSelectionLabel
            // 
            this.ClientMovieSelectionLabel.AutoSize = true;
            this.ClientMovieSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientMovieSelectionLabel.Location = new System.Drawing.Point(148, 9);
            this.ClientMovieSelectionLabel.Name = "ClientMovieSelectionLabel";
            this.ClientMovieSelectionLabel.Size = new System.Drawing.Size(234, 16);
            this.ClientMovieSelectionLabel.TabIndex = 3;
            this.ClientMovieSelectionLabel.Text = "Here\'s What\'s Playing Right Now";
            // 
            // ClientMovieSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 327);
            this.Controls.Add(this.ClientMovieSelectionLabel);
            this.Controls.Add(this.ClientMovieSelectionButton);
            this.Controls.Add(this.ClientMovieShowTimeDataGridView);
            this.Controls.Add(this.ClientMovieDataGridView);
            this.Name = "ClientMovieSelectionForm";
            this.Text = "Select Your Movie";
            ((System.ComponentModel.ISupportInitialize)(this.ClientMovieDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientMovieShowTimeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientMovieDataGridView;
        private System.Windows.Forms.DataGridView ClientMovieShowTimeDataGridView;
        private System.Windows.Forms.Button ClientMovieSelectionButton;
        private System.Windows.Forms.Label ClientMovieSelectionLabel;
    }
}