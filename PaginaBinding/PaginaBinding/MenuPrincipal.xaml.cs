using PaginaBinding.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaginaBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPrincipal : MasterDetailPage
    {
        public MenuPrincipal()
        {
            InitializeComponent();

            List<MaterPageItem> pagines = new List<MaterPageItem>();
            var page1 = new MaterPageItem()
            {
                Titulo = "Pagina HIja 1",
                PaginaTypo = typeof(PaginaHija)
            };
            var page2 = new MaterPageItem()
            {
                Titulo = "Pagina HIja 2",
                PaginaTypo = typeof(PaginaHIja2)
            };
            var page3 = new MaterPageItem()
            {
                Titulo = "Tabla Multiplicar",
                PaginaTypo = typeof(TablaMultiplicarViews)
            };
            var page4 = new MaterPageItem()
            {
                Titulo = "Carusel",
                PaginaTypo = typeof(Carusel)
            };

            pagines.Add(page1);
            pagines.Add(page2);
            pagines.Add(page3);
            pagines.Add(page4);

            this.listviewmenu.ItemsSource = pagines;
            this.Detail = new NavigationPage(
                (Page) Activator.CreateInstance(
                    typeof(PaginaHija)));

            this.listviewmenu.ItemSelected += Listviewmenu_ItemSelected;
        }

        private void Listviewmenu_ItemSelected(object sender
            , SelectedItemChangedEventArgs e)
        {
            var page = (MaterPageItem)e.SelectedItem;
            Type type = page.PaginaTypo;

            this.Detail = new NavigationPage((Page)
                Activator.CreateInstance(type));

            this.IsPresented = false;

        }
    }
}