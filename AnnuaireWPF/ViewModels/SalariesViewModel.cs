﻿using Annuaire.DAO;
using AnnuaireWPF.Services;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Headers;

namespace AnnuaireWPF.ViewModels
{
    public class SalariesViewModel : BaseViewModel
    {

        private static SalariesViewModel instance = new SalariesViewModel();

        public static SalariesViewModel Instance { get => instance; }


        public Salarie Salarie { get; set; }

        public int SalarieId { get; set; } = 0;

        public ObservableCollection<Salarie> ListeSalaries { get; set; }

        public ObservableCollection<Salarie> BaseSalarieList { get; set; }

        public ObservableCollection<Site> ListeSites { get; set; }

        public ObservableCollection<Service> ListeServices { get; set; }

        public int SiteId { get; set; } = 0;

        public int ServiceId { get; set; } = 0;


        public SalariesViewModel()
        {
            GetAllSalaries();
            GetAllSitesAndServices();
        }


        // appel fonction pour afficher liste des salaries
        public async void GetAllSalaries()
        {
            ListeSalaries = await HttpClientService.GetAllSalaries();
            BaseSalarieList = await HttpClientService.GetAllSalaries();
            OnPropertyChanged(nameof(ListeSalaries));
            OnPropertyChanged(nameof(BaseSalarieList));
        }

        // appel fonction pour afficher detail d'un salarie
        public async void GetSalarie(int salarieId)
        {
            Salarie = await HttpClientService.GetSalarie(salarieId);
            SalarieId = salarieId;
            OnPropertyChanged(nameof(Salarie));
        }
        // appel fonction pour creer salarie
        public async void CreateSalarie(Salarie salarie)
        {
            await HttpClientService.CreateSalarie(salarie);
            MainViewModel.Instance.ChargerSalaries();
        }
        // appel fonction pour update salarie
        public async void UpdateSalarie(Salarie salarie)
        {
            await HttpClientService.UpdateSalarie(salarie);
            MainViewModel.Instance.ChargerSalaries();
        }
        // appel fonction pour delete salarie
        public async void DeleteSalarie(int id)
        {
            await HttpClientService.DeleteSalarie(id);
            MainViewModel.Instance.ChargerSalaries();
        }

        // Voir la liste deroulante
        public async void GetAllSitesAndServices()
        {
            ListeSites = await HttpClientService.GetAllSites();
            ListeServices = await HttpClientService.GetAllServices();
            ListeServices.Add(new Service() { Id = 0, NomService = "" });
            ListeSites.Add(new Site() { Id = 0, Ville = "" });
            OnPropertyChanged(nameof(ListeServices));
            OnPropertyChanged(nameof(ListeSites));
        }
    }
}
