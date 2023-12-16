using CalculatorApi.Models.Users;
using System.Text.Json.Serialization;

namespace CalculatorApi.Models.Calculations
{
    public class Calculation
    {
        public Guid Id { get; set; }
        public decimal FirstNumber { get; set; }
        public decimal SecondNumber { get; set; }
        public string Function { get; set; }
        public Guid UserId { get; set; }

        [JsonIgnore]
        public User User { get; set; }

    }
}
