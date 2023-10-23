using StaffDirectory.Models.ViewModel;
using StaffDirectory.Models;
namespace StaffDirectory.Pages;

public partial class UpdateEmployeePage : ContentPage
{
	public UpdateEmployeePage(Employee selectedEmployee)
	{
		InitializeComponent();

        // Setting the BindingContext to our ViewModel, passing in the selected employee
        BindingContext = new UpdateEmployeeViewModel(selectedEmployee);
    }

	
}   