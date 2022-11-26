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
    public partial class ClientMovieSelectionForm : Form
    {
        public ClientMovieSelectionForm()
        {
            InitializeComponent();
        }

        private void ClientMovieSelectionButton_Click(object sender, EventArgs e)
        {
            ClientEticketQrCodeForm frm = new ClientEticketQrCodeForm();
            frm.Show();
        }

        private void ClientMovieSelectionForm_Load(object sender, EventArgs e)
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
