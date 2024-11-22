using System.Collections.Generic;
using System.Collections.ObjectModel;
using RPM_2.Models;

namespace RPM_2.Repositories;

public static class Employees
{
    static Employees()
    {
        EmployeesCollection = new ObservableCollection<Employee>()
        {
            new Employee { Name = "Иван Иванов", Position = "Разработчик" },
            new Employee { Name = "Анна Петрова", Position = "Дизайнер" },
            new Employee { Name = "Владислав Васильев", Position = "Юрист" }
        };
    }
    public static ObservableCollection<Employee> EmployeesCollection { get; set; }
}