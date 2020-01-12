using System;
using FoodAdvice.Data;

namespace Food_Advice.Models
{
    public class MyCookbook : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public string LastUpdatedBy { get; set; }
        
        
        
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }
    }
}