using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.MTDBTESTDataSetTableAdapters;

namespace WindowsFormsApp1
{
    /// <summary>
    /// This is the class definition that contains the code for the RegisterForm.
    /// </summary>
    public partial class RegisterForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterForm"/> class.
        /// </summary>
        public RegisterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the method that Initializes the ClientEticketQrCodeForm. 
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.mTDBTESTDataSet);

        }

        /// <summary>
        /// This line of code loads data into the 'mTDBTESTDataSet.User'.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void RegisterForm_Load(object sender, EventArgs e)
        {

            this.userTableAdapter1.Fill(this.mTDBTESTDataSet.User);

        }

        /// <summary>
        /// Creates user biniding source.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void userBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.mTDBTESTDataSet);

        }

        /// <summary>
        /// This line of code loads data into the 'mTDBTESTDataSet.User'.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void RegisterForm_Load_1(object sender, EventArgs e)
        {

            this.userTableAdapter1.Fill(this.mTDBTESTDataSet.User);

        }

        /// <summary>
        /// Registers new user.
        /// </summary>
        /// <param name="sender">Pressing Button</param>
        /// <param name="e">Invalid Input</param>
        public void theRegisterButton_Click(object sender, EventArgs e)
        {
            this.userTableAdapter1.AddClientQuery(this.theUserTextBox.Text, this.thePasswordTextBox.Text);
            MessageBox.Show("You had been registered!");
            this.Close();
        }

        /// <summary>
        /// Closes the RegisterForm.
        /// </summary>
        /// <param name="sender">Pressing Button</param>
        /// <param name="e">Invalid Input</param>
        public void theCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
