using CalculatorApi.Models.Users;

namespace CalculatorApi.Services.Processings.Users
{
    public interface IUserProcessingService
    {
        User RetrieveUserByName(string userName);
        ValueTask<User> AddUserAsync(User user);
        IQueryable<User> RetrieveAllUsers();
        ValueTask<User> RetrieveUserByIdAsync(Guid userId);
        ValueTask<User> ModifyUserAsync(User user);
        ValueTask<User> RemoveUserAsync(User user);
    }
}
