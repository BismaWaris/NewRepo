using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StaffDirectory.Models;
using System.Threading.Tasks;

namespace StaffDirectory.Models.ViewModel
{
    public partial class UpdateEmployeeViewModel : ObservableObject
    {
        private Employee Employee;  

        public UpdateEmployeeViewModel(Employee employee)
        {
            Employee = employee;
        }

        public Employee EmployeeToUpdate
        {
            get => Employee;
            set => SetProperty(ref Employee, value);
        }

        [RelayCommand]
        public async Task UpdateEmployee()
        {
            // Call the data service to update the employee
            await App.Database.UpdateEmployeeAsync(Employee);

            
        }

       
    }
}










    


