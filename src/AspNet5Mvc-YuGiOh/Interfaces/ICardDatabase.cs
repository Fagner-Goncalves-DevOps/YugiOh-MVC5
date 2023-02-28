using AspNet5Mvc_YuGiOh.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNet5Mvc_YuGiOh.Interfaces
{
    public interface ICardDatabase
    {
        Task<List<DataDtos>> GetAllCads();
        Task<DataDtos> GetCardsByType(string type);

        //Task<Root> GetCardsByType(DataDtos dataDtos);
    }
}
