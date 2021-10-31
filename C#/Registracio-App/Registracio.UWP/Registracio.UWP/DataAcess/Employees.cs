using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Registracio.UWP.DataAcess
{
    public class Employees
    {
        readonly HttpClient _httpClient = new HttpClient();
        static readonly Uri coursesBaseUri = new Uri("http://localhost:37089/api/courses");

        public async Task<Employees[]> GetEmployeesAsync()
        {
            HttpResponseMessage result = await _httpClient.GetAsync(coursesBaseUri);
            string json = await result.Content.ReadAsStringAsync();
            Employees[] employees = JsonConvert.DeserializeObject<Employees[]>(json);

            return employees;
        }
    }
}
