using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name {  get; set; }
        public string? Description {  get; set; }
        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
