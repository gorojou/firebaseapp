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
    public partial class ActivacionPage : ContentPage
    {
        private IFirebaseAuthService _firebaseService;
        IUserDialogs Dialogs = UserDialogs.Instance;
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        Color color = new Color();
        public ActivacionPage()
        {
            InitializeComponent();
            _firebaseService = DependencyService.Get<IFirebaseAuthService>();
        }

        public async void OnClickActivo(object sender, EventArgs args)
        {
            Dialogs.ShowLoading("Espere por favor...");
            await Task.Delay(2000);
            Dialogs.HideLoading();
            string user = _firebaseService.GetUserId();
            if (status.Color == Color.Red)
            {
                status.Color = Color.Green;
                
                var selectedValue = lstpreferencias.Items[lstpreferencias.SelectedIndex];
                var hora = valor.Text;
                await firebaseHelper.ActivacionPerson(user,hora, selectedValue);

            }
            else
            {
                status.Color = Color.Red;
                var selectedValue = "D";
                var hora = "D";
                await firebaseHelper.ActivacionPerson(user, hora, selectedValue);
            }
        }
      }
}