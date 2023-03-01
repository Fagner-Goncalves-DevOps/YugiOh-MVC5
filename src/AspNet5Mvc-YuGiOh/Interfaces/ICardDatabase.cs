using AspNet5Mvc_YuGiOh.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNet5Mvc_YuGiOh.Interfaces
{
    public interface ICardDatabase
    {
        //todos list, depois testar com IEnumerable
        Task<List<DataDtos>> GetAllCadsByParams(FilterParams filterParams); 

        //Task<List<DataDtos>> GetCardsByRace(string Race);
        //Task<List<DataDtos>> GetCardsByType(string type);
        //Task<List<DataDtos>> GetCardsByAttribute(string Attribute);
    }
}
