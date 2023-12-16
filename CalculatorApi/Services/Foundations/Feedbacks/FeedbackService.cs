using CalculatorApi.Brokers.Storages;
using CalculatorApi.Models.Feedbacks;

namespace CalculatorApi.Services.Foundations.Feedbacks
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IStorageBroker storageBroker;

        public FeedbackService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<Feedback> AddFeedbackAsync(Feedback feedback) =>
            await this.storageBroker.InsertFeedbackAsync(feedback);

        public IQueryable<Feedback> RetrieveAllFeedbacks() =>
            this.storageBroker.SelectAllFeedbacks();

        public async ValueTask<Feedback> RetrieveFeedbackByIdAsync(Guid feedbackId) =>
            await this.storageBroker.SelectFeedbackByIdAsync(feedbackId);

        public async ValueTask<Feedback> ModifyFeedbackAsync(Feedback feedback) =>
            await this.storageBroker.UpdateFeedbackAsync(feedback);

        public async ValueTask<Feedback> RemoveFeedbackAsync(Feedback feedback) =>
            await this.storageBroker.DeleteFeedbackAsync(feedback);
    }
}
