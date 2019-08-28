using Acr.UserDialogs;
using Beux.ViewModels.Login;
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
    public partial class LoginPage : ContentPage
    {
        IUserDialogs Dialogs = UserDialogs.Instance;
        LoginViewModel viewModel;
        public LoginPage()
        {
            InitializeComponent();
            LoginViewModel loginView = new LoginViewModel(Dialogs);
            this.BindingContext= loginView;
        }
        protected override void OnAppearing()
        {
            viewModel = BindingContext as LoginViewModel;

            if (viewModel != null) viewModel.OnAppearing(null);
        }

        public async void OnLogInClicked(object sender, EventArgs e)
        {

            Dialogs.ShowLoading("Ingresando...");
            await Task.Delay(2000);
            Dialogs.HideLoading();

            MainPage myHomePage = new MainPage();
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            await Navigation.PushModalAsync(myHomePage);

        }

        public async void ClickedSignin(object sender, EventArgs e)
        {

            Dialogs.ShowLoading("Espere por favor...");
            await Task.Delay(2000);
            Dialogs.HideLoading();

            RegistroPage myHomePage = new RegistroPage();
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            await Navigation.PushModalAsync(myHomePage);
        }
    }
}