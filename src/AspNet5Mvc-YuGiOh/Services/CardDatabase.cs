using AspNet5Mvc_YuGiOh.Interfaces;
using AspNet5Mvc_YuGiOh.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AspNet5Mvc_YuGiOh.Services
{
    public class CardDatabase : ICardDatabase
    {
        //implementar injection dependetion remover os using
        private readonly string ApiUrlAllCards = "https://db.ygoprodeck.com/api/v7/cardinfo.php";

        public async Task<List<DataDtos>> GetAllCads()
        {
            var types = "Normal Monster";// apenas para testar

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(ApiUrlAllCards + "?type=" + types)) //apenas para testar
                {
                    var ApiResponse = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    return JsonSerializer.Deserialize<Root>(ApiResponse, options).data;
                }
            }
         }

        public async Task<DataDtos> GetCardsByType(string type)
        {
            var types = type == null ? "Normal Monster" : type;

            using (var httpClient = new HttpClient()) 
            {
                using (var response = await httpClient.GetAsync(ApiUrlAllCards + "?type=" + types)) 
                {
                    var ApiResponse = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    return JsonSerializer.Deserialize<DataDtos>(ApiResponse, options);
                } 
            }
        }


    }
}
