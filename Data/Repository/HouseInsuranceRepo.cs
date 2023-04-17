using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TrainingApplication.Data.Repository.Interface;
using TrainingApplication.Entities;

namespace TrainingApplication.Data.Repository
{
    public class HouseInsuranceRepo : IHomeInsurnace
    {
        private readonly DataContext dataContext;

        public HouseInsuranceRepo(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<HomeInsurance> GetInsurnaceDetail(int id)
        {
            return await dataContext.HomeInsurances.SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}
