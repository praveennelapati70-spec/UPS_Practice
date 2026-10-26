
using System;

class Vr
{
    public virtual void Display()
    {
        Console.WriteLine("Student Details");
    }
}

class EngineeringStudent : Vr
{
    public override void Display()
    {
        Console.WriteLine("Engineering Student Details");
    }
}


