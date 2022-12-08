using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Setting all the properites of the object with Get,Set Statements.
    /// </summary>
    internal class Movie
    {
        /// <summary>
        /// Gets and sets MovieName.
        /// </summary>
        public string MovieName { get; set; }

        /// <summary>
        /// Gets and sets MovieId.
        /// </summary>
        public int MovieId { get; set; }

        /// <summary>
        /// Gets and sets ScreenRoomNum.
        /// </summary>
        public int ScreenRoomNum { get; set; }

        /// <summary>
        /// Gets and sets ScreenRoomId.
        /// </summary>
        public int ScreenRoomId { get; set; }

        /// <summary>
        /// Gets and sets ShowTime.
        /// </summary>
        public DateTime ShowTime { get; set; }

        /// <summary>
        /// Gets and sets ShowTimeId.
        /// </summary>
        public int ShowTimeId { get; set; }

        /// <summary>
        /// Gets and sets MovieGenre.
        /// </summary>
        public string MovieGenre { get; set; }

        /// <summary>
        /// Gets and sets MovieReleaseDate.
        /// </summary>
        public string MovieReleaseDate { get; set; }

        /// <summary>
        /// This class contains the defualt constructors for the properites.
        /// </summary>
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

        /// <summary>
        /// These are the Paramaterized constructors for the Movie class.
        /// </summary>
        /// <param name="movieName">This is the movie name for the client.</param>
        /// <param name="movieId">This is the movie id for the manager.</param>
        /// <param name="screenRoomNum">This is the screen room number for the client.</param>
        /// <param name="screenRoomId">this is the screen room id for the manager.</param>
        /// <param name="showTime">This is the showtime for the client.</param>
        /// <param name="showTimeId">This is the showtime id for the manager</param>
        /// <param name="movieGenre">This is the movie genre for the client.</param>
        /// <param name="movieReleaseDate">This is the movie release date for the client.</param>
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
