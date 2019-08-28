using System;
using System.Collections.Generic;
using System.Text;

namespace Beux.Models
{
    public class User
    {
        private static string uid;

        public static string UserName
        {
            get
            {
                return uid;
            }
            set
            {
                uid = value;
            }
        }


        private User() { }

    }
}
