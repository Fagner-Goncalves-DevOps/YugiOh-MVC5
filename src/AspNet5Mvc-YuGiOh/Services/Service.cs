using AspNet5Mvc_YuGiOh.Interfaces;
using AspNet5Mvc_YuGiOh.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AspNet5Mvc_YuGiOh.Services
{
    public class Service : ICardDatabase
    {

        private readonly string ApiUrlAllCards = "https://db.ygoprodeck.com/api/v7/cardinfo.php";


        public async Task<DataDtos> GetAllCads()
        {
            var ListaTotal = new List<DataDtos>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(ApiUrlAllCards))
                {
                    var ApiResponse = await response.Content.ReadAsStringAsync();
                     ListaTotal = JsonSerializer.Deserialize<Root>(ApiResponse).data;
                }
            }
            return ListaTotal;
        }

        public Task<Root> GetCardsByType(DataDtos dataDtos)
        {
            throw new NotImplementedException();
        }




        //public async Task<IActionResult> Index()
        //{
        //    List<DataDtos> ListaTotal = new List<DataDtos>();

        //    using (var httpClient = new HttpClient())
        //    {
        //        using (var response = await httpClient.GetAsync(ApiUrl))
        //        {
        //            var ApiResponse = await response.Content.ReadAsStringAsync();
        //            ListaTotal = JsonSerializer.Deserialize<Root>(ApiResponse).data; //não precisa passar um listagem, EF ja fez isso
        //        }
        //    }
        //    return View(ListaTotal.Take(10)); //pegando 10 apenas para testar
        //}
    }
}
