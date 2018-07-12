using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW707.Models.ViewModels;


namespace HW707.Controllers
{
    public class MyHomeController : Controller
    {
        // GET: MyHome
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult SubCashFlow()
        {
            #region 做虛擬資料

            string theType = null;

            List<CashFlowViewModel> list = new List<CashFlowViewModel>();

            for (int i = 0; i < 50; i++)
            {
                Random ran = new Random(Guid.NewGuid().GetHashCode());

                if (i % 2 == 0)
                    theType = "收入";
                else
                    theType = "支出";

                CashFlowViewModel obj = new CashFlowViewModel
                {
                    FlowType = theType,
                    FlowDate = DateTime.Now.AddDays(ran.Next(1,365)),
                    FlowAmount = ran.Next(100, 5000)
                };

                list.Add(obj);
            }

            #endregion

            return View(list);
        }
    }
}