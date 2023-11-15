using Employee_timesheet.Models;

namespace Employee_timesheet
{
    public class AccessService
    {
        public IEnumerable<Timesheet>? Timesheets { get; set; }
        public EmployeeAccessViewModel? AccessViewModel { get; set; }

    }


}
