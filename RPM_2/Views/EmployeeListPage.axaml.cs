using Avalonia.Controls;
using Avalonia.Interactivity;
using RPM_2.Models;
using RPM_2.Repositories;

namespace RPM_2.Views;

public partial class EmployeeListPage : UserControl
{
    public EmployeeListPage()
    {
        InitializeComponent();
    }

    private void EditEmployee(object? sender, RoutedEventArgs e)
    {
        if (sender is Button button && button.CommandParameter is Employee employee)
        {
            (Parent as ContentControl)!.Content = new EmployeeEditPage(employee);
        }
    }
    
    private void RemoveEmployee(object? sender, RoutedEventArgs e)
    {
        if (sender is Button button && button.CommandParameter is Employee employee)
        {
            Employees.EmployeesCollection.Remove(employee);
        }
    }
}