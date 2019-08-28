using Acr.UserDialogs;
using Beux.Models;
using Rg.Plugins.Popup.Extensions;
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
    public partial class RoomPage : ContentPage
    {
        DBFire db = new DBFire();

        IUserDialogs Dialogs = UserDialogs.Instance;

        public RoomPage()
        {
            InitializeComponent();
            var list =  db.getRoomList().Result;
            _lstx.BindingContext = list;

          
        }

        async void Handle_Refreshing(object sender, System.EventArgs e)
        {
            _lstx.BindingContext = await db.getRoomList();
            _lstx.IsRefreshing = false;
        }

        void Info_Clicked(object sender, System.EventArgs e)
        {
            Dialogs.Alert("Usuario Activo", User.UserName, "Okey");
        }

        public void Plus_Clicked(object sender, System.EventArgs e)
        {
           // AddRoomPage myHomePage = new AddRoomPage();
            //NavigationPage.SetHasNavigationBar(myHomePage, false);
             //Navigation.PushModalAsync(myHomePage);
            Navigation.PushAsync(new AddRoomPage());

        }
        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {


            if (_lstx.SelectedItem != null)
            {
                var selectRoom = (Room)_lstx.SelectedItem;

                Navigation.PushAsync(new ChatPage());
                //NAVİGATON !!! 
                MessagingCenter.Send<RoomPage, Room>(this, "RoomProp", selectRoom);




            }

        }
    
    }
}