using Annuaire.DAO;
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

namespace AnnuaireWPF.Views.Salaries
{
    /// <summary>
    /// Logique d'interaction pour ucSalariesDetails.xaml
    /// </summary>
    public partial class ucSalariesDetails : UserControl
    {
        public ucSalariesDetails()
        {
            InitializeComponent();
        }
        // select service
        private void comboBoxServicesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Service service = (Service)((ComboBox)sender).SelectedItem;
            SalariesViewModel.Instance.Salarie.ServiceId = service.Id;
        }
        // select site
        private void comboBoxSitesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Site site = (Site)((ComboBox)sender).SelectedItem;
            SalariesViewModel.Instance.Salarie.SiteId = site.Id;
        }
        // retour ucSalariesList
        private void Retour_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerSalaries();
        }
        private void UpdateSalarie_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var salarie = ((SalariesViewModel)btn.DataContext).Salarie;
            SalariesViewModel.Instance.UpdateSalarie(salarie);
            MainViewModel.Instance.ChargerSalaries();
        }
    }
}
