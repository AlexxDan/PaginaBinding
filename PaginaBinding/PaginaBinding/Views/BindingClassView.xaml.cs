using PaginaBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaginaBinding.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingClassView : ContentPage
    {
        public BindingClassView()
        {
            InitializeComponent();

            Coches car = new Coches();
            car.Marca = "Volkswagen";
            car.Modelo = "GOLF 8";
            car.Velociad=280;
            car.Imagen = @"https://soymotor.com/sites/default/files/imagenes/noticia/volkswagen-golf-8-r-line-frontal-soymotor.jpg";
            this.BindingContext = car;
          //  Subir imagen a un bucket
        }
    }
}