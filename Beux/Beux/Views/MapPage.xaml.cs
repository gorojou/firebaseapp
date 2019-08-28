using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Beux.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentView
    {
        public MapPage()
        {

            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            var location = locator.GetPositionAsync(TimeSpan.FromTicks(10000));
            Plugin.Geolocator.Abstractions.Position location1 = locator.GetPositionAsync(TimeSpan.FromTicks(10000)).Result;

            Position position = new Position(location1.Latitude, location1.Longitude);
            Map mymap = new Map();
            mymap.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromMiles(3))); 
            
           
            Content = new StackLayout
            {
                Padding = new Thickness(5, 20, 5, 0),
                HorizontalOptions = LayoutOptions.Fill,
                Children = {
                    
                   mymap
                    
                }
            };
        }
    }
}