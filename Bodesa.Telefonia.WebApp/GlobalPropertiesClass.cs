namespace Bodesa.Telefonia.WebApp
{
    public class GlobalPropertiesClass
    {
        public event EventHandler ChangedEvent;

        public string LoginLogout { get; set; } = "Login";

        public string ShowButtonLogin { get; set; } = "block";
        public string ShowButtonLogout { get; set; } = "none";

        public static string CustomerUri = "https://localhost:44312/Customers/Telephony";
        public static string PhoneNumberUri = "https://localhost:44312/api/Phone";
        public static readonly string MediaType = "application/json";

        //public void setLoginLogut(string loginLogout)
        //{
        //    LoginLogout = loginLogout;
        //    ChangedEvent?.Invoke(this, EventArgs.Empty);
        //}
        //public string getLoginLogout()
        //{
        //    return LoginLogout;
        //}
    }
}
