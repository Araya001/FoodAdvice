using System;
using System.ComponentModel.DataAnnotations;
using FoodAdvice.Data;

namespace Food_Advice.Models
{
    public class Menu : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(60)]
        public string Title { get; set; }
        [StringLength(30)]
        public string NameTh { get; set; }
        [StringLength(30)]
        public string NameEn { get; set; }
        [StringLength(260)]
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}