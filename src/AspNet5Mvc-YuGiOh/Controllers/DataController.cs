using AspNet5Mvc_YuGiOh.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Text.Json;

namespace AspNet5Mvc_YuGiOh.Controllers
{
    public class DataController : Controller
    {

        //private readonly string ApiUrl = "https://db.ygoprodeck.com/api/v7/cardinfo.php";
        //private readonly string ApiUrl = "https://db.ygoprodeck.com/api/v7/cardinfo.php?name=Tornado%20Dragon";
        //private readonly string ApiUrl = "https://db.ygoprodeck.com/api/v7/cardinfo.php?type=Normal%20Monster";


        public async Task<IActionResult> Index()
        {
            //List<DataDtos> ListaTotal = new List<DataDtos>();

            //using (var httpClient = new HttpClient())
            //{
            //    using (var response = await httpClient.GetAsync(ApiUrl))
            //    {
            //        var ApiResponse = await response.Content.ReadAsStringAsync();
            //        ListaTotal = JsonSerializer.Deserialize<Root>(ApiResponse).data; //não precisa passar um listagem, EF ja fez isso
            //    }
            //}
            //return View(ListaTotal.Take(10)); //pegando 10 apenas para testar
        }
    }
}
