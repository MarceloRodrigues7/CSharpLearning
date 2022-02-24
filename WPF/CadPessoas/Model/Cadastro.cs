using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadPessoas.Model
{
    public class Cadastro : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _nome;
        private string _sobrenome;
        private string _cidade;

        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                OnPropertyChanged("Nome");
            }
        }

        public string Sobrenome
        {
            get { return _sobrenome; }
            set
            {
                _sobrenome = value;
                OnPropertyChanged("Sobrenome");
            }
        }

        public string Cidade
        {
            get { return _cidade; }
            set
            {
                _cidade = value;
                OnPropertyChanged("Cidade");
            }
        }

    }
}
