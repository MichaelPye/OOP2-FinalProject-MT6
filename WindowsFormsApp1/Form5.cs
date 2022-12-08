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
    public partial class ManagerEditForm : Form
    {
        public ManagerEditForm()
        {
            InitializeComponent();
        }

        private void movieButton_Click(object sender, EventArgs e)
        {
            MovieListForm movieList = new MovieListForm();
            movieList.Show();
        }

        private void ManagerSettingsClientButton_Click(object sender, EventArgs e)
        {
            ClientListForm clientList = new ClientListForm();
            clientList.Show();
        }

        private void ManagerSettingsShowtimeButton_Click(object sender, EventArgs e)
        {
            ShowTimeListForm showTime = new ShowTimeListForm();
            showTime.Show();
        }

        private void ManagerSettingsScreeningRoomsButton_Click(object sender, EventArgs e)
        {
            ScreeningRoomListForm screeningRooms = new ScreeningRoomListForm();
            screeningRooms.Show();
        }
    }
}
