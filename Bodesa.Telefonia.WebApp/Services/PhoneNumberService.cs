using Bodesa.Telefonia.WebApp.Entities;
using Bodesa.Telefonia.WebApp.IServices;
using Newtonsoft.Json;
using System.Text;


namespace Bodesa.Telefonia.WebApp.Services
{
    public class PhoneNumberService : IPhoneNumberService
    {
        public async Task<string> AddPhoneNumber(cnf_PhoneNumber phoneNumber)
        {
            try
            {
                HttpClient client = new();
                var request = new HttpRequestMessage(HttpMethod.Post, GlobalPropertiesClass.PhoneNumberUri);
                var serializeObject = JsonConvert.SerializeObject(phoneNumber);
                var content = new StringContent(serializeObject, Encoding.UTF8, GlobalPropertiesClass.MediaType);
                var response = await client.PostAsync(GlobalPropertiesClass.PhoneNumberUri, content);
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

        public async Task<string> DeletePhoneNumber(string phoneNumberId)
        {
            try
            {
                HttpClient client = new();
                var request = new HttpRequestMessage(HttpMethod.Delete, $"{GlobalPropertiesClass.PhoneNumberUri}/{phoneNumberId}");
                var response = await client.DeleteAsync($"{GlobalPropertiesClass.PhoneNumberUri}/{phoneNumberId}");
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

        public async Task<IEnumerable<cnf_PhoneNumber>> GetAllPhoneNumbers()
        {
            HttpClient client = new();
            var response = await client.GetAsync(GlobalPropertiesClass.PhoneNumberUri);
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<IEnumerable<Entities.cnf_PhoneNumber>>(await response.Content.ReadAsStringAsync());
                return result;
            }

            return null;

        }

        public async Task<cnf_PhoneNumber> GetPhoneNumber(string phoneNumberId)
        {
            try
            {
                HttpClient client = new();
                var response = await client.GetAsync($"{GlobalPropertiesClass.PhoneNumberUri}/{phoneNumberId}");
                if (response.IsSuccessStatusCode)
                {
                    var result = JsonConvert.DeserializeObject<Entities.cnf_PhoneNumber>(await response.Content.ReadAsStringAsync());
                    return result;
                }

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<string> UpdatePhoneNumber(cnf_PhoneNumber phoneNumber)
        {
            try
            {
                HttpClient client = new();
                var request = new HttpRequestMessage(HttpMethod.Put, GlobalPropertiesClass.PhoneNumberUri);
                var serializeObject = JsonConvert.SerializeObject(phoneNumber);
                var content = new StringContent(serializeObject, Encoding.UTF8, GlobalPropertiesClass.MediaType);
                var response = await client.PutAsync(GlobalPropertiesClass.PhoneNumberUri, content);
                if (response.IsSuccessStatusCode)
                {
                    return string.Empty;
                }

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return ex.Message + Environment.NewLine + ex.StackTrace;
            }
        }
    }
}
