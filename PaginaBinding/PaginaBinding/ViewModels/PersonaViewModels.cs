using PaginaBinding.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PaginaBinding.ViewModels
{
    public class PersonaViewModels : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(String PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private Persona _Persona;

        public Persona Persona
        {
            get { return this._Persona; }
            set
            {
                this._Persona = value;
                RaisePropertyChanged("Persona");
            }
        }

        private String _Descripcion;

        public String Descripcion
        {
            get { return this._Descripcion; }

            set
            {
                this._Descripcion = value;
                RaisePropertyChanged("Descripcion");
            }
        }

        public PersonaViewModels()
        {
            this.Persona = new Persona();
            
        }
    }
}
