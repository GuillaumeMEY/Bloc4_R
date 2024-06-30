﻿using System.Collections.ObjectModel;
using System.Net.Http;
using Annuaire.DAO;
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


        // Sites
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

        // Services
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

    }
}
