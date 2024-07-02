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
        }
        public async void GetSite(int siteId)
        {
            Site = await HttpClientService.GetSite(siteId);
            SiteId = siteId;
            OnPropertyChanged(nameof(Site));
        }
        public async void CreateSite(Site site)
        {
            await HttpClientService.CreateSite(site);
        }
    }
}
