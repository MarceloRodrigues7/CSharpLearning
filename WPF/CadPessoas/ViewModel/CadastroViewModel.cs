using CadPessoas.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadPessoas.ViewModel
{
    public class CadastroViewModel : ObservableCollection<Cadastro>
    {
        public CadastroViewModel()
        {
            CadastrosCollection();
        }

        private void CadastrosCollection()
        {
            var cadastroUm = new Cadastro
            {
                Cidade = "São Paulo",
                Nome = "José",
                Sobrenome = "Silva"
            };
            var cadastroDois = new Cadastro
            {
                Cidade = "Rio de Janeiro",
                Nome = "Ana",
                Sobrenome = "Maria"
            };
            var cadastroTres = new Cadastro
            {
                Cidade = "São Paulo",
                Nome = "João",
                Sobrenome = "Costa"
            };
            Add(cadastroUm);
            Add(cadastroDois);
            Add(cadastroTres);
        }
    }
}
