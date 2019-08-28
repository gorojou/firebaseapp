﻿using Acr.UserDialogs;
using Beux.Services;
using Beux.Services.FirebaseAuth;
using Beux.ViewModels.Base;
using Beux.ViewModels.Main;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Beux.ViewModels.Login
{
    public class SignUpViewModel : ViewModelBase
    {
        private ICommand _loginCommand;
        private ICommand _signupCommand;
        private String _username;
        private String _password;
        private IUserDialogs _userDialogService;

        private IFirebaseAuthService _firebaseService;

        public SignUpViewModel(IUserDialogs userDialogsService)
        {
            _userDialogService = userDialogsService;
            _firebaseService = DependencyService.Get<IFirebaseAuthService>();

        }

        public ICommand LoginCommand
        {
            get { return _loginCommand = _loginCommand ?? new DelegateCommandAsync(LoginCommandExecute); }
        }
        public ICommand SignUpCommand
        {
            get { return _signupCommand = _signupCommand ?? new DelegateCommandAsync(SignUpCommandExecute); }
        }
        private async Task LoginCommandExecute()
        {
            await NavigationService.NavigateToAsync<LoginViewModel>();
        }
        private async Task SignUpCommandExecute()
        {
            if (await _firebaseService.SignUp(Username, Password))
            {
                await NavigationService.NavigateToAsync<MainViewModel>();
            }
            else
            {
                _userDialogService.Toast("El Usuario introducido no es válido");
            }

        }
        public String Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                RaisePropertyChanged();
            }
        }

        public String Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                RaisePropertyChanged();
            }
        }
    }
}
