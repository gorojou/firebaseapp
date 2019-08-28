using Beux.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Beux.ViewModels
{
    class CrearPerfilViewModel : BindableObject
    {
        private CrearPerfilPage mainPage;

        public CrearPerfilViewModel(CrearPerfilPage mainPage)
        {
            this.mainPage = mainPage;
            AddItems();
        }
        private void AddItems()
        {
            for (int i = 0; i < 10; i++)
                Items.Add(string.Format("List Item at {0}", i));
        }

        private ObservableCollection<string> _items = new ObservableCollection<string>();
        public ObservableCollection<string> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged(nameof(Items));
                }
            }
        }

        public Command ItemTappedCommand
        {
            get
            {
                return new Command((data) =>
                {
                    mainPage.DisplayAlert("Foto", data + "", "Ok");
                });
            }
        }
    }
} 
    

