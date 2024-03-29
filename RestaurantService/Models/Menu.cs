﻿using System.ComponentModel.DataAnnotations;

namespace RestaurantService.Models
{
    public class Menu
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
