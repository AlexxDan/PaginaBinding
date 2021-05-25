using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PaginaBinding.ViewModels
{
    public class NumeroViewModels : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(String propetyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propetyName));
        }

        private int _Valor;
        public int Valor
        {
            get { return this._Valor; }
            set
            {
                this._Valor = value;
                OnPropertyChanged("Valor");
            }
        }
    }
}
