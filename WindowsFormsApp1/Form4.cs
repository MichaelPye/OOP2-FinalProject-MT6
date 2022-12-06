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
            this.tableAdapterManager1.UpdateAll(this.mTDBTESTDataSet);

        }

        private void RegisterForm_Load(object sender, EventArgs e)
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

        private void RegisterForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mTDBTESTDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter1.Fill(this.mTDBTESTDataSet.User);

        }

        private void theRegisterButton_Click(object sender, EventArgs e)
        {
            this.userTableAdapter1.AddClientQuery(this.theUserTextBox.Text, this.thePasswordTextBox.Text);
            MessageBox.Show("You had been registered!");
            this.Close();
        }

        private void theCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
