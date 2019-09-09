using Acr.UserDialogs;
using Beux.Helper;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.FirebaseStorage;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using Firebase.Storage;
using Beux.ViewModels.Login;
using Beux.Services.FirebaseAuth;

namespace Beux.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroPage : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        private IFirebaseAuthService _firebaseService;
        IUserDialogs Dialogs = UserDialogs.Instance;
        MediaFile files;
        SignUpViewModel viewModel;
        public RegistroPage()
        {
            InitializeComponent();
            _firebaseService = DependencyService.Get<IFirebaseAuthService>();
            this.BindingContext = viewModel;
        }
        public async void OnclickPickPhoto(object sender, EventArgs args)
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

            image.Source = ImageSource.FromStream(() =>
            {
                var imageStram = files.GetStream();
                //  files.Dispose();

                return imageStram;


            });
        }
        public async void OnclickTakePhoto(object sender, EventArgs args)
        {
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

            image.Source = ImageSource.FromStream(() =>
            {
                var imageStram = files.GetStream();
                // files.Dispose();


                return imageStram;
            });
        }
        public async Task<string> StoreImages(Stream imageStream)
        {
            var stroageImage = await new FirebaseStorage("gs://upick-app-c921d.appspot.com")
                .Child(nickname.Text)
                .Child(nickname.Text+".jpg")
                .PutAsync(imageStream);
            string imgurl = stroageImage;
            return imgurl;
        }


        public async void OnClickedFinalizar(object sender, EventArgs args)
        {
            var prueba = files.GetStream();
           




            if (!string.IsNullOrWhiteSpace(nickname.Text) && !string.IsNullOrWhiteSpace(email.Text) && !string.IsNullOrWhiteSpace(celular.Text)

               && !string.IsNullOrWhiteSpace(password.Text) && files!=null)
                 
            {
               
                
                try
                {
                    var selectedValue = genero.Items[genero.SelectedIndex];

                    string user = _firebaseService.GetUserId();


                    Dialogs.ShowLoading("Registrando"); ;
                    await Task.Delay(4000);
                    Dialogs.HideLoading();
                    await firebaseHelper.AddPerson(user, nickname.Text, email.Text, celular.Text, codPromocional.Text, selectedValue.ToString(), password.Text, "true", "true","P","I", "N");
                    nickname.Text = string.Empty;
                    email.Text = string.Empty;
                    celular.Text = string.Empty;
                    codPromocional.Text = string.Empty;
                    password.Text = string.Empty;
                    passwordconf.Text = string.Empty;
                    var stroageImage = await new FirebaseStorage("upick-app-c921d.appspot.com")
                       .Child("Prestador")
                       .Child(user+".jpg")
                       .PutAsync(files.GetStream());
                    await DisplayAlert("Success", "Se ha registrado exitosamente", "OK");


                    CrearPerfilPage myHomePage = new CrearPerfilPage();
                    NavigationPage.SetHasNavigationBar(myHomePage, false);
                    await Navigation.PushModalAsync(myHomePage);
                }

                catch (Exception ex)
                {
                    await DisplayAlert("Registrarse Error", ex.Message, "Gracias");

                }

            }


            else
            {
                await DisplayAlert("Registrarse", "Verifique la Información", "Gracias");
            }

        }

       
    }
}