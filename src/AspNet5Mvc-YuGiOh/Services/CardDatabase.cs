using AspNet5Mvc_YuGiOh.Interfaces;
using AspNet5Mvc_YuGiOh.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.
    Tasks;

namespace AspNet5Mvc_YuGiOh.Services
{
    public class CardDatabase : ICardDatabase
    {
        private readonly string ApiUrlAllCards = "https://db.ygoprodeck.com/api/v7/cardinfo.php";

        public async Task<List<DataDtos>> GetAllCadsByParams(FilterParams filterParams) 
        {
            //testar depois se vamos retornar tudo ou não
            var types = filterParams.type == null ? "Normal Monster" : filterParams.type;
            var races = filterParams.race == null ? "Aqua" : filterParams.race;
            var attributes = filterParams.attribute == null ? "DARK" : filterParams.attribute;

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(ApiUrlAllCards + "?type=" + types + "&race=" + races + "&attribute=" + attributes ))  //+ types + races + attributes //implentar $()
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
    }
}

//modelo de retorno
//?&type= Normal%20Monster &attribute=DARK &race=Aqua &num=24 &offset=0
