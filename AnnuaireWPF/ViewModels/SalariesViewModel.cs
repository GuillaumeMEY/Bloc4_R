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



        public SalariesViewModel()
        {
            GetAllSalaries();
        }

        // Appel fonction Voir tous les salarie
        public async void GetAllSalaries()
        {
            ListeSalaries = await HttpClientService.GetAllSalaries();
            BaseSalarieList = await HttpClientService.GetAllSalaries();
            OnPropertyChanged(nameof(ListeSalaries));
            OnPropertyChanged(nameof(BaseSalarieList));
        }

        // Appel fonction Voir salarie via ID
        public async void GetSalarie(int salarieId)
        {
            Salarie = await HttpClientService.GetSalarie(salarieId);
            SalarieId = salarieId;
            OnPropertyChanged(nameof(Salarie));
        }
    }
}
