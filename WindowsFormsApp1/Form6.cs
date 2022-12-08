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
    public partial class MovieListForm : Form
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
        /// Initializes a new instance of the <see cref="MovieListForm"/> class.
        /// This class will open the MovieListForm.
        /// </summary>
        public MovieListForm()
        {
            InitializeComponent();

            // Building columns for the listView1.
            listView1.Columns.Add("MovieID", 60);
            listView1.Columns.Add("MovieName", 80);
            listView1.Columns.Add("Genre", 70);
            listView1.Columns.Add("ReleaseDate", 135);
            listView1.View = View.Details;

            // Opening the SQL Connection to make your query.
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Movies", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "MovieTable");
            con.Close();

            // Naming the Table and adding it's information into the listView1.
            dt = ds.Tables["MovieTable"];
            for(int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listView1.Items.Add(dt.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
            }
        }

        /// <summary>
        /// This method will make available or visible the buttons, textBoxes, comboBoxes, etc. that are necessary
        /// to edit the listView1. Also making unavailable the same editButton and closeButton.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void editButton_Click(object sender, EventArgs e)
        {
            this.editButton.Enabled = false;
            this.addButton.Enabled = true;
            this.deleteButton.Enabled = true;
            this.nameTextBox.Enabled = true;
            this.genreComboBox.Enabled = true;
            this.dateTimePicker1.Enabled = true;
            this.finishButton.Visible = true;
            this.closeButton.Enabled = false;
        }

        /// <summary>
        /// This method will take the text from the textBox, comboBox, and dateTimePicker to add them in their
        /// respective place on the listview1. Also it at the new information as a new row on the table from the
        /// database.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void addButton_Click(object sender, EventArgs e)
        {
            string movieName;
            string genre;
            string releaseDate;
            if (this.nameTextBox.Text == "")
            {
                MessageBox.Show("Please, put a movie or finish edit task");
            } else if (this.genreComboBox.Text == "")
            {
                MessageBox.Show("Please, select a genre or finish edit task");
            } else
            {
                movieName = this.nameTextBox.Text;
                genre = this.genreComboBox.SelectedItem.ToString();
                releaseDate = this.dateTimePicker1.Text;

                int movieID = this.listView1.Items.Count + 1;

                // Adding new data into the listView1.
                listView1.Items.Add(movieID.ToString());
                listView1.Items[movieID - 1].SubItems.Add(movieName);
                listView1.Items[movieID - 1].SubItems.Add(genre);
                listView1.Items[movieID - 1].SubItems.Add(releaseDate);

                // Adding the new row into the table.
                this.moviesTableAdapter1.AddMovieDataQuery(movieName, genre, releaseDate);
            }
        }

        /// <summary>
        /// This method will make unavailable or visible the buttons, textBoxes, comboBoxes, etc. that are necessary
        /// to edit the listView1. Also making available the same editButton and closeButton.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void finishButton_Click(object sender, EventArgs e)
        {
            this.nameTextBox.Text = "";
            this.genreComboBox.Text = "";

            this.editButton.Enabled = true;
            this.addButton.Enabled = false;
            this.deleteButton.Enabled = false;
            this.nameTextBox.Enabled = false;
            this.genreComboBox.Enabled = false;
            this.dateTimePicker1.Enabled = false;
            this.finishButton.Visible = false;
            this.closeButton.Enabled = true;
        }

        /// <summary>
        /// This method will close completely the MovieListForm.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This method will delete the selected row from the listView1, just if there is a selected row in the
        /// first place. Also it also delete the selected row from the table in the database.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Select a column or end the task");
            } else
            {
                int movieID = int.Parse(listView1.SelectedItems[0].Text);

                this.moviesTableAdapter1.DeleteSelectedItemQuery(movieID);

                this.listView1.SelectedItems[0].Remove();
            }
        }
    }
}
