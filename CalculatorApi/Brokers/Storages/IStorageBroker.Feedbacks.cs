using CalculatorApi.Models.Feedbacks;

namespace CalculatorApi.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Feedback> InsertFeedbackAsync(Feedback feedback);
        IQueryable<Feedback> SelectAllFeedbacks();
        ValueTask<Feedback> SelectFeedbackByIdAsync(Guid feedbackId);
        ValueTask<Feedback> UpdateFeedbackAsync(Feedback feedback);
        ValueTask<Feedback> DeleteFeedbackAsync(Feedback feedback);
    }
}
