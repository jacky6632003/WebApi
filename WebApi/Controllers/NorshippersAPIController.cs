using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class NorshippersAPIController : ApiController
    {

        private Repository<Categories> repository = new Repository<Categories>();

        public IEnumerable<Categories> GetCategories()
        {
            return repository.GetAll();
        }

        public Categories GetCategories(int id)
        {
            return repository.GetById(id);
        }

        public void PostCategories(Categories categories)
        {
            repository.Create(categories);
        }
        public void PutCategories(Categories categories)
        {
            repository.Update(categories);
        }
        public void DeleteCategories(int id)
        {
            repository.Delete(repository.GetById(id));
        }
    }
}
