using CalculatorApi.Models.Users;
using CalculatorApi.Services.Foundations.Users;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService) =>
            this.userService = userService;

        [HttpPost]
        public async ValueTask<ActionResult<User>> PostUserAsync(User user) =>
            await this.userService.AddUserAsync(user);

        [HttpGet]
        public ActionResult<IQueryable<User>> GetAllUsers()
        {
            var users = this.userService.RetrieveAllUsers();

            return Ok(users);
        }

        [HttpGet("GetById")]
        public async ValueTask<ActionResult<User>> GetUserByIdAsync(Guid userId) =>
            await this.userService.RetrieveUserByIdAsync(userId);

        [HttpPut]
        public async ValueTask<ActionResult<User>> PutUserAsync(User user) =>
            await this.userService.ModifyUserAsync(user);

        [HttpDelete]
        public async ValueTask<ActionResult<User>> DeleteUserAsync(User user) =>
            await this.userService.RemoveUserAsync(user);
    }
}
