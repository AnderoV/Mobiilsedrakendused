using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise.Core
{
    public class DataService
    {
        public static async Task<dynamic> GetDataFromService(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(queryString);

            dynamic data = null;
            if(response != null)
            {

            }
            return data;
        }
    }
}
