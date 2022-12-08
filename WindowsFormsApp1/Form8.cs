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
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\le1770426\\Desktop\\Fall 2022\\OOP 2\\GIT\\CRCMDB 3.0\\OOP2Final\\OOP2-FinalProject-MT6\\WindowsFormsApp1\\bin\\Debug\\MTDBTEST.mdf\";Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;

        public ShowTimeListForm()
        {
            InitializeComponent();

            //First listView

            listView1.Columns.Add("CurrentMovies", 90);
            listView1.Columns.Add("ID", 30);
            listView1.View = View.Details;

            con.Open();
            cmd = new SqlCommand("SELECT MovieName, MovieID FROM Movies", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "NameTable");
            con.Close();

            dt = ds.Tables["NameTable"];
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listView1.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
            }

            //Second listView

            listView2.Columns.Add("MovieID", 80);
            listView2.Columns.Add("ActualShowTimeDateTime", 150);
            listView2.View = View.Details;

            con.Open();
            cmd = new SqlCommand("SELECT MovieID, ActualShowTimeDateTime FROM ShowTimeInfo", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "ShowTimeTable");
            con.Close();

            dt = ds.Tables["ShowTimeTable"];
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listView2.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listView2.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.editButton.Enabled = false;
            this.addButton.Enabled = true;
            this.deleteButton.Enabled = true;
            this.dateTimePicker1.Enabled = true;
            this.dateTimePicker2.Enabled = true;
            this.finishButton.Visible = true;
            this.closeButton.Enabled = false;
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            this.editButton.Enabled = true;
            this.addButton.Enabled = false;
            this.deleteButton.Enabled = false;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker2.Enabled = false;
            this.finishButton.Visible = false;
            this.closeButton.Enabled = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string date = this.dateTimePicker1.Text;
            string time = this.dateTimePicker2.Text;

            int showTimeID = this.listView2.Items.Count;
            int movieID = this.listView1.Items.Count;

            Random rand = new Random();
            int randomMovieID = rand.Next(1, movieID + 1);

            listView2.Items.Add(randomMovieID.ToString());
            listView2.Items[showTimeID].SubItems.Add(date + " " + time);

            string dateString = date + " " + time;
            DateTime fullTimeDate = DateTime.Parse(dateString);

            this.showTimeInfoTableAdapter1.AddShowTimeDataInsertQuery(randomMovieID, showTimeID, fullTimeDate);
        }

        private void deleteButton_Click(object sender, EventArgs e)
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
