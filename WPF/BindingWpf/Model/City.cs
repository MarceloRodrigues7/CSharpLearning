using BindingWpf.Database;
using BindingWpf.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingWpf.Model
{
    public class City : PropertyChangedBase
    {
        private int _id;
        private string _name;
        private List<Person> _persons;

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                PropertyChange();
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                PropertyChange();
            }
        }

        public List<Person> Persons
        {
            get { return _persons; }
            set
            {
                _persons = value;
                PropertyChange();
            }
        }
                        
    }
}
