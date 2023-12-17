using CalculatorApi.Models.Feedbacks;
using Microsoft.EntityFrameworkCore;

namespace CalculatorApi.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Feedback> Feedbacks { get; set; }

        public async ValueTask<Feedback> InsertFeedbackAsync(Feedback feedback) =>
            await InsertAsync(feedback);

        public IQueryable<Feedback> SelectAllFeedbacks() =>
            SelectAll<Feedback>();

    }
}
