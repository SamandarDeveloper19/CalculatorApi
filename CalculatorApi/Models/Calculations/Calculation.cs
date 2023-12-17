using CalculatorApi.Models.Users;
using System.Text.Json.Serialization;

namespace CalculatorApi.Models.Calculations
{
    public class Calculation
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public decimal FirstNumber { get; set; }
        public decimal SecondNumber { get; set; }
        public Function Function { get; set; }

        [JsonIgnore]
        public string UserName { get; set; }
        [JsonIgnore]
        public Guid UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }

    }
}
