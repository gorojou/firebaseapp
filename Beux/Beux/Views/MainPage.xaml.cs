using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Beux.Models;

namespace Beux.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();
            navigationDrawerList.ItemsSource = GetMasterPageLists();
        }

        private void OnMenuSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageList)e.SelectedItem;

            if (item.Title == "Crear Perfil")
            {
                Detail.Navigation.PushAsync(new CrearPerfilPage());
                IsPresented = false;
            }
            if (item.Title == "Activación")
            {
                Detail.Navigation.PushAsync(new ActivacionPage());
                IsPresented = false;
            }
            if (item.Title == "Toma de Servicio")
            {
                Detail.Navigation.PushAsync(new TomadeServicioPage());
                IsPresented = false;
            }
            if (item.Title == "Toma de Servicio a Domicilio")
            {
                Detail.Navigation.PushAsync(new TomarServicioDomPage());
                IsPresented = false;
            }
            if (item.Title == "Botón de Pánico")
            {
                Detail.Navigation.PushAsync(new BotonPanicoPage());
                IsPresented = false;
            }
            if (item.Title == "Facturación")
            {
                Detail.Navigation.PushAsync(new FacturacionPage());
                IsPresented = false;
            }

            //   else
            // {
            //   Application.Current.Properties["MenuName"] = item.Title;
            // Detail = new NavigationPage(new HomeTabbedPage());
            //IsPresented = false;
            //}
        }
        List<MasterPageList> GetMasterPageLists()
        {
            return new List<MasterPageList>
            {
                new MasterPageList() { Title = "Crear Perfil", Icon = "usuario.png" },
                new MasterPageList() { Title = "Activación", Icon = "puntos.png" },
                new MasterPageList() { Title = "Toma de Servicio", Icon = "puntos.png" },
                new MasterPageList() { Title =  "Toma de Servicio a Domicilio", Icon = "puntos.png" },
                new MasterPageList() { Title =  "Botón de Pánico", Icon = "puntos.png" },
                new MasterPageList() { Title =  "Facturación", Icon = "puntos.png" }





            };
        }
    }

    //This class used for binding ListView. We can move it to other separate files as well   
    public class MasterPageList
    {
        public string Title { get; set; }
        public string Icon { get; set; }
    }
}
