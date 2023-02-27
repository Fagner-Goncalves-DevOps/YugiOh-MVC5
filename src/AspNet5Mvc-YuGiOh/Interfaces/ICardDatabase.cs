using AspNet5Mvc_YuGiOh.Models;
using System.Threading.Tasks;

namespace AspNet5Mvc_YuGiOh.Interfaces
{
    public interface ICardDatabase
    {
        Task<DataDtos> GetAllCads();
        Task<Root> GetCardsByType(DataDtos dataDtos);
    }
}
