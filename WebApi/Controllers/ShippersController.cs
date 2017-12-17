using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;


namespace WebApi.Controllers
{
    public class ShippersController : ApiController
    {
        private Repository<Shippers> repository = new Repository<Shippers>();



        //public IQueryable<shippviewmodel> GetShippers()
        //{

        //    var q = from a in repository.GetAll()
        //            select new shippviewmodel
        //            {
        //                CompanyName = a.CompanyName,
        //                Phone = a.Phone
        //            };

        //    return q;
        //}

        public IQueryable<Shippers> GetShippers()
        {

            return repository.GetAll();
        }



        public Shippers GetShippers(int id)
        {
            return repository.GetById(id);
        }
        public void PostShippers(Shippers shipper)
        {
            repository.Create(shipper);
        }
        public void PutShippers(Shippers shipper)
        {
            repository.Update(shipper);
        }

        public void DeleteShippers(int id)
        {
            repository.Delete(repository.GetById(id));
        }

    }
}
