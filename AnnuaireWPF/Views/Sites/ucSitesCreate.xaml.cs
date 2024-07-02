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
    /// Logique d'interaction pour ucSitesCreate.xaml
    /// </summary>
    public partial class ucSitesCreate : UserControl
    {
        public ucSitesCreate()
        {
            InitializeComponent();
        }
        private void CreateSite_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var site = ((SitesViewModel)btn.DataContext).Site;
            SitesViewModel.Instance.CreateSite(site);
            MainViewModel.Instance.ChargerSites();
        }
        private void Retour_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerSites();
        }
    }
}
