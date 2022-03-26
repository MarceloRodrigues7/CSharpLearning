using BindingWpf.Database;
using BindingWpf.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingWpf.ViewModel
{
    public class PersonVM :PropertyChangedBase
    {
        private ObservableCollection<Person> _persons;
        private Person _person;
        private ObservableCollection<City> _cities;
        private City _city;

        public PersonVM()
        {
            _person = new();
            _persons = new();
            _city= new();
            _cities = new();
            GetCities(this);
        }

        public ObservableCollection<Person> Persons
        {
            get { return _persons; }
            set
            {
                _persons = value;
                PropertyChange();
            }
        }
        public Person Person
        {
            get { return _person; }
            set
            {
                _person = value;
                PropertyChange();
            }
        }
        public ObservableCollection<City> Cities
        {
            get { return _cities; }
            set
            {
                _cities = value;
                PropertyChange();
            }
        }
        public City City
        {
            get { return _city; }
            set
            {
                _city = value;
                PropertyChange();
            }
        }
                

        public void GetCities(PersonVM vm)
        {
            using (var ado = new Ado())
            {
                vm._cities = new ObservableCollection<City>(ado.Cities.ToList());
            };
        }

        public void Insert()
        {
            using (var ado = new Ado())
            {
                ado.Cities.Add(this.City);
                ado.SaveChanges();
            };
        }
    }
}
