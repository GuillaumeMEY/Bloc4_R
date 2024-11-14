using Annuaire.DAO;
using AnnuaireWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logique d'interaction pour ucSalariesList.xaml
    /// </summary>
    public partial class ucSalariesList : UserControl
    {
        public ucSalariesList()
        {
            InitializeComponent();
            SalariesViewModel.Instance.GetAllSalaries();
        }
        private void SalarieDetails_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            MainViewModel.Instance.ChargerSalarie(((Salarie)btn.DataContext).Id);
        }
        private void SalarieCreate_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.CreateSalarie();
        }

        public void SearchList(string search, ObservableCollection<Salarie> list)
        {
            SalariesViewModel.Instance.ListeSalaries.Clear();
            var siteId = SalariesViewModel.Instance.SiteId;
            var serviceId = SalariesViewModel.Instance.ServiceId;

            if (siteId != 0 && serviceId != 0)
            {
                list = new ObservableCollection<Salarie>(list.Where(s => s.SiteId == siteId && s.ServiceId == serviceId));
            }
            else if (siteId != 0 && serviceId == 0)
            {
                list = new ObservableCollection<Salarie>(list.Where(s => s.SiteId == siteId));
            }
            else if (siteId == 0 && serviceId != 0)
            {
                list = new ObservableCollection<Salarie>(list.Where(s => s.ServiceId == serviceId));
            }
            else if (siteId == 0 && serviceId == 0)
            {
                list = new ObservableCollection<Salarie>(list);
            }

            list = new ObservableCollection<Salarie>(list.Where(s => s.Nom.ToLower().Contains(search.ToLower()) ||
                                                            s.Email.ToLower().Contains(search.ToLower()) ||
                                                            s.TelFix.ToLower().Contains(search.ToLower()) ||
                                                            s.TelPort.ToLower().Contains(search.ToLower()) ||
                                                            s.Prenom.ToLower().Contains(search.ToLower())));

            foreach (var s in list)
            {
                SalariesViewModel.Instance.ListeSalaries.Add(s);
            }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var txt = ((TextBox)sender).Text;
            var bsl = SalariesViewModel.Instance.BaseSalarieList;

            SearchList(txt, bsl);
        }

        private void SitesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Site site = (Site)((ComboBox)sender).SelectedItem;
            SalariesViewModel.Instance.SiteId = site.Id;

            SearchList(SearchBox.Text, SalariesViewModel.Instance.BaseSalarieList);
        }

        private void ServicesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Service service = (Service)((ComboBox)sender).SelectedItem;
            SalariesViewModel.Instance.ServiceId = service.Id;

            SearchList(SearchBox.Text, SalariesViewModel.Instance.BaseSalarieList);
        }
    }
}
