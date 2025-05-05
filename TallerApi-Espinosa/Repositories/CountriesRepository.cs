using Newtonsoft.Json;

namespace TallerApi_Espinosa.Repositories
{
    public class CountriesRepository
    {
        private HttpClient _httpClient;
        public CountriesRepository()
        {
            _httpClient = new HttpClient();
        }
        public async Task <IEnumerable<Country>>GetCountryList()
        {
            string url = "https://restcountries.com/v3.1/all";
            var response = await _httpClient.GetStringAsync(url);
            List<Country> countryList = JsonConvert.DeserializeObject<List<Country>>(response);
            return countryList;
        }
    }
}
