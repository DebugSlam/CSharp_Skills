using Shapes;
using System;

public class Rectangle : IDrawable
{
    private int _width;
    private int _height;

    public Rectangle(int width, int height)
    {
        this._height = height;
        this._width = width;
    }


    private void DrawLine(int width, char mid, char end)
    {
        Console.Write(end);
        for (int i = 1; i < width - 1; ++i)
        {
            Console.Write(mid);
        }
        Console.WriteLine(end);
    }

    public void Draw()
    {
        DrawLine(this._width, '*', '*');
        for (int i = 1; i < this._height - 1; ++i)
        {
            DrawLine(this._width, ' ', '*');
        }
        DrawLine(this._width, '*', '*');
    }
}

