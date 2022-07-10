using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BookLibraryApi.Drivers
{
    public class HttpClientHelper
    {
        readonly HttpClient _client = new HttpClient();

        public async Task<ApiResponse> GetApiResponseAsync(string endpoint, string? authToken = null)
        {
            var apiResponse = new ApiResponse();
            _client.BaseAddress = new Uri(endpoint);

            try
            {
                if (authToken != null)
                {
                    _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
                }

                var response = await _client.GetAsync(_client.BaseAddress);
                apiResponse = await GetAllDataAsync(response);
            }
            catch (HttpRequestException e)
            {

                Console.WriteLine("An error has occurred", e.Message);
            }

            return apiResponse;
        }

        public async Task<ApiResponse> PostApiResponseAsync(string endpoint, string postDataJson, string? authToken = null)
        {
            var apiResponse = new ApiResponse();
            _client.BaseAddress = new Uri(endpoint);
            var content = new StringContent(postDataJson, System.Text.Encoding.UTF8, "application/json");

            try
            {
                if (authToken != null)
                {
                    _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
                }    

                var response = await _client.PostAsync(_client.BaseAddress, content);
                apiResponse = await GetAllDataAsync(response);
            }
            catch (HttpRequestException e)
            {

                Console.WriteLine("An error has occurred", e.Message);
            }

            return apiResponse;
        }

        public async Task<ApiResponse> DeleteApiReseponseAsync(string endpoint, string? authToken = null)
        {
            var apiReponse = new ApiResponse();

            try
            {
                if (authToken != null)
                {
                    _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
                }

                var reponse = await _client.DeleteAsync(endpoint);
                apiReponse = await GetAllDataAsync(reponse);
            }
            catch (HttpRequestException e)
            {

                Console.WriteLine("An error has occurred", e.Message);
            }

            return apiReponse;
        }

        public async Task<ApiResponse> PutApiResponseAsync(string endpoint, string postDataJson, string? authToken = null)
        {
            var apiResponse = new ApiResponse();
            _client.BaseAddress = new Uri(endpoint);
            var content = new StringContent(postDataJson, System.Text.Encoding.UTF8, "application/json");

            try
            {
                if (authToken != null)
                {
                    _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
                }

                var response = await _client.PutAsync(_client.BaseAddress, content);
                apiResponse = await GetAllDataAsync(response);
            }
            catch (HttpRequestException e)
            {

                Console.WriteLine("An error has occurred", e.Message);
            }

            return apiResponse;
        }

        private async Task<ApiResponse> GetAllDataAsync(HttpResponseMessage responseTask)
        {
            var response = new ApiResponse
            {
                JsonResponse = await responseTask.Content.ReadAsStringAsync(),
                StatusCode = (int)responseTask.StatusCode,
                StatusMessage = Convert.ToString(responseTask.StatusCode)
            };

            return response;
        }
    }
}