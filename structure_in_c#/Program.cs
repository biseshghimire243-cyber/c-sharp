using System;

struct Student
{
    public int id;
    public string name;

    public void Display()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Name: " + name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s;

        s.id = 101;
        s.name = "Bishesh";

        s.Display();
    }
}