using Annuaire.DAO;
using AnnuaireWPF.Views.login;
using AnnuaireWPF.Views.Salaries;
using AnnuaireWPF.Views.Services;
using AnnuaireWPF.Views.Sites;
using System.Windows.Controls;
namespace AnnuaireWPF.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        private static MainViewModel instance = new MainViewModel();

        public static MainViewModel Instance { get => instance; }

        private UserControl userControl;

        private MainViewModel() { }


        public UserControl UserControl
        {
            get { return userControl; }
            set { userControl = value; OnPropertyChanged(); }
        }

        // Salaries
        public void ChargerSalaries()
        {
            var uc = new ucSalariesList();
            uc.DataContext = SalariesViewModel.Instance;
            UserControl = uc;
        }

        public void ChargerSalarie(int id)
        {
            var uc = new ucSalariesDetails();
            uc.DataContext = SalariesViewModel.Instance;
            ((SalariesViewModel)uc.DataContext).GetSalarie(id);
            UserControl = uc;
        }

        public void CreateSalarie()
        {
            var uc = new ucSalariesCreate();
            uc.DataContext = SalariesViewModel.Instance;
            ((SalariesViewModel)uc.DataContext).Salarie = new Salarie();
            UserControl = uc;
        }

        // Sites
        public void ChargerSites()
        {
            var uc = new ucSitesList();
            uc.DataContext = SitesViewModel.Instance;
            UserControl = uc;
        }
        public void ChargerSite(int id)
        {
            var uc = new ucSitesDetails();
            uc.DataContext = SitesViewModel.Instance;
            ((SitesViewModel)uc.DataContext).GetSite(id);
            UserControl = uc;
        }
        public void CreateSite()
        {
            var uc = new ucSitesCreate();
            uc.DataContext = SitesViewModel.Instance;
            ((SitesViewModel)uc.DataContext).Site = new Site();
            UserControl = uc;
        }

        // Services
        public void ChargerServices()
        {
            var uc = new ucServicesList();
            uc.DataContext = ServicesViewModel.Instance;
            UserControl = uc;
        }
        public void ChargerService(int id)
        {
            var uc = new ucServicesDetails();
            uc.DataContext = ServicesViewModel.Instance;
            ((ServicesViewModel)uc.DataContext).GetService(id);
            UserControl = uc;
        }
        public void CreateService()
        {
            var uc = new ucServicesCreate();
            uc.DataContext = ServicesViewModel.Instance;
            ((ServicesViewModel)uc.DataContext).Service = new Service();
            UserControl = uc;
        }
        // Login ( redirige vers la vue )
        public void ChargerLogin()
        {
            var uc = new ucLogin();
            uc.DataContext = LoginViewModel.Instance;
            UserControl = uc;
        }

    }
}
