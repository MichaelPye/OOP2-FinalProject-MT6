using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    internal class Movie
    {
        public string MovieName { get; set; }

        public int MovieId { get; set; }

        public int ScreenRoomNum { get; set; }

        public int ScreenRoomId { get; set; }

        public DateTime ShowTime { get; set; }

        public int ShowTimeId { get; set; }

        public string MovieGenre { get; set; }

        public string MovieReleaseDate { get; set; }

        public Movie()
        {
            MovieName = "";
            MovieId = 0;
            ScreenRoomNum = 0;
            ScreenRoomId = 0;
            ShowTime = new DateTime();
            ShowTimeId = 0;
            MovieGenre = "";
            MovieReleaseDate = "";
        }

        public Movie(string movieName, int movieId, int screenRoomNum, int screenRoomId, DateTime showTime, int showTimeId, string movieGenre, string movieReleaseDate)
        {
            MovieName = movieName;
            MovieId = movieId;
            ScreenRoomNum = screenRoomNum;
            ScreenRoomId = screenRoomId;
            ShowTime = showTime;
            ShowTimeId = showTimeId;
            MovieGenre = movieGenre;
            MovieReleaseDate = movieReleaseDate;
        }
    }
}
