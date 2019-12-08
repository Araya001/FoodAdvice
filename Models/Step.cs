using System;
using System.ComponentModel.DataAnnotations;
using FoodAdvice.Data;

namespace Food_Advice.Models
{
    public class Step : IEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public string LastUpdatedBy { get; set; }

        [StringLength(1000)]
        public string Detail { get; set; }
        [StringLength(260)]
        public string Description { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}