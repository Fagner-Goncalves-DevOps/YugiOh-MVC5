using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AspNet5Mvc_YuGiOh.Interfaces;
using AspNet5Mvc_YuGiOh.Models;

namespace AspNet5Mvc_YuGiOh.Controllers
{
    public class DataController : Controller
    {
        private readonly ICardDatabase _cardDatabase;

        public DataController(ICardDatabase cardDatabase) 
        {
            _cardDatabase = cardDatabase;
        }

        public async Task<IActionResult> Index(FilterParams filterParams)
        {
            var AllCards = await _cardDatabase.GetAllCadsByParams(filterParams);
            return View(AllCards);
        }
    }
}
