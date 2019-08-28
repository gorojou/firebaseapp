﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Beux.Helper
{
    class DoubleResources
    {
        public static readonly Thickness ButtonGroupPadding = new Thickness(0, Device.OnPlatform(25, 0, 0), 0, 0);
        public static readonly double SignUpButtonHeight = Device.OnPlatform(40, 40, 80);
        public static readonly double FBButtonHeight = Device.OnPlatform(50, 50, 64);
    }
}
