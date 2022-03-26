using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingWpf.Model
{
    public class Person : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private int _age;
        private int _idCity;
        private City _city;

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                Notify("Id");
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                Notify("Name");
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                Notify("Age");
            }
        }

        public int IdCity
        {
            get { return _idCity; }
            set
            {
                _idCity = value;
                Notify("IdCity");
            }
        }

        public City City
        {
            get { return _city; }
            set
            {
                _city = value;
                Notify("City");
            }
        }

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void Notify(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        #endregion

    }
}
