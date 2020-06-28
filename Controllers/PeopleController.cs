using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepositoryPatternSample.Data;
using RepositoryPatternSample.Repositories;

namespace RepositoryPatternSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly IRepository<People> _peopleRepository;

        public PeopleController(IRepository<People> peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }

        // [HttpGet]
        // public People Get(int id)
        // {
        //     return _peopleRepository.GetById(id);
        // }

        [HttpGet]
        public async Task<IEnumerable<People>> GetAllAsync()
        {
            return await _peopleRepository.GetAllAsync();
        }

        [HttpPost]
        public string Crete(People input)
        {
            try
            {
                _peopleRepository.Add(input);
                return "added";

            }
            catch (System.Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
