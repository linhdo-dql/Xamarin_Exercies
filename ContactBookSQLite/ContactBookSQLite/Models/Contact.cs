using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ContactBookSQLite.Models
{
    public class Contact : INotifyPropertyChanged
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        private string _fName;

        public string FName
        {
            get { return _fName; }
            set
            {
                if ( value == null )
                    return;
                _fName = value;
                OnNotifyChanged();
                OnNotifyChanged(nameof(_fName));
            }
        }

        private string _lName;

        public string LName
        {
            get { return _lName; }
            set 
            {
                if ( value == null )
                    return;
                _lName = value;
                OnNotifyChanged();
                OnNotifyChanged(nameof(_lName));
            }
        }

        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private string _email;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public bool IsBlock { get; set; }

        public string FullName => BehaviorFName(FName) +" "+ LName;

        public void OnNotifyChanged( [CallerMemberName] string name = null )
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public string BehaviorFName(string fName)
        {
            var fNames = fName.Split(' ');
            return fNames[0];
        } 


    }
}
