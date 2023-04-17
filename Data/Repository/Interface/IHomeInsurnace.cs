using System.Threading.Tasks;
using TrainingApplication.Entities;

namespace TrainingApplication.Data.Repository.Interface
{
    public interface IHomeInsurnace
    {
        public Task<HomeInsurance> GetInsurnaceDetail(int id);
    }
}
