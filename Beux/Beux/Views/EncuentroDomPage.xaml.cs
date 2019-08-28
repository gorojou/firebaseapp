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
    public partial class EncuentroDomPage : ContentPage
    {
        IUserDialogs Dialogs = UserDialogs.Instance;
        public EncuentroDomPage()
        {
            InitializeComponent();
        }

        public async void OnChatClicked(object sender, EventArgs e)
        {

            Dialogs.ShowLoading("Ingresando...");
            await Task.Delay(2000);
            Dialogs.HideLoading();

            RoomPage myHomePage = new RoomPage();
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            await Navigation.PushModalAsync(myHomePage);

        }
    }
}