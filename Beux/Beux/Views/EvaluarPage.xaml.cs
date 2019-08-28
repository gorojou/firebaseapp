using Acr.UserDialogs;
using Beux.ViewModels;
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
    public partial class EvaluarPage : ContentPage
    {
        RatingViewModel viewModel;
        IUserDialogs Dialogs = UserDialogs.Instance;

        public EvaluarPage()
        {
            InitializeComponent();
            this.BindingContext = viewModel;
        }

        public async void OnEvaluarClicked(object sender, EventArgs e)
        {
            var result = await UserDialogs.Instance.ConfirmAsync(new ConfirmConfig
            {
                Message = "Continuar en línea?",
                OkText = "Si",
                CancelText = "NO"
            });
            if (result)
            {
                MainPage myHomePage = new MainPage();
                NavigationPage.SetHasNavigationBar(myHomePage, false);
                await Navigation.PushModalAsync(myHomePage);
            }
            

           

        }
    }
}