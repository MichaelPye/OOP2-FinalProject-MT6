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
    /// <summary>
    /// This is the class definition that contains the code for the ManagerEditForm.
    /// </summary>
    public partial class ManagerEditForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagerEditForm"/> class.
        /// </summary>
        public ManagerEditForm()
        {
            InitializeComponent();
        }

        public void movieButton_Click(object sender, EventArgs e)
        {
            MovieListForm movieList = new MovieListForm();
            movieList.Show();
        }

        /// <summary>
        /// Opens the ManagerSettingsClientButton.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void ManagerSettingsClientButton_Click(object sender, EventArgs e)
        {
            ClientListForm clientList = new ClientListForm();
            clientList.Show();
        }

        /// <summary>
        /// Opens the ManagerSettingsShowtimeButton.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void ManagerSettingsShowtimeButton_Click(object sender, EventArgs e)
        {
            ShowTimeListForm showTime = new ShowTimeListForm();
            showTime.Show();
        }

        /// <summary>
        /// Opens the ManagerSettingsScreeningRoomsButton.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void ManagerSettingsScreeningRoomsButton_Click(object sender, EventArgs e)
        {
            ScreeningRoomListForm screeningRooms = new ScreeningRoomListForm();
            screeningRooms.Show();
        }
    }
}
