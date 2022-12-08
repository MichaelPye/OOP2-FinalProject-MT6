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
        // This makes an open connection to the SQL Server Database, use the Connection String from your database on
        // Data Connections.
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\OOP2\\Final Project - Gonzalo_Michael\\OOP2-FinalProject-MT6\\WindowsFormsApp1\\bin\\Debug\\MTDBTEST.mdf\";Integrated Security=True");

        // This will represent a store procedure to execute later.
        SqlCommand cmd;

        // This will represent the table that we want to take from the database.
        DataTable dt;

        // This represents the database connection that will be used to fill the DataSet.
        SqlDataAdapter da;

        // Will be uses at a in-memory cache of data.
        DataSet ds;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientListForm"/> class.
        /// This class will open the ClientListForm.
        /// </summary>
        public ClientListForm()
        {
            InitializeComponent();

            // Building columns for the clientView.
            clientListView.Columns.Add("UserID", 60);
            clientListView.Columns.Add("UserName", 80);
            clientListView.Columns.Add("PassWord", 80);
            clientListView.View = View.Details;

            // Opening the SQL Connection to make your query.
            con.Open();
            cmd = new SqlCommand("SELECT UserID, UserName, PassWord FROM dbo.[User] WHERE UserStatus = 'Client'", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "UserTable");
            con.Close();

            // Naming the Table and adding it's information into the clientListView.
            dt = ds.Tables["UserTable"];
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                clientListView.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                clientListView.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                clientListView.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
            }
        }

        /// <summary>
        /// Creates user bindingNavigation source.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mTDBTESTDataSet);

        }

        /// <summary>
        /// This line of code loads data into the 'mTDBTESTDataSet.User' table. You can move, or remove it, as needed.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void ClientListForm_Load(object sender, EventArgs e)
        {
            this.userTableAdapter.Fill(this.mTDBTESTDataSet.User);
        }

        /// <summary>
        /// This method will make available or visible the buttons, textBoxes, comboBoxes, etc. that are necessary
        /// to edit the clientListView. Also making unavailable the same editButton and closeButton.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void editButton_Click(object sender, EventArgs e)
        {
            this.editButton.Enabled = false;
            this.registerButton.Enabled = true;
            this.deleteButton.Enabled = true;
            this.clientNameTextBox.Enabled = true;
            this.clientPasswordTextBox.Enabled = true;
            this.finishButton.Visible = true;
            this.closeButton.Enabled = false;
        }

        /// <summary>
        /// This method will make unavailable or visible the buttons, textBoxes, comboBoxes, etc. that are necessary
        /// to edit the clientListView. Also making available the same editButton and closeButton.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void finishButton_Click(object sender, EventArgs e)
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

        /// <summary>
        /// This method will take the text from the textBoxes to add them in their respective place on the
        /// clientListView. Also it at the new information as a new row on the table from the database.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void registerButton_Click(object sender, EventArgs e)
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

                int clientID = this.clientListView.Items.Count + 2;

                // Adding new data into the clientListView.
                clientListView.Items.Add(clientID.ToString());
                clientListView.Items[clientID - 2].SubItems.Add(clientName);
                clientListView.Items[clientID - 2].SubItems.Add(clientPassword);

                // Adding the new row into the table.
                this.userTableAdapter.AddClientQuery(clientName, clientPassword);
            }
        }

        /// <summary>
        /// This method will delete the selected row from the clientListView, just if there is a selected row in the
        /// first place. Also it also delete the selected row from the table in the database.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void deleteButton_Click(object sender, EventArgs e)
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

        /// <summary>
        /// This method will close completely the ClientListForm.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
