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

namespace AnnuaireWPF.Views.Sites
{
    /// <summary>
    /// Logique d'interaction pour ucSitesDetails.xaml
    /// </summary>
    public partial class ucSitesDetails : UserControl
    {
        public ucSitesDetails()
        {
            InitializeComponent();
        }
        private void Retour_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerSites();
        }
        private void UpdateSite_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var site = ((SitesViewModel)btn.DataContext).Site;
            SitesViewModel.Instance.UpdateSite(site);
            MainViewModel.Instance.ChargerSites();
        }
    }
}
