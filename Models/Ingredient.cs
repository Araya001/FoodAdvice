using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FoodAdvice.Data;

namespace Food_Advice.Models
{
    public class Ingredient : IEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
 
        [StringLength(200)]
        public string Name { get; set; }
        
        [StringLength(100)] 
        public string Type { get; set; }
        
        [StringLength(300)]
        public string Image { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public string LastUpdatedBy { get; set; }
        
        public ICollection<MenuIngredient> MenuIntegradients { get; set; }
    }
}