using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Annuaire.DAO;
using AnnuaireWPF.Models;
using AnnuaireWPF.ViewModels;
using Newtonsoft.Json;

namespace AnnuaireWPF.Services
{
    public static class HttpClientService
    {
        private const string baseAddress = "https://localhost:44312/";
        private static HttpClient? client = null;
        private static HttpClient Client
        {
            get
            {
                if (client == null)
                    client = new() { BaseAddress = new Uri(baseAddress) };
                return client;
            }
        }

        // Salariés
        // retounr info de tous les salaries
        public static async Task<ObservableCollection<Salarie>> GetAllSalaries()
        {
            string route = $"api/Salaries";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ObservableCollection<Salarie>>(result)
                ?? throw new Exception($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }

        // Recherche salarie via ID
        public static async Task<Salarie> GetSalarie(int salarieId)
        {
            string route = $"api/Salaries/{salarieId}";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string resultat = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Salarie>(resultat)
                    ?? throw new FormatException($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }
        // Creer Salarie
        public static async Task CreateSalarie(Salarie salarie)
        {
            string route = $"api/Salaries";
            string json = JsonConvert.SerializeObject(salarie);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PostAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
        // Update Salarie
        public static async Task UpdateSalarie(Salarie salarie)
        {
            string route = $"api/Salaries/{salarie.Id}";
            string json = JsonConvert.SerializeObject(salarie);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PutAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"{response.ReasonPhrase}");
            }
        }
        // Delete Salarie
        public static async Task DeleteSalarie(int id)
        {
            string route = $"api/Salaries/{id}";
            var response = await Client.DeleteAsync(route);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }


        // Sites
        // affiche info tous les sites
        public static async Task<ObservableCollection<Site>> GetAllSites()
        {
            string route = $"api/Sites";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ObservableCollection<Site>>(result)
                ?? throw new Exception($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }
        // Recherche site via ID
        public static async Task<Site> GetSite(int siteId)
        {
            string route = $"api/Sites/{siteId}";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string resultat = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Site>(resultat)
                    ?? throw new FormatException($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }
        // Creer site
        public static async Task CreateSite(Site site)
        {
            string route = $"api/Sites";
            string json = JsonConvert.SerializeObject(site);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PostAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
        // Update Site
        public static async Task UpdateSite(Site site)
        {
            string route = $"api/Sites/{site.Id}";

            string json = JsonConvert.SerializeObject(site);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PutAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"{response.ReasonPhrase}");
            }
        }
        // Delete Site
        public static async Task DeleteSite(int id)
        {
            string route = $"api/Sites/{id}";
            var response = await Client.DeleteAsync(route);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
        // Services
        // affiche info tous les services
        public static async Task<ObservableCollection<Service>> GetAllServices()
        {
            string route = $"api/Services";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ObservableCollection<Service>>(result)
                ?? throw new Exception($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }
        // Recherche Service via ID
        public static async Task<Service> GetService(int serviceId)
        {
            string route = $"api/Services/{serviceId}";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string resultat = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Service>(resultat)
                    ?? throw new FormatException($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }

        // Creer un service
        public static async Task CreateService(Service service)
        {
            string route = $"api/Services";
            string json = JsonConvert.SerializeObject(service);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PostAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
        // Update service
        public static async Task UpdateService(Service service)
        {
            string route = $"api/Services/{service.Id}";

            string json = JsonConvert.SerializeObject(service);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PutAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"{response.ReasonPhrase}");
            }
        }
        // Delete un service via ID
        public static async Task DeleteService(int id)
        {
            string route = $"api/Services/{id}";
            var response = await Client.DeleteAsync(route);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }


        // login
        public static async Task<bool> Login(string pwd)
        {
            string route = "login?useCookies=true&useSessionCookies=true";
            var jsonString = JsonConvert.SerializeObject(new LoginUser
            {
                Email = "admin@admin.fr",
                Password = pwd
            });

            var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(route, httpContent);
            return response.IsSuccessStatusCode;
        }

    }
}
