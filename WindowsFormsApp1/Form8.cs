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
    public partial class ShowTimeListForm : Form
    {
        // This makes an open connection to the SQL Server Database, use the Connection String from your database on
        // Data Connections.
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\le1770426\\Desktop\\Fall 2022\\OOP 2\\GIT\\CRCMDB 3.0\\OOP2Final\\OOP2-FinalProject-MT6\\WindowsFormsApp1\\bin\\Debug\\MTDBTEST.mdf\";Integrated Security=True");

        // This will represent a store procedure to execute later.
        SqlCommand cmd;

        // This will represent the table that we want to take from the database.
        DataTable dt;

        // This represents the database connection that will be used to fill the DataSet.
        SqlDataAdapter da;

        // Will be uses at a in-memory cache of data.
        DataSet ds;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShowTimeListForm"/> class.
        /// This class will open the ShowTimeListForm.
        /// </summary>
        public ShowTimeListForm()
        {
            InitializeComponent();

            // First listView
            // Building columns for the listView1.
            listView1.Columns.Add("CurrentMovies", 90);
            listView1.Columns.Add("ID", 30);
            listView1.View = View.Details;

            // Opening the SQL Connection to make your query.
            con.Open();
            cmd = new SqlCommand("SELECT MovieName, MovieID FROM Movies", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "NameTable");
            con.Close();

            // Naming the Table and adding it's information into the listView1.
            dt = ds.Tables["NameTable"];
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listView1.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
            }

            // Second listView
            // Building columns for the listView2.
            listView2.Columns.Add("MovieID", 80);
            listView2.Columns.Add("ActualShowTimeDateTime", 150);
            listView2.View = View.Details;

            // Opening the SQL Connection to make your query.
            con.Open();
            cmd = new SqlCommand("SELECT MovieID, ActualShowTimeDateTime FROM ShowTimeInfo", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "ShowTimeTable");
            con.Close();

            // Naming the Table and adding it's information into the listView2.
            dt = ds.Tables["ShowTimeTable"];
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listView2.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listView2.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
            }
        }

        /// <summary>
        /// This method will make available or visible the buttons, textBoxes, comboBoxes, etc. that are necessary
        /// to edit the listView2. Also making unavailable the same editButton and closeButton.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void editButton_Click(object sender, EventArgs e)
        {
            this.editButton.Enabled = false;
            this.addButton.Enabled = true;
            this.deleteButton.Enabled = true;
            this.dateTimePicker1.Enabled = true;
            this.dateTimePicker2.Enabled = true;
            this.finishButton.Visible = true;
            this.closeButton.Enabled = false;
        }

        /// <summary>
        /// This method will make unavailable or visible the buttons, textBoxes, comboBoxes, etc. that are necessary
        /// to edit the listView2. Also making available the same editButton and closeButton.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void finishButton_Click(object sender, EventArgs e)
        {
            this.editButton.Enabled = true;
            this.addButton.Enabled = false;
            this.deleteButton.Enabled = false;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker2.Enabled = false;
            this.finishButton.Visible = false;
            this.closeButton.Enabled = true;
        }

        /// <summary>
        /// This method will take the text from the and dateTimePickers to add them in their respective place on
        /// the listview2. Also it at the new information as a new row on the table from the database.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void addButton_Click(object sender, EventArgs e)
        {
            string date = this.dateTimePicker1.Text;
            string time = this.dateTimePicker2.Text;

            int showTimeID = this.listView2.Items.Count;
            int movieID = this.listView1.Items.Count;

            Random rand = new Random();
            int randomMovieID = rand.Next(1, movieID + 1);

            // Adding new data into the listView2.
            listView2.Items.Add(randomMovieID.ToString());
            listView2.Items[showTimeID].SubItems.Add(date + " " + time);

            string dateString = date + " " + time;
            DateTime fullTimeDate = DateTime.Parse(dateString);

            // Adding the new row into the table.
            this.showTimeInfoTableAdapter1.AddShowTimeDataInsertQuery(randomMovieID, showTimeID, fullTimeDate);
        }

        /// <summary>
        /// This method will delete the selected row from the listView2, just if there is a selected row in the
        /// first place. Also it also delete the selected row from the table in the database.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.listView2.SelectedItems.Count < 1)
            {
                MessageBox.Show("Select a column or end the task");
            }
            else
            {
                int showTimeID = int.Parse(listView2.SelectedItems[0].Text);

                this.showTimeInfoTableAdapter1.DeleteSelectedItemQuery(showTimeID);

                this.listView2.SelectedItems[0].Remove();
            }
        }

        /// <summary>
        /// This method will close completely the ShowTimeListForm.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
