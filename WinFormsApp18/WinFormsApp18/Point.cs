namespace WinFormsApp18;

public class Point
{
    public int x = 0;
    public int y = 0;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Deconstruct(out int x, out int y)
    {
        x = this.x;
        y = this.y;
    }
    
}