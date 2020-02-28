using System;

namespace EcommerceAppWebForms.Data.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime ReviewDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int Rating { get; set; }
    }
}