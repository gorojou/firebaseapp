using Acr.UserDialogs;
using Beux.Helper;
using Beux.ViewModels;
using Plugin.Media;
using Plugin.Media.Abstractions;
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
    public partial class CrearPerfilPage : ContentPage
    {
        CrearPerfilViewModel pageModel;
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        IUserDialogs Dialogs = UserDialogs.Instance;
        MediaFile files;
        public CrearPerfilPage()
        {
            InitializeComponent();
            pageModel = new CrearPerfilViewModel(this);
            BindingContext = pageModel;
        }
        public async void OnclickPickPhoto(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Fotos no soportadas", ":( Sin permiso para fotos.", "OK");
                return;
            }
            files = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
            {
                PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,


            });


            if (files == null)
                return;

         //   image.Source = ImageSource.FromStream(() =>
           // {
             //   var imageStram = files.GetStream();
                //  files.Dispose();

               // return imageStram;


            //});
        }

       public async void OnclickTakePhoto(object sender, EventArgs e)
        {

            Dialogs.ShowLoading("Espere por favor...");
            await Task.Delay(2000);
            Dialogs.HideLoading();


            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("Sin Camara", ":( No hay camara disponible.", "OK");
                return;
            }

            files = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {


                PhotoSize = PhotoSize.Custom,
                CustomPhotoSize = 90, //Resize to 90% of original
                CompressionQuality = 92,
                SaveToAlbum = true,
                AllowCropping = true



            });

            if (files == null)
                return;

           // image.Source = ImageSource.FromStream(() =>
            //{
              //  var imageStram = files.GetStream();
                // files.Dispose();


                //return imageStram;
            //});

            //await DisplayAlert("El archivo lo encontraras en:", file.GetStream().ToString(), "OK");

            //MainPage myHomePage = new MainPage();
            //NavigationPage.SetHasNavigationBar(myHomePage, false);
            // await Navigation.PushModalAsync(myHomePage);
       
         
        }
        public async void OnCrearPerfilClick(object sender, EventArgs e)
        {
            Dialogs.ShowLoading("Espere por favor...");
            await Task.Delay(2000);
            Dialogs.HideLoading();

            MainPage myHomePage = new MainPage();
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            await Navigation.PushModalAsync(myHomePage);

        }
            

    }
}