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
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\OOP2\\Final Project - Gonzalo_Michael\\OOP2-FinalProject-MT6\\WindowsFormsApp1\\MTDBTEST.mdf\";Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;

        public MovieListForm()
        {
            InitializeComponent();

            listView1.Columns.Add("MovieID", 60);
            listView1.Columns.Add("MovieName", 80);
            listView1.Columns.Add("Genre", 70);
            listView1.Columns.Add("ReleaseDate", 130);
            listView1.View = View.Details;

            con.Open();
            cmd = new SqlCommand("SELECT * FROM Movies", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "MovieTable");
            con.Close();

            dt = ds.Tables["MovieTable"];
            for(int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listView1.Items.Add(dt.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
            }
        }

        private void editButton_Click(object sender, EventArgs e)
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

        private void addButton_Click(object sender, EventArgs e)
        {
            string movieName;
            string genre;
            string releaseDate;
            if (this.nameTextBox.Text == "")
            {
                MessageBox.Show("Please, put a movie or finish edit task");
            } else if(this.genreComboBox.Text == "")
            {
                MessageBox.Show("Please, select a genre or finish edit task");
            } else
            {
                movieName = this.nameTextBox.Text;
                genre = this.genreComboBox.SelectedItem.ToString();
                releaseDate = this.dateTimePicker1.Text;

                int movieID = this.listView1.Columns.Count;

                listView1.Items.Add(movieID.ToString());
                listView1.Items[movieID - 1].SubItems.Add(movieName);
                listView1.Items[movieID - 1].SubItems.Add(genre);
                listView1.Items[movieID - 1].SubItems.Add(releaseDate);

                this.moviesTableAdapter1.AddMovieDataQuery(movieName, genre, releaseDate);
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            this.editButton.Enabled = true;
            this.addButton.Enabled = false;
            this.deleteButton.Enabled = false;
            this.nameTextBox.Enabled = false;
            this.genreComboBox.Enabled = false;
            this.dateTimePicker1.Enabled = false;
            this.finishButton.Visible = false;
            this.closeButton.Enabled = true;
        }
    }
}
