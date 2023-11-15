using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Employee_timesheet
{
    public class HomeService
    {
        public string GetVariable()
        {
            // Get the variable from your data source.
            return "The variable value";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
