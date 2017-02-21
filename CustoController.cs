using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Dal;
using WebApplication2.ViewModel;
using System.Threading;


namespace WebApplication2.Controllers
{

    public class CustoUIController : Controller
    {
        public ActionResult EnterCustome()
        {
            return View();
        }
        // GET: Custo
        //    public ActionResult Load()
        //    {
        //        Custi obj = new Custi { CustomerCode = "40", CustomerName = "Sukesh" };
        //        return View("Custome", obj);
        //    }
        //    public ActionResult Enter()
        //    {
        //        //View mOdel object
        //        CustomerViewModel obj = new CustomerViewModel();
        //        //single object is fresh
        //        obj.customer = new Custi();
        //        return View("EnterCustome", obj);
        //    }
        //    //public ActionResult EnterSearch()
        //    //{
        //    //    CustomerViewModel obj = new CustomerViewModel();
        //    //    obj.customers = new List<Custi>();
        //    //    return View("SearchCustomer", obj);
        //    //}
        //    //public ActionResult getCustomers()//gives  JSON collection
        //    //{
        //    //    DAL dal = new DAL();
        //    //    List<Custi> customerscoll = dal.Customers.ToList<Custi>();

        //    //    return Json(customerscoll, JsonRequestBehavior.AllowGet);// Req behaviour allows to get called by http func  
        //    //}
        //    //[ActionName("getCustomerByName")]
        //    //public ActionResult getCustomers(Custi obj)//gives  JSON collection
        //    //{
        //    //    DAL dal = new DAL();
        //    //    List<Custi> customerscoll = (from temp in dal.Customers
        //    //                                 where temp.CustomerName == obj.CustomerName
        //    //                                 select temp).ToList<Custi>();

        //    //    return Json(customerscoll, JsonRequestBehavior.AllowGet);// Req behaviour allows to get called by http func  
        //    //}

        //public ActionResult SearchCustomer()
        //{

        //    CustomerViewModel obj = new CustomerViewModel();
        //    DAL dal = new DAL();
        //    string str = Request.Form["txtCustomerName"].ToString();
        //    List<Custi> customerscoll
        //        = (from x in dal.Customers
        //           where x.CustomerName == str
        //           select x).ToList<Custi>();
        //    obj.customers = customerscoll;
        //    return View("SearchCustomer", obj);
        }
        //    public ActionResult Submit(Custi obj)//validation runs and errors ar send to obj called as model state 
        //    {


        //        if (ModelState.IsValid)
        //        {
        //            //insert the customer object to database
        //            //EF DAL

        //            DAL objDal = new DAL();
        //            objDal.Customers.Add(obj);//in memory updation
        //            objDal.SaveChanges();//physical commit 
        //            objDal.Dispose();
        //        }

        //        DAL dal = new DAL();
        //        List<Custi> customerscoll = dal.Customers.ToList<Custi>();


        //        return Json(customerscoll, JsonRequestBehavior.AllowGet);
        //    }
    }


