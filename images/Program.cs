using System;

class Student
{
    public string FullName { get; set; }
    public string Group { get; set; }
    public double AverageGrade { get; set; }

    public Student(string fullName, string group, double averageGrade)
    {
        FullName = fullName;
        Group = group;
        AverageGrade = averageGrade;
    }

    public virtual double GetScholarshipAmount()
    {
        return AverageGrade == 5 ? 2000 : 1900;
    }
}

class Aspirant : Student
{
    public Aspirant(string fullName, string group, double averageGrade)
        : base(fullName, group, averageGrade) { }

    public override double GetScholarshipAmount()
    {
        return AverageGrade == 5 ? 2500 : 2200;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Иванов Иван Иванович", "Группа 1", 4.5);
        Console.WriteLine($"Стипендия студента: {student1.GetScholarshipAmount()} рублей");

        Aspirant aspirant1 = new Aspirant("Петрова Анна Сергеевна", "Группа 2", 5);
        Console.WriteLine($"Стипендия аспиранта: {aspirant1.GetScholarshipAmount()} рублей");
    }
}
