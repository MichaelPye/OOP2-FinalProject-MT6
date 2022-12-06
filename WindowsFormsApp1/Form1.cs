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
    public partial class ClientLoginForm : Form
    {
        public ClientLoginForm()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.mTDBTESTDataSet);

        }

        private void ClientLoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mTDBTESTDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter1.Fill(this.mTDBTESTDataSet.User);

        }

        private void userBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.mTDBTESTDataSet);

        }

        private void ClientLoginForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mTDBTESTDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter1.Fill(this.mTDBTESTDataSet.User);

        }

        private void loginButton_Click(object sender, EventArgs e)
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

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerTime = new RegisterForm();
            registerTime.Show();
        }
    }
}
