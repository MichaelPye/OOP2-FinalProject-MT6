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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.dataSet1.User);

        }

        /// <summary>
        /// This method is call when the registerButton is clicked, it open a method(SQL) from the DataSet1 to insert the
        /// data in the text boxes as new users in the UserTable.
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">Additional event argument</param>
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.userTableAdapter.AddClientQuery(this.RegisterUserNameTextBox.Text,this.RegisterPassWordTextBox.Text);
            MessageBox.Show("You had been registered!");
            this.Close();
        }
    }
}
