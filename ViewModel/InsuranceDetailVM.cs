using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Reflection;
using TrainingApplication.Entities;

namespace TrainingApplication.ViewModel
{
    public class InsuranceDetailVM
    {
        public string InsurnaceType { get; set; }


        public int InsuranceId { get; set; }

        public IEnumerable<SelectListItem> InsuranceTypeList { get; set; }

        public AutoInsurance AutoInsurnaceDtl { get; set; }

        public HomeInsurance HomeInsuranceDtl { get; set; }
    }
}
