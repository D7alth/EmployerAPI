using System.ComponentModel.DataAnnotations;

namespace employer_api.Models.Common;

public class BaseModel
{
    [Key]
    public int Id { get; set; }
    public DateTime UpdateAt { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public bool IsActive { get; set; } = true;
}
