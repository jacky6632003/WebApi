using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class CategoriesController : ApiController
    {


        private Repository<Categories> repository = new Repository<Categories>();

        public IQueryable<CategoriesViewModel> GetShippers(int id)
        {

            var q = from a in repository.GetAll()
                    where a.CategoryID==id
                    select new CategoriesViewModel
                    {
                      CategoryID=a.CategoryID,
                      CategoryName=a.CategoryName,
                      Description=a.Description,
                      Picture= "/MVC/GetImage/"+ a.CategoryID,


                    };

            return q;
        }

    }
}
