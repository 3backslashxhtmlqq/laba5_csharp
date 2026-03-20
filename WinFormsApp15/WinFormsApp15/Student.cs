namespace WinFormsApp15;

public class Student
{
    private string name;
    private int age;

    public Student()
    {
        this.name = "Иван";
        this.age = 18;
    }

    public Student(string name)
    {
        this.name = name;
        this.age = 18;
    }

    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string PrintInfo()
    {
        return "Имя: " + name + ", возраст: " + age;
    }
    
}