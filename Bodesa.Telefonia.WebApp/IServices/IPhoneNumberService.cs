using Bodesa.Telefonia.WebApp.Entities;

namespace Bodesa.Telefonia.WebApp.IServices
{
    public interface IPhoneNumberService
    {
        public Task<cnf_PhoneNumber> GetPhoneNumber(string phoneNumberId);
        public Task<IEnumerable<cnf_PhoneNumber>> GetAllPhoneNumbers();
        public Task<string> AddPhoneNumber(cnf_PhoneNumber phoneNumber);
        public Task<string> DeletePhoneNumber(string phoneNumberId);             
        public Task<string> UpdatePhoneNumber(cnf_PhoneNumber phoneNumber);
    }
}
