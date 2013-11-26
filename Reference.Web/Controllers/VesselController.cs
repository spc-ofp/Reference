using Reference.DAL.Repositories;
using Reference.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Reference.Web.Controllers
{
    
    
    public class VesselController : ApiController
    {
        private readonly Repository _repository;

        public VesselController()
        {
            _repository = new Repository(WebApiApplication.UnitOfWork.Session);
        }

        // GET api/values
        public IEnumerable<Vessel> Get()
        {
            //return new string[] { "value1", "value2" };
            return _repository.GetAll<Vessel>().Take(10);//.Select(x => x.Name);
        }

        // GET api/values/5
        public Vessel Get(int id)
        {
            return _repository.Get<Vessel>(id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Vessel value)
        {
            _repository.SaveOrUpdate<Vessel>(value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}