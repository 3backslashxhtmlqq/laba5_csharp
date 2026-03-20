namespace WinFormsApp15;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string name = textBox1.Text;
        int age = Convert.ToInt32(textBox2.Text);
        
        Student student = new Student();
        Student student2 = new Student(name);
        Student student3 = new Student(name, age);
        
        listBox1.Items.Add("Конструктор без параметров: \n" + student.PrintInfo() + "\n");
        listBox1.Items.Add("Конструктор с одним параметром: \n" + student2.PrintInfo() + "\n");
        listBox1.Items.Add("Полный конструктор: \n" + student3.PrintInfo());
        
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Student student = new Student();
        listBox1.Items.Add(student.PrintInfo());
    }

    private void button3_Click(object sender, EventArgs e)
    {
        Student student = new Student("Захар");
        listBox1.Items.Add(student.PrintInfo());
    }

    private void button4_Click(object sender, EventArgs e)
    {
        Student student = new Student("Гриша", 30);
        listBox1.Items.Add(student.PrintInfo());
    }
}