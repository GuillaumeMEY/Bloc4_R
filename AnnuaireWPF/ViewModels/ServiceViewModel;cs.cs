using Annuaire.DAO;
using AnnuaireWPF.Services;
using System.Collections.ObjectModel;

namespace AnnuaireWPF.ViewModels
{
    public class ServicesViewModel : BaseViewModel
    {
        #region Singleton
        private static ServicesViewModel instance = new ServicesViewModel();

        public static ServicesViewModel Instance { get => instance; }

        #endregion

        public Service Service { get; set; }

        public int ServiceId { get; set; }

        public ObservableCollection<Service> ListeServices { get; set; }



        public ServicesViewModel()
        {
            GetAllServices();
        }

        // appel fonction pour afficher liste des services
        public async void GetAllServices()
        {
            ListeServices = await HttpClientService.GetAllServices();
            OnPropertyChanged(nameof(ListeServices));
        }
        // appel fonction pour afficher un service
        public async void GetService(int serviceId)
        {
            Service = await HttpClientService.GetService(serviceId);
            ServiceId = serviceId;
            OnPropertyChanged(nameof(Service));
        }
        // appel fonction pour creer un service
        public async void CreateService(Service service)
        {
            await HttpClientService.CreateService(service);
            MainViewModel.Instance.ChargerServices();
        }
        // Appel fonction Update le service
        public async void UpdateService(Service service)
        {
            await HttpClientService.UpdateService(service);
            MainViewModel.Instance.ChargerServices();
        }
        // Appel fonction Supprime le service
        public async void DeleteService(int id)
        {
            await HttpClientService.DeleteService(id);
            MainViewModel.Instance.ChargerServices();
        }
    }
}
