using Acr.UserDialogs;
using Beux.Helper;
using Beux.Models;
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
    public partial class TomadeServicioPage : ContentPage
    {
        IUserDialogs Dialogs = UserDialogs.Instance;
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public  TomadeServicioPage()
        {
            InitializeComponent();
            
           
            
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();

            try
            {
                base.OnAppearing();
                var allUsers = await firebaseHelper.GetPersonListClientes();
                Lista.ItemsSource = allUsers;
            }

            catch (Exception ex)
            {
                throw new Exception("OnAppearing  Additional information..." + ex, ex);
            }
        }
        public async void OnClickActivo(object sender, EventArgs args)
        {
            Dialogs.ShowLoading("Espere por favor...");
            await Task.Delay(2000);
            Dialogs.HideLoading();

            if (status.Color == Color.Red)
            {
                status.Color = Color.Green;

            }
            else
            {
                status.Color = Color.Red;
            }

            EncuentroPage myHomePage = new EncuentroPage();
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            await Navigation.PushModalAsync(myHomePage);
        }


        private void EvetClicked(object s, SelectedItemChangedEventArgs e)
        {

            var obj = e.SelectedItem;


        }
    }


}
