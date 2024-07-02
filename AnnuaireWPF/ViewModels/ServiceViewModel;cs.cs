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

        public async void GetAllServices()
        {
            ListeServices = await HttpClientService.GetAllServices();
            OnPropertyChanged(nameof(ListeServices));
        }

        public async void GetService(int serviceId)
        {
            Service = await HttpClientService.GetService(serviceId);
            ServiceId = serviceId;
            OnPropertyChanged(nameof(Service));
        }
        public async void CreateService(Service service)
        {
            await HttpClientService.CreateService(service);
        }
        // Appel fonction Update le service
        public async void UpdateService(Service service)
        {
            await HttpClientService.UpdateService(service);
        }
    }
}
