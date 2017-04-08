using DataBaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataBaseViewer.Controllers
{
    public abstract class BaseController : Controller
    {
        //
        // GET: /Base/
        private UnitOfWork _unitOfWork;

        public UnitOfWork unitOfWork
        {
            
            get { return _unitOfWork ?? (_unitOfWork = new UnitOfWork()); }
        }
    }
}
