using System.Threading.Tasks;
using TrainingApplication.Entities;

namespace TrainingApplication.Data.Repository.Interface
{
    public interface IAutoInsurnace
    {
        public Task<AutoInsurance> GetInsurnaceDetail(int id);
    }
}
