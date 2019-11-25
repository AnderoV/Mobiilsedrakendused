using Newtonsoft.Json;
using StarWarsApp.Core.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace StarWarsApp.Core
{
    public class DataService
    {
        public static async Task<People> GetStarWarsPeople(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(queryString);

            People Peopledata = null;
            if (response != null)
            {
                Peopledata = JsonConvert.DeserializeObject<People>(response);
            }
            return Peopledata;
        }

        public static async Task<Starships> GetStarWarsStarships(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(queryString);

            Starships Starshipsdata = null;
            if (response != null)
            {
                Starshipsdata = JsonConvert.DeserializeObject<Starships>(response);
            }
            return Starshipsdata;
        }

        public static async Task<Planets> GetStarWarsPlanets(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(queryString);

            Planets Planetsdata = null;
            if (response != null)
            {
                Planetsdata = JsonConvert.DeserializeObject<Planets>(response);
            }
            return Planetsdata;
        }

        public static async Task<Films> GetStarWarsFilms(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(queryString);

            Films FilmsData = null;
            if (response != null)
            {
                FilmsData = JsonConvert.DeserializeObject<Films>(response);
            }
            return FilmsData;
        }
    }
}
