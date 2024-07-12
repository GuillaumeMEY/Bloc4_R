using AnnuaireWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace AnnuaireWPF.Views.login
{
    /// <summary>
    /// Logique d'interaction pour ucLogin.xaml
    /// </summary>
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }
        private void Valider_Click(object sender, RoutedEventArgs e)
        {
            LoginViewModel.Instance.Login(pwd.Text);
        }
    }
}
