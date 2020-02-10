using Mvc_Angular_Crud_VBNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Angular_Crud_VBNET.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetProdutos()
        {
            using (CadastroEntities ctx = new CadastroEntities())
            {
                try
                {
                    var produtos = ctx.Produtos.ToList();
                    return Json(produtos, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }