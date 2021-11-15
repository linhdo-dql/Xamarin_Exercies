using System;
using System.Collections.Generic;
using System.Text;

namespace Navigation.Models
{
    public class Activity
    {
        public int UserId { get; set; }
        public string Description { get; set; }
        public string ImageUrl
        {
            set
            {
                this.ImageUrl = value;
            }
            get
            {
                return "https://lorempixel.com/100/100/people/" + this.UserId +"/";
            }  
        }
    }
}
