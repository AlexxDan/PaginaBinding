using PaginaBinding.ViewModels;
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
    public partial class CancionesViews : ContentPage
    {
        public CancionesViews()
        {
            InitializeComponent();
            List<Cancion> canciones = new List<Cancion>()
            {
                new Cancion()
                {
                    Artista="Disturbed",
                    Titulo="The Sound Of Silence",
                    Imagen="https://www.almendron.com/blog/wp-content/images/2019/09/disturbed-the-sound-of-silence.jpg"
                },
                new Cancion()
                {
                    Artista="Rammstein",
                    Titulo="Amerika",
                    Imagen="https://i.ytimg.com/vi/Rr8ljRgcJNM/maxresdefault.jpg"
                },
                new Cancion()
                {
                    Artista="Three Days Grace",
                    Titulo="Animal",
                    Imagen="https://i.ytimg.com/vi/gr7fPGNLGJg/maxresdefault.jpg"
                },
                new Cancion()
                {
                    Artista="Skillet",
                    Titulo="Hero",
                    Imagen="http://1.bp.blogspot.com/-QZTI1aZEqnA/U3vSo06xRmI/AAAAAAAAAJ0/YJ7l0XdrkkQ/s1600/skillethero.jpg"
                }
            };
            this.listviewcanciones.ItemsSource = canciones;

        }
    }
}