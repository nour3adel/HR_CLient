using Newtonsoft.Json;
using System.Text;

namespace Magazine.Logic
{
    public class ApiService
    {
        private readonly string _baseUrl;

        public ApiService(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public async Task<ApiResponse<TokenResponse>> LoginAsync(string username, string password)
        {
            using (var client = new HttpClient())
            {
                var loginUrl = $"{_baseUrl}/Account/Login";
                var requestBody = new
                {
                    username = username,
                    password = password
                };

                var jsonBody = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(loginUrl, content);
                var responseString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<ApiResponse<TokenResponse>>(responseString);
            }
        }
        public async Task<ApiResponse<string>> RegisterAsync(string fullname, string username, string password, string email, string address, string phoneNumber)
        {
            using (var client = new HttpClient())
            {
                var registerUrl = $"{_baseUrl}/Customer/Register";
                var requestBody = new
                {
                    fullname = fullname,
                    username = username,
                    password = password,
                    email = email,
                    address = address,
                    phonenumber = phoneNumber
                };

                var jsonBody = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(registerUrl, content);
                var responseString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<ApiResponse<string>>(responseString);
            }
        }

    }

}
