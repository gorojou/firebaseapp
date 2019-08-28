using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Beux.Helper
{
    public class BoolResources
    {
        public static readonly bool ShouldShowBoxView = Device.OnPlatform(true, false, true);
    }
}
