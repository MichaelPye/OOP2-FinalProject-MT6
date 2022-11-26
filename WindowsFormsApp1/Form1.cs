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

        private void ClientLoginButton_Click(object sender, EventArgs e)
        {
            ClientMovieDataDataContext db = new ClientMovieDataDataContext();

            string userName = (string)this.userTableAdapter.CheckNameQuery(this.ClientUserNameTextBox.Text, this.ClientPassWordTextBox.Text);
            string userPassword = (string)this.userTableAdapter.CheckPasswordQuery(this.ClientUserNameTextBox.Text, this.ClientPassWordTextBox.Text);
            if (userName == this.ClientUserNameTextBox.Text && userPassword == this.ClientPassWordTextBox.Text)
            {
                ClientMovieSelectionForm frm = new ClientMovieSelectionForm();
                frm.Show();
            } else
            {
                MessageBox.Show("The user name or password was incorrect");
            }

            /*Use the userTableAdapter*/
            /*if((bool)this.userTableAdapter.CheckQuery(this.ClientUserNameTextBox.Text,this.ClientPassWordTextBox.Text))
            {
                ClientMovieSelectionForm frm = new ClientMovieSelectionForm();
                frm.Show();
            } else
            {
                MessageBox.Show("The user name or password was incorrect");
            }*/

            /*foreach (User item in db.Users)
            {
                if(item.UserName == this.ClientUserNameTextBox.Text && item.PassWord == this.ClientPassWordTextBox.Text)
                {
                    ClientMovieSelectionForm frm = new ClientMovieSelectionForm();
                    frm.Show();
                }
                else 
                {
                    MessageBox.Show("The user name or password was incorrect");
                }
            }*/
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
    }
}
