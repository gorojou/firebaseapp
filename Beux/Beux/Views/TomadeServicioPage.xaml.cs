﻿using Acr.UserDialogs;
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
        public TomadeServicioPage()
        {
            InitializeComponent();
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
    }
}
