using JH_LAB1.Models;
using Microsoft.AspNetCore.Mvc;

namespace JH_LAB1.WebServiceController
{
    [Route("user/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserRepository user; 

        public UserController(IUserRepository user)
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
        public User Post([FromBody] User truckUser)
        =>
            user.AddUser(new User
            {
                UserId= truckUser.UserId,
                FirstName= truckUser.FirstName,
                LastName= truckUser.LastName,
                Email= truckUser.Email,
                Phone= truckUser.Phone,
                Password= truckUser.Password,
                ConfirmPassword= truckUser.ConfirmPassword
            });

        [HttpPut]
        public User Put([FromBody] User truckUser) =>
            user.UpdateUser(truckUser);

        [HttpDelete("{id}")]
        public void Delete(int id) => user.DeleteUser(id);
    }
}
