using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.MTDBTESTDataSetTableAdapters;


namespace WindowsFormsApp1
{
    public partial class ClientListForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\OOP2\\Final Project - Gonzalo_Michael\\OOP2-FinalProject-MT6\\WindowsFormsApp1\\bin\\Debug\\MTDBTEST.mdf\";Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;

        public ClientListForm()
        {
            InitializeComponent();

            clientListView.Columns.Add("UserID", 60);
            clientListView.Columns.Add("UserName", 80);
            clientListView.Columns.Add("PassWord", 80);
            clientListView.View = View.Details;

            con.Open();
            cmd = new SqlCommand("SELECT UserID, UserName, PassWord FROM dbo.[User] WHERE UserStatus = 'Client'", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "UserTable");
            con.Close();

            dt = ds.Tables["UserTable"];
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                clientListView.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                clientListView.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                clientListView.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
            }
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mTDBTESTDataSet);

        }

        private void ClientListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mTDBTESTDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.mTDBTESTDataSet.User);

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.editButton.Enabled = false;
            this.registerButton.Enabled = true;
            this.deleteButton.Enabled = true;
            this.clientNameTextBox.Enabled = true;
            this.clientPasswordTextBox.Enabled = true;
            this.finishButton.Visible = true;
            this.closeButton.Enabled = false;
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            this.clientNameTextBox.Text = "";
            this.clientPasswordTextBox.Text = "";

            this.editButton.Enabled = true;
            this.registerButton.Enabled = false;
            this.deleteButton.Enabled = false;
            this.clientNameTextBox.Enabled = false;
            this.clientPasswordTextBox.Enabled = false;
            this.finishButton.Visible = false;
            this.closeButton.Enabled = true;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string clientName;
            string clientPassword;
            if (this.clientNameTextBox.Text == "")
            {
                MessageBox.Show("Please, add a new client user or finish edit task");
            } else if (this.clientPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please, add a new client user or finish edit task");
            } else
            {
                clientName = this.clientNameTextBox.Text;
                clientPassword = this.clientPasswordTextBox.Text;

                int clientID = (int)this.userTableAdapter.CountClientsQuery() + 2;

                clientListView.Items.Add(clientID.ToString());
                clientListView.Items[clientID - 2].SubItems.Add(clientName);
                clientListView.Items[clientID - 2].SubItems.Add(clientPassword);

                this.userTableAdapter.AddClientQuery(clientName, clientPassword);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.clientListView.SelectedItems.Count < 1)
            {
                MessageBox.Show("Select a column or end the task");
            } else
            {
                int movieID = int.Parse(clientListView.SelectedItems[0].Text);

                this.userTableAdapter.DeleteSelectedClientQuery(movieID);

                this.clientListView.SelectedItems[0].Remove();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
