﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Navigation.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl {
            get
            {
                return "https://lorempixel.com/200/200/people/" + this.Id +"/";
            }
        }
    }
}
