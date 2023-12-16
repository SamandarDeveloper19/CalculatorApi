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

        public async ValueTask<Feedback> SelectFeedbackByIdAsync(Guid feedbackId) =>
            await SelectAsync<Feedback>(feedbackId);

        public async ValueTask<Feedback> UpdateFeedbackAsync(Feedback feedback) =>
            await UpdateAsync(feedback);

        public async ValueTask<Feedback> DeleteFeedbackAsync(Feedback feedback) =>
            await DeleteAsync(feedback);
    }
}
