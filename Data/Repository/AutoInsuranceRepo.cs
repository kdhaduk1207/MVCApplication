using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TrainingApplication.Data.Repository.Interface;
using TrainingApplication.Entities;

namespace TrainingApplication.Data.Repository
{
    public class AutoInsuranceRepo : IAutoInsurnace
    {
        private readonly DataContext dataContext;

        public AutoInsuranceRepo(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<AutoInsurance> GetInsurnaceDetail(int id)
        {
            return await dataContext.AutoInsurances.SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}
