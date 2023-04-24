using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingApplication.Entities;

namespace TrainingApplication.Data.Repository.Interface
{
    public interface IGenericRepo<T> where T : BaseEntity
    {
        public Task<T> GetInsurnaceDetail(int id);

        public Task<IEnumerable<T>> GetAll();
    }
}
