using MongoDB.Driver;
using WebAppAPI.Models;
using Microsoft.Extensions.Options;

namespace WebAppAPI.Repositories
{
    public class FeedbackRepository
    {
        private readonly IMongoCollection<Feedback> _feedbackCollection;

        public FeedbackRepository(IOptions<MongoDbSettings> mongoDbSettings)
        {
            var mongoClient = new MongoClient(mongoDbSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(mongoDbSettings.Value.DatabaseName);

            _feedbackCollection = mongoDatabase.GetCollection<Feedback>("Feedbacks");
        }

        public async Task<List<Feedback>> GetAllAsync() =>
            await _feedbackCollection.Find(_ => true).ToListAsync();

        public async Task<Feedback> GetByIdAsync(Guid id) =>
            await _feedbackCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Feedback feedback) =>
            await _feedbackCollection.InsertOneAsync(feedback);

        public async Task UpdateAsync(Guid id, Feedback feedback) =>
            await _feedbackCollection.ReplaceOneAsync(x => x.Id == id, feedback);

        public async Task RemoveAsync(Guid id) =>
            await _feedbackCollection.DeleteOneAsync(x => x.Id == id);
    }
}
