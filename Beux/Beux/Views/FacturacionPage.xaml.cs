using Acr.UserDialogs;
using Beux.Helper;
using Beux.Services.FirebaseAuth;
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
    public partial class FacturacionPage : ContentPage
    {
        IUserDialogs Dialogs = UserDialogs.Instance;
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        private IFirebaseAuthService _firebaseService;
        public FacturacionPage()
        {
            InitializeComponent();
            _firebaseService = DependencyService.Get<IFirebaseAuthService>();
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();

            try
            {
                base.OnAppearing();
                var user = _firebaseService.GetUserId();
                var factura = await firebaseHelper.GetPerson(user);
                valorh.Text = factura.ValorHora;
                valorh1.Text = factura.ValorHora;
            }

            catch (Exception ex)
            {
                throw new Exception("OnAppearing  Additional information..." + ex, ex);
            }
        }
        private async void Evaluar_Clicked(object sender, EventArgs e)
        {
            Dialogs.ShowLoading("Espere por favor...");
            await Task.Delay(2000);
            Dialogs.HideLoading();

            EvaluarPage myHomePage = new EvaluarPage();
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            await Navigation.PushModalAsync(myHomePage);
        }
    }
}