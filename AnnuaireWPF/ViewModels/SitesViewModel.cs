using Annuaire.DAO;
using AnnuaireWPF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnuaireWPF.ViewModels
{
    public class SitesViewModel : BaseViewModel
    {
        // Singleton
        private static SitesViewModel instance = new SitesViewModel();

        public static SitesViewModel Instance { get => instance; }



        public Site Site { get; set; }

        public int SiteId { get; set; }

        public ObservableCollection<Site> ListeSites { get; set; }



        public SitesViewModel()
        {
            GetAllSites();
        }

        // Appel fonction Voir tous les sites
        public async void GetAllSites()
        {
            ListeSites = await HttpClientService.GetAllSites();
            OnPropertyChanged(nameof(ListeSites));
            MainViewModel.Instance.ChargerSites();
        }
        // appel fonction pour afficher un site
        public async void GetSite(int siteId)
        {
            Site = await HttpClientService.GetSite(siteId);
            SiteId = siteId;
            OnPropertyChanged(nameof(Site));
        }
        // appel fonction pour creer un site
        public async void CreateSite(Site site)
        {
            await HttpClientService.CreateSite(site);
            MainViewModel.Instance.ChargerSites();
        }

        // Appel fonction Update site
        public async void UpdateSite(Site site)
        {
            await HttpClientService.UpdateSite(site);
            MainViewModel.Instance.ChargerSites();
        }
        
        // Appel fonction Delete site
        public async void DeleteSite(int id)
        {
            await HttpClientService.DeleteSite(id);
            MainViewModel.Instance.ChargerSites();
        }
    }
}
