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
    /// This is the class definition that contains the code for the ClientMovieSelectionForm.
    /// </summary>
    public partial class ClientMovieSelectionForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMovieSelectionForm"/> class.
        /// </summary>
        public ClientMovieSelectionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event opens/generates ClientEticketQrCodeForm.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void ClientMovieSelectionButton_Click(object sender, EventArgs e)
        {
            ClientEticketQrCodeForm frm = new ClientEticketQrCodeForm();
            frm.Show();
        }

        /// <summary>
        /// Connect to MTDB to display Movies and their corresponding info.
        /// </summary>
        /// <param name="sender">Pressing Button.</param>
        /// <param name="e">Invalid Input.</param>
        public void ClientMovieSelectionForm_Load(object sender, EventArgs e)
        {
             ClientMovieDataDataContext db = new ClientMovieDataDataContext();

            foreach (Movy item in db.Movies)
            {
                ClientMovieListBox.Items.Add(item.MovieName);
            }

            foreach (ShowTimeInfo item in db.ShowTimeInfos)
            {
                ClientShowTimeListBox.Items.Add(item.ActualShowTimeDateTime);
            }

            foreach (ScreeningRoomInfo item in db.ScreeningRoomInfos)
            {
                ClientIdListBox.Items.Add(item.ScreeningRoomNumber);
            }

            foreach (Movy item in db.Movies)
            {
                ClientGenreListBox.Items.Add(item.Genre);
            }
        }
    }
}
