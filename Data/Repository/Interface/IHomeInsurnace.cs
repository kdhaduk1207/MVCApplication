﻿using System.Threading.Tasks;
using TrainingApplication.Entities;

namespace TrainingApplication.Data.Repository.Interface
{
    // Not in used
    public interface IHomeInsurnace
    {
        public Task<HomeInsurance> GetInsurnaceDetail(int id);
    }
}
