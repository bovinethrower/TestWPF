using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace TestWPF
{
    public class Contact : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string[] STATES = { "MO" };
        private string _FirstName, _LastName, _Address, _City, _State;
        private int? _Phone, _Zip;

        // base properties
        public string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                this._FirstName = value;
                this.OnPropertyChanged("FirstName");
                this.OnPropertyChanged("FullName");
            }
        }

        public string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                this._LastName = value;
                this.OnPropertyChanged("LastName");
                this.OnPropertyChanged("FullName");
            }
        }

        public int? Phone
        {
            get
            {
                return this._Phone;
            }
            set
            {
                this._Phone = value;
                this.OnPropertyChanged("Phone");
            }
        }

        public string Address
        {
            get
            {
                return this._Address;
            }
            set
            {
                this._Address = value;
                this.OnPropertyChanged("Address");
            }
        }

        public string City
        {
            get
            {
                return this._City;
            }
            set
            {
                this._City = value;
                this.OnPropertyChanged("City");
            }
        }

        public string State
        {
            get
            {
                return this._State;
            }
            set
            {
                this._State = value;
                this.OnPropertyChanged("State");
            }
        }

        public int? Zip
        {
            get
            {
                return this._Zip;
            }
            set
            {
                this._Zip = value;
                this.OnPropertyChanged("Zip");
            }
        }

        // generated properties
        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }

        // don't set anything for an entirely new contact
        public Contact()
        {
        }

        public Contact(string first, string last)
        {
            this._FirstName = first;
            this._LastName = last;
        }

        public override string ToString()
        {
            return this.FullName;
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
