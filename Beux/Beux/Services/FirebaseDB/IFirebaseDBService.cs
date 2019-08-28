using System;
using System.Collections.Generic;
using System.Text;

namespace Beux.Services.FirebaseDB
{
    public interface IFirebaseDBService
    {
        void Connect();
        void GetMessage();
        void SetMessage(String message);
        String GetMessageKey();
    }
}
