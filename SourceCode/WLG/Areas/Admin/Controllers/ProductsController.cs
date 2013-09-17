using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WLG.IDAL;
using WLG.Model;

namespace WLG.Areas.Admin.Controllers
{
    public class ProductsController : Controller
    {
        private IProducts IProducts = null;
        public ProductsController(IProducts IProducts)
        {
            this.IProducts = IProducts;
        }

        public ActionResult CategoryList()
        {
            return View();
        }

        public ActionResult CategoryAdd()
        {
            return View();
        }

        public ActionResult LoadCategory()
        {
            IList<Vshop_Categories> list = IProducts.GetCategoryList();
            JavaScriptSerializer json = new JavaScriptSerializer();
            string str = json.Serialize(new { rows = list, total = list.Count });
            return Content(str, "text/html;charset=UTF-8");
        }
    }
}
