using Plugin.Messaging;
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
    public partial class BotonPanicoPage : ContentPage
    {
        public BotonPanicoPage()
        {
            InitializeComponent();
        }

        public  void BtnCall_Click(object sender, EventArgs e)
        {

            
            var phoneDial = CrossMessaging.Current.PhoneDialer;

            if (phoneDial.CanMakePhoneCall)
            {
                phoneDial.MakePhoneCall("*911", "Botón de Pánico");
            }

        }
    }
}