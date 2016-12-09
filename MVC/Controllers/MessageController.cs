using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//---新增
using MVC.Models;
using MVC.Service;

namespace MVC.Controllers
{
    public class MessageController : Controller
    {
        messageDBService data = new messageDBService();
        // GET: Message
        public ActionResult Index()
        {
            //---新增
            return View(data.DBGetDate());
        }

        //---新增
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string status,string ord_nbr)
        {
            data.DBCreate(status, ord_nbr);
            return RedirectToAction("Index");
        }
    }
}