
using System;

abstract class Staff
{
    public abstract void Work();

    public   void Display()
    {
        Console.WriteLine("Staff Details");
    }
}

class Teacher : Staff
{
    public override void Work()
    {
        Console.WriteLine("Teacher teaches students");
    }
}
class Students : Teacher
{
    public  override void Work()
    {
        Console.WriteLine("Student Details");
    }
}


