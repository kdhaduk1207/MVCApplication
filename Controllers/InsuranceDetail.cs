using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingApplication.Data.Repository.Interface;
using TrainingApplication.Entities;
using TrainingApplication.ViewModel;

namespace TrainingApplication.Controllers
{
    public class InsuranceDetail : Controller
    {
       /* NOT IN USED CODE
        
        private readonly IHomeInsurnace homeInsurnace;
        private readonly IAutoInsurnace autoInsurnace;

        public InsuranceDetail(IHomeInsurnace homeInsurnace, IAutoInsurnace autoInsurnace)
        {
            this.homeInsurnace = homeInsurnace;
            this.autoInsurnace = autoInsurnace;
        }

       */

        private readonly IGenericRepo<HomeInsurance> homeInsurnace;
        private readonly IGenericRepo<AutoInsurance> autoInsurnace;

        public InsuranceDetail(IGenericRepo<HomeInsurance> homeInsurnace, IGenericRepo<AutoInsurance> autoInsurnace)
        {
            this.homeInsurnace = homeInsurnace;
            this.autoInsurnace = autoInsurnace;
        }

        public IActionResult Index()
        {
            InsuranceDetailVM insuranceDetailVM = new InsuranceDetailVM();
            insuranceDetailVM.InsuranceTypeList = new List<SelectListItem>(){
                                        new SelectListItem(){ Text="Auto",Value="Auto" },
                new SelectListItem(){ Text="House",Value="House" }};

            return View(insuranceDetailVM);
        }

        [HttpPost]
        public async Task<ActionResult> PostData(InsuranceDetailVM model)
        {
            //// the value is received in the controller.
            //var selectedGender = model.Gender;
            model.InsuranceTypeList = new List<SelectListItem>(){
                                        new SelectListItem(){ Text="Auto",Value="Auto" },
                new SelectListItem(){ Text="House",Value="House" }};

            if (model.InsurnaceType.ToLower() == "auto")
            {
                //code here
                model.AutoInsurnaceDtl = await autoInsurnace.GetInsurnaceDetail(model.InsuranceId);
            }
            else if (model.InsurnaceType.ToLower() == "house")
            {
                model.HomeInsuranceDtl = await homeInsurnace.GetInsurnaceDetail(model.InsuranceId);
                //code here
            }



            return View("Index", model);
        }
    }
}
