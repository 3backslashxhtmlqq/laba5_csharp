namespace WinFormsApp17;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int a = Convert.ToInt32(textBox1.Text);
        int b = Convert.ToInt32(textBox2.Text);
        int c = Convert.ToInt32(textBox3.Text);
        
        Triangle triangle = new Triangle(a, b, c);
        if (triangle.isValid())
        {
            listBox1.Items.Add(triangle.PrintSides());
            listBox1.Items.Add("Результат проверки: " + triangle.isValid());
        }
        else
        {
            listBox1.Items.Add(triangle.PrintSides());
            listBox1.Items.Add("Результат проверки: " + triangle.isValid());
        }
        
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Triangle triangle = new Triangle(3, 4, 5);
        if (triangle.isValid())
        {
            listBox1.Items.Add(triangle.PrintSides());
            listBox1.Items.Add("Результат проверки: " + triangle.isValid());
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        Triangle triangle = new Triangle(1, 2, 4);
        if (!triangle.isValid())
        {
            listBox1.Items.Add(triangle.PrintSides());
            listBox1.Items.Add("Результат проверки: " + triangle.isValid());
        }
    }
}