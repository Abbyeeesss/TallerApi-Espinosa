using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TallerApi_Espinosa.Repositories;

namespace TallerApi_Espinosa.Controllers
{
    public class CountryController : Controller
    {
        private CountriesRepository _repo;
        public CountryController()
        {
            _repo = new CountriesRepository();
        }
        public async Task<IActionResult> CountryList()
        {

            var countries = await _repo.GetCountryList();
            return View(countries);
        }
    }
}
