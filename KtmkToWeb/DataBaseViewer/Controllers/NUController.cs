using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataBaseModel;

using DataBaseViewer.Mappers;
using DataBaseViewer.ViewModels;

namespace DataBaseViewer.Controllers
{
    public class NUController : BaseController
    {
        private readonly IMapper _nuMapper = new NuMapper();
        [AllowAnonymous]
        public ActionResult Index()
        {
            var nuViewModel = new NuViewModel();
            //nuViewModel.IdNUs = 2;

            var nus = unitOfWork.NURepository.Get();
            var nuViewModels = nus.Select(nu => (NuViewModel)_nuMapper.Map(nu, typeof(NU), typeof(NuViewModel))).ToList();
            return View(nuViewModels);
        }

        public void WriteData()
        {
            var formNu = new NuViewModel();
            var nuToWrite = (NU) _nuMapper.Map(formNu, typeof (NuViewModel), typeof (NU));
            unitOfWork.NURepository.Insert(nuToWrite);
        }
    }
}
