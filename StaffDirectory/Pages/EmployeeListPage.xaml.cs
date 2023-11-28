using StaffDirectory.Models;
using StaffDirectory.Models.ViewModel;

namespace StaffDirectory.Pages;

public partial class EmployeeListPage : ContentPage
{
	public EmployeeListPage()
	{
		InitializeComponent();

		BindingContext = new EmployeesViewModel();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        // Refresh the employee list
        var viewModel = BindingContext as EmployeesViewModel;
        viewModel?.LoadEmployees();
    }

    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		var employee = (Employee)e.Item;
		var employeeDetailViewModel = new EmployeeDetailViewModel { Employee = employee };
		var employeeDetailPage = new EmployeeDetailPage();
		employeeDetailPage.BindingContext = employeeDetailViewModel;

		Navigation.PushAsync(employeeDetailPage);

    }

    private async void OnUpdateEmployeeClicked(object sender, EventArgs e)
    {
        // Get the selected employee. Here, we are getting the BindingContext of the button clicked.
        var button = (Button)sender;
        var selectedEmployee = (Employee)button.BindingContext;

        // Navigate to the UpdateEmployeePage with the selected employee
        await Navigation.PushAsync(new UpdateEmployeePage(selectedEmployee));
    }

   
}
