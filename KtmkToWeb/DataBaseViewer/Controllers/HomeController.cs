using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using DataBaseModel;
using DataBaseViewer.Mappers;
using DataBaseViewer.ViewModels;

namespace DataBaseViewer.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IMapper _nuMapper = new NuMapper();

        [AllowAnonymous]
        public ActionResult Index()
        {
            //nuViewModel.IdNUs = 2;

            var nus = unitOfWork.NURepository.Get();
            var nuViewModels =
                nus.Select(nu => (NuViewModel) _nuMapper.Map(nu, typeof (NU), typeof (NuViewModel))).ToList();
            return View(nuViewModels);
        }

        public ActionResult Schedule()
        {
            return View();
        }
    }
}
