using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//---新增
using MVC.Models;
using MVC.Service;

namespace MVC.Service
{
    public class messageDBService
    {
        //實做資料庫模型
        public MVC.Models.TESTEntities db = new Models.TESTEntities();

        //此方法取得資料庫資料回傳
        public List<Models.ordc_bah1> DBGetDate()
        {
            return db.ordc_bah1.ToList();
        }
        public void DBCreate(string status,string ord_nbr)
        {
            Models.ordc_bah1 NewDate = new Models.ordc_bah1();
            NewDate.bah_status = status;
            NewDate.ord_nbr = ord_nbr;
            NewDate.create_date = DateTime.Now;
            db.ordc_bah1.Add(NewDate);
            db.SaveChanges();
        }
    }
}