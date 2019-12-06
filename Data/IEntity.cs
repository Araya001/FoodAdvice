using System;

namespace FoodAdvice.Data
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime CreatedAt { get; set; }
        string CreatedBy { get; set; }
        DateTime LastUpdatedAt { get; set; }
        string LastUpdatedBy { get; set; }
    }
}