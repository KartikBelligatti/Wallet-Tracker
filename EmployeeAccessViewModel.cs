using Employee_timesheet.Models;

namespace Employee_timesheet
{
    public class EmployeeAccessViewModel /*: Employee*/ 
    {
        public string IsLoggedIn { get; set; }
        public string userName { get; set; }


        public List<Timesheet> timesheet { get; set; }
        //public Timesheet timesheet { get; set; }
        //public List<Project> project { get; set;}
    }
    
}
