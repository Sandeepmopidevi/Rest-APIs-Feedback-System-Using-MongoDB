using System;

namespace WebAppAPI.Models
{
    public class Feedback
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
        public required string Comments { get; set; }
        public int Rating { get; set; } // Rating out of 5
    }
}
