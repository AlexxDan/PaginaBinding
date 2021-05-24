using PaginaBinding.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace PaginaBinding.ViewModels
{
    public class TablaMultiViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _Numero;
        public int Numero
        {
            get { return this._Numero; }
            set
            {
                this._Numero = value;
                RaisePropertyChanged("Numero");
            }
        }


        private List<ModelTabla> _Tabla;

        public List<ModelTabla> Tabla
        {
            get { return this._Tabla; }
            set
            {
                this._Tabla = value;
                RaisePropertyChanged("Tabla");
            }
        }
        private List<ModelTabla> GenerarTabla()
        {
            List<ModelTabla> tabla = new List<ModelTabla>();
            for (int i = 1; i <= 10; i++)
            {
                ModelTabla model = new ModelTabla()
                {
                    Operacion = i + "*" + this.Numero,
                    Resultado = i * this.Numero
                };
                tabla.Add(model);
            }
            return tabla;
        }

        public Command MostraTabla
        {
            get
            {
                return new Command(() =>
                {
                    this.Tabla = this.GenerarTabla();
                });
            }
        }

    }


}
