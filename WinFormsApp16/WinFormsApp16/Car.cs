namespace WinFormsApp16;

public class Car
{
    public string brand = "Unknown";
    public string model = "Unknown";
    public int year = 2000;

    public Car()
    {
    }

    public string GetInfo()
    {
        return "Бренд: " + brand + ", модель: " + model + ", год выпуска: " + year;
    }
    
}