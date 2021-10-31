using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Registracio.Model;

namespace Registracio.UWP.DataAccess
{
    public class EmpDataAccess
    {
        readonly HttpClient _httpClient = new HttpClient();
        static readonly Uri employeesBaseUri = new Uri("http://localhost:37089/api/employees");
        static readonly Uri itemsBaseUri = new Uri("http://localhost:37089/api/items");

        public async Task<Employees[]> GetEmployeesAsync()
        {
            HttpResponseMessage result = await _httpClient.GetAsync(employeesBaseUri);
            string json = await result.Content.ReadAsStringAsync();
            Employees[] employees = JsonConvert.DeserializeObject<Employees[]>(json);

            return employees;
        }

       public async Task<Items[]> GetItemsAsync()
       {
            HttpResponseMessage result = await _httpClient.GetAsync(itemsBaseUri);
            string json = await result.Content.ReadAsStringAsync();
            Items[] items = JsonConvert.DeserializeObject<Items[]>(json);

            return items;
        }


        internal async Task<bool> DeleteEmployee(Employees employees)
        {
            HttpResponseMessage result = await _httpClient.DeleteAsync(new Uri(employeesBaseUri, "employees/" + employees.EmpName.ToString()));
            return result.IsSuccessStatusCode;
        }
      internal async Task<bool> DeleteItems(Items items)
        {
            HttpResponseMessage result = await _httpClient.DeleteAsync(new Uri(itemsBaseUri, "items/" + items.ItemName.ToString()));
            return result.IsSuccessStatusCode;
        }

        internal async Task<bool> UpdateEmployee(Employees employees)
        {
           string requestUri = "http://localhost:37089/api/employees/" + employees.EmpID;
           string json = JsonConvert.SerializeObject(employees);
           HttpResponseMessage result = await _httpClient.PutAsync(requestUri, new StringContent(json, Encoding.UTF8, "application/json"));
           return result.IsSuccessStatusCode;
        }

        internal async Task<bool> UpdateItemAsync(Items items)
        {
            string requestUri = "http://localhost:37089/api/items" + items.ItemID;
            string json = JsonConvert.SerializeObject(items);
            HttpResponseMessage result = await _httpClient.PutAsync(requestUri, new StringContent(json, Encoding.UTF8, "application/json"));
            return result.IsSuccessStatusCode;
        }
    }
}

