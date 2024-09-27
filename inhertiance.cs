using System;

// Base Class
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayPersonInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

// Derived Class (Single Inheritance)
public class Student : Person
{
    public string StudentID { get; set; }

    public Student(string name, int age, string studentID) : base(name, age)
    {
        StudentID = studentID;
    }

    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Student ID: {StudentID}");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("Alice", 20, "S12345");
        student.DisplayPersonInfo();
        student.DisplayStudentInfo();
    }
}
