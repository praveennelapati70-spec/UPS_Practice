
using System;

class Employee
{
    public string name = "Praveen";
    public int salary = 30000;

    public void DisplayEmployee()
    {
        Console.WriteLine("Employee Name: " + name);
        Console.WriteLine("Salary: " + salary);
    }
}

class Manager : Employee
{
    public string department = "IT";

    public void DisplayManager()
    {
        Console.WriteLine("Department: " + department);
    }
}

