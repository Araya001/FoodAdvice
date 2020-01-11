using System;
using System.ComponentModel.DataAnnotations;
using FoodAdvice.Data;

namespace Food_Advice.Models
{
    public class MenuInstruction : IEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public string LastUpdatedBy { get; set; }
        

        [StringLength(1000)] 
        public string Detail { get; set; } //รายละเอียดของขั้นตอนนั้น
        public int Sequence { get; set; } // ลำดับของขั้นตอนนั้นๆ
        
 
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}