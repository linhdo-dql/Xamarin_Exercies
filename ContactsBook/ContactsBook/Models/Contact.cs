using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ContactsBook.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsBlock     { get; set; }

        public string FullName => BehaviorName(FirstName)+ " " + LastName;
        public string BehaviorName( string str )
        {
            var arrStr = str.Split(' ');
            return arrStr[0];
        }
    }
}
