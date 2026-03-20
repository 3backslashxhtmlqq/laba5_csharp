namespace WinFormsApp14;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string title = textBox1.Text;
        int pages = Convert.ToInt32(textBox2.Text);
        
        Book book = new Book(title, pages);
        listBox1.Items.Add(book.GetInfo());
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Book book = new Book("Война и мир", 1200);
        listBox1.Items.Add(book.GetInfo());
    }

    private void button3_Click(object sender, EventArgs e)
    {
        Book book = new Book("1984", 300);
        listBox1.Items.Add(book.GetInfo());
    }

    private void button4_Click(object sender, EventArgs e)
    {
        Book book = new Book(500);
        listBox1.Items.Add(book.GetInfo());
    }
}