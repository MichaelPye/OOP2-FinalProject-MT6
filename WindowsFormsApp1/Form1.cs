using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataSet1TableAdapters;

namespace WindowsFormsApp1
{
    public partial class ClientLoginForm : Form
    {
        public ClientLoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The method is call when the clientLoginButton is pressed, depending of the data in the two textboxes in the
        /// form it will open ClienForm or ManagerForm calling the methods.
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">Additional event argument</param>
        private void ClientLoginButton_Click(object sender, EventArgs e)
        {
            ClientMovieDataDataContext db = new ClientMovieDataDataContext();

            int userName = (int)this.userTableAdapter.CheckNameQuery(this.ClientUserNameTextBox.Text, this.ClientPassWordTextBox.Text);
            int userPassword = (int)this.userTableAdapter.CheckPasswordQuery(this.ClientUserNameTextBox.Text, this.ClientPassWordTextBox.Text);
            if (userName == 1 && userPassword == 1)
            {
                ClientMovieSelectionForm frm = new ClientMovieSelectionForm();
                frm.Show();
            } else
            {
                MessageBox.Show("The user name or password was incorrect");
            }
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void ClientLoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.dataSet1.User);

        }

        /// <summary>
        /// This method is call after pressing the registerButton, it opens the RegisterForm to make new users into the
        /// table 'User'.
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">Additional event argument</param>
        private void NewUserButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerTime = new RegisterForm();
            registerTime.Show();
        }
    }
}
