using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EcommerceAppWebForms.Data.Entities
{
    public class Discount
    {
        public int Id { get; set; }
        [Required]
        public int ModelId { get; set; }
        public Model Model { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public byte Percent { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}