using System.ComponentModel.DataAnnotations;
using employer_api.Models.Common;
using employer_api.Models.Enums;

namespace employer_api.Models.Entities;

public class Employer : BaseModel
{
    [MaxLength(50)]
    public string FirstName { get; set; } = null!;

    [MaxLength(50)]
    public string LastName { get; set; } = null!;
    public Departments Departments { get; set; } = Departments.It;
    public WorkShifts WorkShifts { get; set; } = WorkShifts.Morning;
}
