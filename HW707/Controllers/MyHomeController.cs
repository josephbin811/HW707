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
            string theDate = null;
            int theAmount = 0;

            List<CashFlowViewModel> list = new List<CashFlowViewModel>();

            for (int i = 0; i < 50; i++)
            {
                Random ran = new Random(Guid.NewGuid().GetHashCode());

                if (i % 2 == 0)
                    theType = "收入";
                else
                    theType = "支出";

                theDate = "2018" + "-" + (ran.Next(1, 12)).ToString() + "-" + (ran.Next(1, 28)).ToString();

                theAmount = ran.Next(100, 5000);

                CashFlowViewModel obj = new CashFlowViewModel
                {
                    FlowType = theType,
                    FlowDate = theDate,
                    FlowAmount = theAmount.ToString()
                };

                list.Add(obj);
            }

            ViewData["moneyFlowList"] = list;
            #endregion

            return View();
        }
    }
}