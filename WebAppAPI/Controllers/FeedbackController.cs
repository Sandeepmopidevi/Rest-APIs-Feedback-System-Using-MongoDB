using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAppAPI.Models;
using WebAppAPI.Repositories;

namespace WebAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly FeedbackRepository _feedbackRepository;

        public FeedbackController(FeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Feedback>>> GetFeedbacks()
        {
            var feedbacks = await _feedbackRepository.GetAllAsync();
            return Ok(feedbacks);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Feedback>> GetFeedback(Guid id)
        {
            var feedback = await _feedbackRepository.GetByIdAsync(id);

            if (feedback == null)
            {
                return NotFound();
            }

            return Ok(feedback);
        }

        [HttpPost]
        public async Task<ActionResult<Feedback>> PostFeedback(Feedback feedback)
        {
            await _feedbackRepository.CreateAsync(feedback);
            return CreatedAtAction(nameof(GetFeedback), new { id = feedback.Id }, feedback);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutFeedback(Guid id, Feedback feedback)
        {
            var existingFeedback = await _feedbackRepository.GetByIdAsync(id);
            if (existingFeedback == null)
            {
                return NotFound();
            }

            await _feedbackRepository.UpdateAsync(id, feedback);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeedback(Guid id)
        {
            var existingFeedback = await _feedbackRepository.GetByIdAsync(id);
            if (existingFeedback == null)
            {
                return NotFound();
            }

            await _feedbackRepository.RemoveAsync(id);
            return NoContent();
        }
    }
}
