using CalculatorApi.Models.Calculations;
using CalculatorApi.Models.Feedbacks;
using System.Text.Json.Serialization;

namespace CalculatorApi.Models.Users
{
    public class User
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        [JsonIgnore]
        public List<Calculation> Calculations { get; set; }
        [JsonIgnore]
        public List<Feedback> Feedbacks { get; set; }


    }
}
