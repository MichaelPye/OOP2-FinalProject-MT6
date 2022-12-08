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
    /// This is the class definition that contains the code for the ClientLoginForm.
    /// </summary>
    public partial class ClientLoginForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientLoginForm"/> class.
        /// </summary>
        public ClientLoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validates userBindingNavigator.
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
        /// This line of code loads data into the 'mTDBTESTDataSet.User' table.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void ClientLoginForm_Load(object sender, EventArgs e)
        {

            this.userTableAdapter1.Fill(this.mTDBTESTDataSet.User);

        }

        /// <summary>
        /// Validates userBindingSource.
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
        /// This line of code loads data into the 'mTDBTESTDataSet.User' table.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void ClientLoginForm_Load_1(object sender, EventArgs e)
        {

            this.userTableAdapter1.Fill(this.mTDBTESTDataSet.User);

        }

        /// <summary>
        /// Verfies Login via Database check and refers to correct form based on status.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void loginButton_Click(object sender, EventArgs e)
        {
            ClientMovieDataDataContext db = new ClientMovieDataDataContext();

            int confirmManager = (int)this.userTableAdapter1.CheckManagerQuery(this.userTextBox.Text, this.passwordTextBox.Text);
            int userName = (int)this.userTableAdapter1.CheckNameQuery(this.userTextBox.Text, this.passwordTextBox.Text);
            int userPassword = (int)this.userTableAdapter1.CheckPasswordQuery(this.userTextBox.Text, this.passwordTextBox.Text);
            if (confirmManager == 1)
            {
                ManagerEditForm newManager = new ManagerEditForm();
                newManager.Show();
            }
            else
            {
                if (userName == 1 && userPassword == 1)
                {
                    ClientMovieSelectionForm frm = new ClientMovieSelectionForm();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("The user name or password was incorrect");
                }
            }
        }

        /// <summary>
        /// Opens RegisterForm.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerTime = new RegisterForm();
            registerTime.Show();
        }
    }
}
