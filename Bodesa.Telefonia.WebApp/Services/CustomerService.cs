using Bodesa.Telefonia.WebApp.Entities;
using Newtonsoft.Json;
using System.Text;
using Bodesa.Telefonia.WebApp.Extentions;

namespace Bodesa.Telefonia.WebApp.Services
{
    public class CustomerService : IServices.ICustomerService
    {
        public static string uri = "https://localhost:44312/Customers/Telephony";
        private const string MediaType = "application/json";

        public async Task<IEnumerable<cnf_CustomerData>> GetAllCustomersAsync()
        {
            HttpClient client = new();
            var response = await client.GetAsync(uri);
            if (response != null && response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<IEnumerable<cnf_CustomerData>>(await response.Content.ReadAsStringAsync());

                return result;
            }

            return null;
        }

        public async Task<Entities.cnf_CustomerData> GetCustomerByPhoneNumber(string phoneNumber)
        {
            HttpClient client = new();
            var response = await client.GetAsync($"{uri}/ByPhoneNumber/{phoneNumber}");
            if (response != null && response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<cnf_CustomerData>(await response.Content.ReadAsStringAsync());
                return result;
            }

            return null;
        }


        public async Task<string> SaveCustomer(cnf_CustomerData customer)
        {
            try
            {
                HttpClient client = new();
                var request = new HttpRequestMessage(HttpMethod.Put, uri);
                var serializeObject = JsonConvert.SerializeObject(customer);
                var content = new StringContent(serializeObject, Encoding.UTF8, MediaType);
                var response = await client.PutAsync(uri, content);
                if (response.IsSuccessStatusCode)
                {
                    return string.Empty;
                }

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> AddCustomer(cnf_CustomerData customer)
        {
            try
            {
                HttpClient client = new();
                var request = new HttpRequestMessage(HttpMethod.Post, uri);
                var serializeObject = JsonConvert.SerializeObject(customer);
                var content = new StringContent(serializeObject, Encoding.UTF8, MediaType);
                var response = await client.PostAsync(uri, content);
                if (response.IsSuccessStatusCode)
                {
                    return string.Empty;
                }

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> DeleteCustomer(string id)
        {
            try
            {
                HttpClient client = new();
                var request = new HttpRequestMessage(HttpMethod.Delete, $"{uri}/{id}");
                // var serializeObject = JsonConvert.SerializeObject(customer);
                //var content = new StringContent(serializeObject, Encoding.UTF8, MediaType);
                var response = await client.DeleteAsync($"{uri}/{id}");
                if (response.IsSuccessStatusCode)
                {
                    return string.Empty;
                }

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
