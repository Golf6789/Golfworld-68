using System;
using System.Collections.Generic;

// 🔹 Abstract Class
abstract class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }

    public abstract void ShowInfo(); // polymorphism
}

// 🔹 Student
class Student : Person
{
    public string ID;
    public double Score;

    public Student(string name, string id, double score) : base(name)
    {
        ID = id;
        Score = score;
    }

    public string GetGrade()
    {
        if (Score >= 80) return "A";
        else if (Score >= 75) return "B+";
        else if (Score >= 70) return "B";
        else if (Score >= 65) return "C+";
        else if (Score >= 60) return "C";
        else if (Score >= 55) return "D+";
        else if (Score >= 50) return "D";
        else return "F";
    }

    public override void ShowInfo()
    {
        Console.WriteLine("ID: " + ID + " Name: " + Name + " Score: " + Score + " Grade: " + GetGrade());
    }
}

// 🔹 Course
class Course
{
    public string CourseName;
    public string CourseID;

    List<Student> students = new List<Student>();

    public Course(string name, string id)
    {
        CourseName = name;
        CourseID = id;
    }

    public void AddStudent(Student s)
    {
        students.Add(s);
    }

    public void ShowAll()
    {
        foreach (Student s in students)
        {
            s.ShowInfo();
        }
    }

    public void ShowMaxMin()
    {
        if (students.Count == 0) return;

        Student max = students[0];
        Student min = students[0];

        foreach (Student s in students)
        {
            if (s.Score > max.Score) max = s;
            if (s.Score < min.Score) min = s;
        }

        Console.WriteLine("คะแนนสูงสุด:");
        max.ShowInfo();

        Console.WriteLine("คะแนนต่ำสุด:");
        min.ShowInfo();
    }

    public void ShowAverage()
    {
        if (students.Count == 0) return;

        double sum = 0;
        foreach (Student s in students)
        {
            sum += s.Score;
        }

        Console.WriteLine("ค่าเฉลี่ย: " + (sum / students.Count));
    }
}

// 🔹 Main
class Program
{
    static void Main()
    {
        Course course = null;

        while (true)
        {
            Console.WriteLine("\n1. สร้างวิชา");
            Console.WriteLine("2. เพิ่มนักศึกษา");
            Console.WriteLine("3. แสดงผล");
            Console.WriteLine("4. ออก");

            Console.Write("เลือก: ");
            int ch = int.Parse(Console.ReadLine());

            if (ch == 1)
            {
                Console.Write("ชื่อวิชา: ");
                string name = Console.ReadLine();

                Console.Write("รหัสวิชา: ");
                string id = Console.ReadLine();

                course = new Course(name, id);
            }
            else if (ch == 2)
            {
                if (course == null)
                {
                    Console.WriteLine("กรุณาสร้างวิชาก่อน");
                    continue;
                }

                Console.Write("ชื่อ: ");
                string name = Console.ReadLine();

                Console.Write("รหัส: ");
                string id = Console.ReadLine();

                Console.Write("คะแนน: ");
                double score = double.Parse(Console.ReadLine());

                course.AddStudent(new Student(name, id, score));
            }
            else if (ch == 3)
            {
                if (course == null) continue;

                Console.WriteLine("\nรายชื่อนักศึกษา:");
                course.ShowAll();

                course.ShowMaxMin();
                course.ShowAverage();
            }
            else if (ch == 4)
            {
                break;
            }
        }
    }
}