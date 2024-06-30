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

namespace AnnuaireWPF.Views.Services
{
    /// <summary>
    /// Logique d'interaction pour ucServicesList.xaml
    /// </summary>
    public partial class ucServicesList : UserControl
    {
        public ucServicesList()
        {
            InitializeComponent();
        }
        private void ServiceDetails_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            MainViewModel.Instance.ChargerService(((Service)btn.DataContext).Id);
        }
    }
}
