using System;
using System.Threading.Tasks;
using Beux.Droid.Services;
using Beux.Services;
using Xamarin.Forms;
using Firebase.Auth;
using Android.App;
using Android.Content;
using Beux.Droid.Activities;
using Beux.Droid.Services.FirebaseDB;
using Beux.Services.FirebaseDB;
using Firebase.Database;


[assembly: Dependency(typeof(FirebaseDBService))]
namespace Beux.Droid.Services.FirebaseDB
{
    public class ValueEventListener : Java.Lang.Object, IValueEventListener
    {
        public void OnCancelled(DatabaseError error) { }

        public void OnDataChange(DataSnapshot snapshot)
        {
            //String message = snapshot.Value.ToString();
            //MessagingCenter.Send(FirebaseDBService.KEY_MESSAGE, FirebaseDBService.KEY_MESSAGE, message);


        }
    }

    public class FirebaseDBService : IFirebaseDBService
    {
        DatabaseReference databaseReference;
        FirebaseDatabase database;
        FirebaseAuthService authService = new FirebaseAuthService();
        public static String KEY_MESSAGE = "message";

        public void Connect()
        {
            database = FirebaseDatabase.GetInstance(MainActivity.app);
        }

        public void GetMessage()
        {
            var userId = authService.GetUserId();
            databaseReference = database.GetReference("messages/" + userId);
            databaseReference.AddValueEventListener(new ValueEventListener());

        }

        public string GetMessageKey()
        {
            return KEY_MESSAGE;
        }

        public void SetMessage(string message)
        {
            var userId = authService.GetUserId();
            databaseReference = database.GetReference("messages/" + userId);
            databaseReference.SetValue(message);
        }
    }
}