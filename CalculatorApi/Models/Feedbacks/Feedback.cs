using CalculatorApi.Models.Users;
using System.Text.Json.Serialization;

namespace CalculatorApi.Models.Feedbacks
{
    public class Feedback
    {
        public Guid Id { get; set; }
        public string Answer { get; set; }
        public Guid UserId { get; set; }

        [JsonIgnore]
        public User User { get; set; }
    }
}
