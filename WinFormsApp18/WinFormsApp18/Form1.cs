namespace WinFormsApp18;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int p_x = Convert.ToInt32(textBox1.Text);
        int p_y = Convert.ToInt32(textBox2.Text);
        
        Point p = new Point(p_x, p_y);
        Point p2 = new Point(p_x, p_y);
        Point p3 = new Point(p_x, p_y);

        (int x, int y) = p;
        listBox1.Items.Add("x = " + x.ToString() + ", y = " + y.ToString());

        (_, int Y) = p2;
        listBox1.Items.Add("y = " + y.ToString());

        (int X, _) = p3;
        listBox1.Items.Add("x = " + x.ToString());
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Point point = new  Point(10, 20);
        (int x, int y) = point;
        listBox1.Items.Add("x = " + x.ToString() + ", y = " + y.ToString());
    }

    private void button3_Click(object sender, EventArgs e)
    {
        Point point = new  Point(5, 7);
        (_, int y) = point;
        listBox1.Items.Add("y = " + y.ToString());
    }
}