using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;
using WebApplication2.Dal;

namespace WebApplication2.Controllers
{
    public class CustoController : ApiController
    {
        public List<Custi> Post(Custi obj)
        {
            if (ModelState.IsValid)
            {
                //insert the customer object to database
                //EF DAL

                DAL objDal = new DAL();
                objDal.Customers.Add(obj);//in memory updation
                objDal.SaveChanges();//physical commit 
              
            }

            DAL dal = new DAL();
            List<Custi> customerscoll = dal.Customers.ToList<Custi>();


            return customerscoll;
        }
        public List<Custi> Get()
        {
            var allUrlKeyValues = ControllerContext.Request.GetQueryNameValuePairs();
            string CustomerCode = allUrlKeyValues.SingleOrDefault(x => x.Key == "CustomerCode").Value;
            string CustomerName = allUrlKeyValues.SingleOrDefault(x => x.Key == "CustomerName").Value;

            DAL dal = new DAL();
            List<Custi> customerscoll = new List<Custi>();
            if (CustomerName != null)
            {
                customerscoll = (from t in dal.Customers
                                 where t.CustomerName == CustomerName
                                 select t).ToList<Custi>();
            }
            else if (CustomerCode != null)
            {
                customerscoll = (from t in dal.Customers
                                 where t.CustomerCode == CustomerCode
                                 select t).ToList<Custi>();
            }
            else
            {

                customerscoll = dal.Customers.ToList<Custi>();
            }
            
            return customerscoll;

        }
       
        //update
        public List<Custi> Put(Custi obj)
        {
            //selesct the record Linq
            DAL dal = new DAL();
            Custi custupdate = (from temp in dal.Customers
                                where temp.CustomerCode == obj.CustomerCode
                                select temp).ToList<Custi>()[0];
            custupdate.CustomerAmount = obj.CustomerAmount;
            custupdate.CustomerName = obj.CustomerName;
            List<Custi> customerscoll = dal.Customers.ToList<Custi>();
            return customerscoll;


            //update the record

        }
        //delete
        public List<Custi> Delete(Custi obj)
        {
            DAL dal = new DAL();
            Custi custdelete = (from temp in dal.Customers
                                where temp.CustomerCode == obj.CustomerCode
                                select temp).ToList<Custi>()[0];
            dal.Customers.Remove(custdelete);
            dal.SaveChanges();
            List<Custi> customerscoll = dal.Customers.ToList<Custi>();
            return customerscoll;

        }
    }
}
