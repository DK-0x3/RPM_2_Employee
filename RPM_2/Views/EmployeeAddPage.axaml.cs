using Avalonia.Controls;
using Avalonia.Interactivity;
using RPM_2.Models;
using RPM_2.Repositories;

namespace RPM_2.Views;

public partial class EmployeeAddPage : UserControl
{
    public EmployeeAddPage()
    {
        InitializeComponent();
    }
    
    private void AddEmployee(object? sender, RoutedEventArgs e)
    {
        Employee employee = new Employee();
        
        if (NameTextBoxAdd.Text != null && NameTextBoxAdd.Text.Length > 0)
        {
            employee.Name = NameTextBoxAdd.Text;
        }
        if (PositionTextBoxAdd.Text != null && PositionTextBoxAdd.Text.Length > 0)
        {
            employee.Position = PositionTextBoxAdd.Text;
        }
        
        Employees.EmployeesCollection.Add(employee);

        (Parent as ContentControl)!.Content = new EmployeeListPage();
    }
}