using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserstoryLib;
using UserStoryRest.Manager;

namespace UserStoryRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserStoryController : Controller
    {
        private readonly UserStoryManager userstoryManager = new UserStoryManager();
        // GET: UserStoryController
        [HttpGet]
        public IEnumerable<UserStory> Get()
        {
            return userstoryManager.getAll();
        }

        // GET: UserStoryController/Details/5
        [HttpGet("{id}")]
        public UserStory Get(int id)
        {
            return userstoryManager.GetById(id);
        }
        // Post
        [HttpPost]
        public UserStory Post([FromBody] UserStory value)
        {
            return userstoryManager.Add(value);
        }
        // PUT
        [HttpPut("{id}")]
        public UserStory Put(int id, [FromBody] UserStory value)
        {
            return userstoryManager.Update(id, value);
        }
        // GET: UserStoryController/Delete/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return userstoryManager.Delete(id);
        }
        // opgave 6, a: forkert
        //[HttpGet("{state}")]
        // public UserStory GetToDo(string state)
        // {
        //return userstoryManager.GetByState(state);
        //  }

    }
}
