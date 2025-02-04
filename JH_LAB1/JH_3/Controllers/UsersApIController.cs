using JH_LAB1.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace JH_3.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersApIController : ControllerBase
    {
        private IUserRepository user;

        public UsersApIController(IUserRepository user)
        {
            this.user = user;
        }

        [HttpGet]
        public IEnumerable<User> Get() => user.Users;
        
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            if (id == 0)
            {
                return BadRequest("Value must be passed in the request");
            }
            return Ok(user[id]);
        }

        [HttpPost]
        public User Post([FromBody] User userUsed)
            =>
            user.AddUser(new User
            {
                UserId = userUsed.UserId,
                FirstName = userUsed.FirstName,
                LastName = userUsed.LastName,
                Email = userUsed.Email,
                Phone = userUsed.Phone,
                Password = userUsed.Password,
                ConfirmPassword = userUsed.ConfirmPassword
            });

        [HttpPut]
            public User Put([FromBody] User userUsed) =>
                    user.UpdateUser(userUsed);

        [HttpDelete("{id}")]
            public void Delete(int id) => user.DeleteUser(id);


        
    }
}
