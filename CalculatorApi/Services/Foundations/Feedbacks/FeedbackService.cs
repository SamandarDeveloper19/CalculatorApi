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

    }
}
