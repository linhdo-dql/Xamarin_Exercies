using System;
using System.Collections.Generic;
using System.Text;

namespace Lists.Models
{
    public class Search
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut    { get; set; }

        public Search( int id, string location, DateTime checkIn, DateTime checkOut )
        {
            Id = id;
            Location = location;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public string DetailTime
        {
            get
            {
                return CheckIn.ToString("MMM dd, yyyy") + " - " + CheckOut.ToString("MMM dd, yyyy");
            }
        }
    }
}
