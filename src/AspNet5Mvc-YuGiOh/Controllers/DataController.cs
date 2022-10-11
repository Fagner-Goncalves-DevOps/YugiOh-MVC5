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
        //APIS PARA TESTE 
        //private readonly string ApiUrl = "https://db.ygoprodeck.com/api/v7/cardinfo.php";
          private readonly string ApiUrl = "https://db.ygoprodeck.com/api/v7/cardinfo.php?name=Tornado%20Dragon";
        //private readonly string ApiUrl = "https://db.ygoprodeck.com/api/v7/cardinfo.php?type=Normal%20Monster";
        public async Task<IActionResult> Index()
        {
            List<DataDtos> ListaTotal = new List<DataDtos>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(ApiUrl))
                {
                    var ApiResponse = await response.Content.ReadAsStringAsync();
                    var teste = ApiResponse; //RESPONDE OK
                    ListaTotal = JsonSerializer.Deserialize<List<DataDtos>>(ApiResponse);

                    //precisa passsar cada valor se mapear o que precisa ser feito.
                    //System.Text.Json.JsonSerializerOptions
                    //ListaTotal = JsonSerializer.Deserialize<List<DataDtos>>(ApiResponse); //padrão novo de convert 2022
                }
            }

            return View(ListaTotal);
        }
        protected async Task<T> DeserializarObjetoResponse<T>(HttpResponseMessage ApiResponse)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            return JsonSerializer.Deserialize<T>(await ApiResponse.Content.ReadAsStringAsync(), options);
        }
    }
}
