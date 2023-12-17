using Xeptions;

namespace CalculatorApi.Models.Users.Exceptions
{
    public class UserNotFoundByNameException : Xeption
    {
        public UserNotFoundByNameException(string userName)
            : base(message: $"User not found with name: {userName}, please register!")
        { }
    }
}
