using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Beux.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExtensionPage : ContentPage
    {
        IUserDialogs Dialogs = UserDialogs.Instance;
        public ExtensionPage()
        {
            InitializeComponent();
        }

        public async void OnNOClicked(object sender, EventArgs e)
        {

            Dialogs.ShowLoading("Generando Factura...");
            await Task.Delay(2000);
            Dialogs.HideLoading();

            FacturacionPage myHomePage = new FacturacionPage();
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            await Navigation.PushModalAsync(myHomePage);

        }
    }
}