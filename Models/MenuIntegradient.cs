using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FoodAdvice.Data;

namespace Food_Advice.Models
{
    public class MenuIntegradient : IEntity
    {
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        
        public int IntegradientId { get; set; }
        public Integradient Integradient { get; set; }
        
        public int Priority { get; set; }
        public string Volumn { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("MenuIntegradientId")]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}