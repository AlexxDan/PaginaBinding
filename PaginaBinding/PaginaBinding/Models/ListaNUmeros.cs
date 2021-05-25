using PaginaBinding.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaginaBinding.Models
{
    public class ListaNumeros
    {
        public List<NumeroViewModels> Numeros
        {
            get
            {
                Random random= new Random();
                List<NumeroViewModels> lista = new List<NumeroViewModels>();
                for (int i=1;i<=17;i++)
                {
                    int valor = random.Next(-25, 25);
                    NumeroViewModels model = new NumeroViewModels();
                    model.Valor = valor;
                    lista.Add(model);
                }
                return lista;
            }
        }
    }
}
