using Beux.Services;
using Beux.Services.FirebaseAuth;
using Beux.Services.FirebaseDB;
using Beux.Services.Navigation;
using Beux.ViewModels.Base;
using Beux.ViewModels.Login;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Beux.ViewModels.Main
{
    public class MainViewModel : ViewModelBase
    {
        private ICommand _logoutCommand;
        private ICommand _saveTextCommand;
        private IFirebaseAuthService _firebaseAuthService;
        private IFirebaseDBService _firebaseDatabaseService;
        private String _message;
        public MainViewModel()
        {
            _firebaseAuthService = DependencyService.Get<IFirebaseAuthService>();
            _firebaseDatabaseService = DependencyService.Get<IFirebaseDBService>();
            _firebaseDatabaseService.Connect();
            _firebaseDatabaseService.GetMessage();
            MessagingCenter.Subscribe<String, String>(this, _firebaseDatabaseService.GetMessageKey(), (sender, args) =>
            {
                Message = (args);

            });
        }

        public ICommand LogoutCommand
        {
            get { return _logoutCommand = _logoutCommand ?? new DelegateCommandAsync(LogoutCommandExecute); }
        }

        private async Task LogoutCommandExecute()
        {
            if (await _firebaseAuthService.Logout())
            {
                await NavigationService.NavigateToAsync<LoginViewModel>();
            }


        }

        public ICommand SaveTextCommand
        {
            get { return _saveTextCommand = _saveTextCommand ?? new DelegateCommandAsync(SaveTextCommandExecute); }
        }
        private async Task SaveTextCommandExecute()
        {
            _firebaseDatabaseService.SetMessage(Message);

        }

        public String Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                RaisePropertyChanged();
            }
        }
    }
}
