
using System;

interface IEmployee
{
    void DisplayEmployee();
}

interface IManager
{
    void DisplayManager();
}

class Developer : IEmployee, IManager
{
    public void DisplayEmployee()
    {
        Console.WriteLine("I am an Employee");
    }

    public void DisplayManager()
    {
        Console.WriteLine("I am a Manager");
    }
}




