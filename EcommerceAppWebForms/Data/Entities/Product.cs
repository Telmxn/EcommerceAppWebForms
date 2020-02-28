using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceAppWebForms.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public Model Model { get; set; }
        public int ModelId { get; set; }
        public State State { get; set; }
        public decimal Price { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public Product()
        {
            Reviews = new HashSet<Review>();
        }
    }
    public enum State
    {
        New,
        Used
    }
}