using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;

namespace ListExercise.Core.Oige
{
    public class DataService
    {
        //public static async Task<dynamic> GetDataFromService(string queryString)
        //{
        //    HttpClient client = new HttpClient();
        //    var response = await client.GetStringAsync(queryString);

        //    dynamic data = null;
        //    if (response != null)
        //    {
        //        data = JsonConvert.DeserializeObject<People>(response);
        //    }
        //    return data;
        //}

        public static async Task<People> GetStarWarsPeople(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(queryString);

            People data = null;
            if (response != null)
            {
                data = JsonConvert.DeserializeObject<People>(response);
            }
            return data;
        }
    }
}

