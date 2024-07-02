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

namespace AnnuaireWPF.Views.Services
{
    /// <summary>
    /// Logique d'interaction pour ucServicesDetails.xaml
    /// </summary>
    public partial class ucServicesDetails : UserControl
    {
        public ucServicesDetails()
        {
            InitializeComponent();
        }
        // retour ServicesList
        private void Retour_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerServices();
        }
        private void UpdateService_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var service = ((ServicesViewModel)btn.DataContext).Service;
            ServicesViewModel.Instance.UpdateService(service);
            MainViewModel.Instance.ChargerServices();
        }
        private void DeleteService_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var serviceId = ((ServicesViewModel)btn.DataContext).Service.Id;
            ServicesViewModel.Instance.DeleteService(serviceId);
            MainViewModel.Instance.ChargerServices();
        }
    }
}
