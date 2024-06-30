using AnnuaireWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnnuaireWPF.shared
{
    /// <summary>
    /// Logique d'interaction pour NavBar.xaml
    /// </summary>
    public partial class NavBar : UserControl
    {
        public NavBar()
        {
            InitializeComponent();
        }
        private void MenuSalaries_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerSalaries();
        }

        private void MenuSites_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerSites();
        }
        private void MenuServices_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerServices();
        }
    }
}
