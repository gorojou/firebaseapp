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
    public partial class EncuentroPage : ContentPage
    {
        IUserDialogs Dialogs = UserDialogs.Instance;
        public EncuentroPage()
        {
            InitializeComponent();
        }

        public async void OnChatClicked(object sender, EventArgs e)
        {

            Dialogs.ShowLoading("Ingresando...");
            await Task.Delay(2000);
            Dialogs.HideLoading();

            var myHomePage = new NavigationPage(new RoomPage());
           
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);

        }
    }
}