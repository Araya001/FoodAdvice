using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FoodAdvice.Data;

namespace Food_Advice.Models
{
    [Table("MenuIngredient")]
    public class MenuIngredient : IEntity
    {
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        
       public string Unit { get; set; } //หน่วยของส่วนผสมแบบย่อ เช่น g
       public string LongUnit { get; set; } //หน่วยของส่วนผสมแบเต็ม เช่น gram
       public double Value { get; set; }// จำนวนของส่วนผสม เช่น 20
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("MenuIngredientId")]
        
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}