using AnnuaireWPF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AnnuaireWPF.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Singleton
        private static LoginViewModel instance = new LoginViewModel();

        public static LoginViewModel Instance { get => instance; }

        #endregion

        public bool IsLoggedIn { get; set; }

        public LoginViewModel()
        {

        }
        // Log si return fonction login = true
        public async void Login(string pwd)
        {
            IsLoggedIn = await HttpClientService.Login(pwd);
            if (IsLoggedIn)
            {
                MainViewModel.Instance.ChargerSalaries();
                Globals.IsLoggedIn = true;
            }
            else
            {
                MessageBox.Show("Mot de passe incorrect, veuillez réessayez.");
            }
        }
    }
}
