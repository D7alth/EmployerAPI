using employer_api.Models.Common;
using employer_api.Models.Enums;

namespace employer_api.Models;

public class Employer : BaseModel
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public Departments Departments { get; set; } = Departments.It;
    public WorkShifts WorkShifts { get; set; } = WorkShifts.Morning;
}