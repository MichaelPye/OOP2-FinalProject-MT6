using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// This is the class definition that contains the code for the ClientEticketQrCodeForm.
    /// </summary>
    public partial class ClientEticketQrCodeForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientEticketQrCodeForm"/> class.
        /// </summary>
        public ClientEticketQrCodeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This click event closes the ClientEticketQrCodeForm.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void ClientQrCodeCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
