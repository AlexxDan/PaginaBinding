using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace PaginaBinding.ViewModels
{
    public class TiempoViewModels : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaiseEventChanged(String propertyName)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
            
        }

        public String Year { get; set; }
        public String Mes { get; set; }
        public String Dia { get; set; }

       // public String Hora { get; set; }
        private String _Hora;

        public String Hora
        {
            get { return this._Hora; }
            set
            {
                this._Hora = value;
                RaiseEventChanged("Hora");
            }
        }

        private DateTime _Tiempo;
        public DateTime Tiempo
        {
            get { return this._Tiempo; }
            set
            {
                this._Tiempo = DateTime.Now;
                RaiseEventChanged("Tiempo");
            }
        }

        public TiempoViewModels()
        {
            this.Dia = DateTime.Now.DayOfWeek.ToString();
            this.Mes = DateTime.Now.ToString("MMMM");
            this.Year = "Year :" + DateTime.Now.Year;
            this.Hora = DateTime.Now.ToLongTimeString();
            this.Tiempo = DateTime.Now;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
             {
                 this.Hora = DateTime.Now.ToLongTimeString();
                 this.Tiempo = DateTime.Now;
                 return true;
             });
        }
    }
}
