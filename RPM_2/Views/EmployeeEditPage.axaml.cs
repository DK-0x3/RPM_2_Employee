using Avalonia.Controls;
using Avalonia.Interactivity;
using RPM_2.Models;

namespace RPM_2.Views;

public partial class EmployeeEditPage : UserControl
{
    private readonly Employee _employee;

    public EmployeeEditPage(Employee employee)
    {
        InitializeComponent();
        _employee = employee;

        NameTextBox.Text = _employee.Name;
        PositionTextBox.Text = _employee.Position;
    }

    private void SaveChanges(object? sender, RoutedEventArgs e)
    {
        if (NameTextBox.Text != null && NameTextBox.Text.Length > 0)
        {
            _employee.Name = NameTextBox.Text;
        }
        if (PositionTextBox.Text != null && PositionTextBox.Text.Length > 0)
        {
            _employee.Position = PositionTextBox.Text;
        }

        (Parent as ContentControl)!.Content = new EmployeeListPage();
    }
}