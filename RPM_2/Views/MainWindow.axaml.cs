using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace RPM_2.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MainFrame.Content = new HomePage();
        Console.WriteLine(MainFrame.Content.ToString());
    }

    private void NavigateToHome(object? sender, RoutedEventArgs e)
    {
        MainFrame.Content = new HomePage();
    }

    private void NavigateToEmployeeList(object? sender, RoutedEventArgs e)
    {
        MainFrame.Content = new EmployeeListPage();
    }
    
    private void NavigateToEmployeeAdd(object? sender, RoutedEventArgs e)
    {
        MainFrame.Content = new EmployeeAddPage();
    }
}