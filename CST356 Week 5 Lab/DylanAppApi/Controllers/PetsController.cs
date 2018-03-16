using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CST356_Week_5_Lab.Repositories;
using CST356_Week_5_Lab.Data;
using CST356_Week_5_Lab.Data.Entities;

namespace DylanAppApi.Controllers
{
    [RoutePrefix("api/pets")]
    public class PetsController : ApiController
    {
        private IAppRepository _dataRepository;

        public PetsController()
        {
            _dataRepository = new AppRepository(new MyDbContext());
        }

        [HttpGet]
        public IEnumerable<Pet> GetAllPets()
        {
            return _dataRepository.GetAllPets();
        }

        [Route("{id}")]
        [HttpGet]
        public IHttpActionResult GetPet(int id)
        {
            var pet = _dataRepository.GetPet(id);
            if (pet == null)
            {
                return NotFound();
            }
            return Ok(pet);
        }
    }
}
