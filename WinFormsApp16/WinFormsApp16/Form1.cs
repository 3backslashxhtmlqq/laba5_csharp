namespace WinFormsApp16;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {

        string brand = textBox1.Text;
        string model = textBox2.Text;
        int year = Convert.ToInt32(textBox3.Text);


        Car car = new Car
        {
            brand = brand,
            model = model,
            year = year
        };
        
        listBox1.Items.Add(car.GetInfo());
        
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Car car = new Car
        {
            brand = "Toyota",
            model = "Camry",
            year = 2020
        };
        
        Car car2 = new Car
        {
            brand = "BMW",
            model = "X5",
            year = 2022
        };
     
        Car car3 = new Car
        {
            brand = "Lada",
            model = "Vesta"
        };
        
        listBox1.Items.Add(car.GetInfo());
        listBox1.Items.Add(car2.GetInfo());
        listBox1.Items.Add(car3.GetInfo());
        
    }
}