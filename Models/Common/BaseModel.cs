using System.ComponentModel.DataAnnotations;

namespace employer_api.Models.Common;

public class BaseModel
{
    [Key]
    public required int Id { get; set; }
    public DateTime UpdateAt { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public required bool IsActive { get; set; } = false;
}