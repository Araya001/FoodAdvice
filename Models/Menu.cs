using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FoodAdvice.Data;

namespace Food_Advice.Models
{
    public class Menu : IEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
        //[Required]

        //[Required]
        [StringLength(200)]
        public string Name { get; set; }
        //[Required]
        
        [StringLength(260)]
        public string Description { get; set; }

        public int Servings { get; set; }
        
        public int ReadyInMinutes { get; set; }
        
        [StringLength(300)]
        public string Image { get; set; }
        //[StringLength(300)]
        
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public string LastUpdatedBy { get; set; }
        
        public ICollection<MenuIngredient> MenuIntegradients { get; set; }
        public ICollection<MenuInstruction> Steps { get; set; }
    }
}