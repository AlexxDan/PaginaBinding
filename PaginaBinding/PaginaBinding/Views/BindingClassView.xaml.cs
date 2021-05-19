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
            car.Imagen = @"https://cdn.autobild.es/sites/navi.axelspringer.es/public/styles/1200/public/media/image/2019/12/volkswagen-golf-8.jpg?itok=JbvGikcl";
            this.BindingContext = car;
          //  Subir imagen a un bucket
        }
    }
}