using System;
using System.Text;

namespace BoxData;

public class Box
{
    private double _length;
    private double _width;
    private double _height;

    public double Length
    {
        get
        {
            return this._length;
        }

        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Length cannot be zero or negative");
            }

            this._length = value;
        }
    }

    public double Width
    {
        get
        {
            return this._width;
        }

        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Width cannot be zero or negative");
            }

            this._width = value;
        }
    }

    public double Height
    {
        get
        {
            return this._height;
        }

        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Height cannot be zero or negative");
            }

            this._height = value;
        }
    }

    public Box(double length, double width, double height)
    {
        this._length = length;
        this._height = height;
        this._width = width;

    }

    public double SurfaceArea()
    {
        return 2 * this.Length * this.Width + 2 * this.Length * this.Height
            + 2 * this.Width * this.Height;

    }

    public double Volume()
    {
        return this.Length * this.Width * this.Height;
    }

    public override string ToString()
    {
        return $"Surface Area – {this.SurfaceArea():F2}\nVolume – {this.Volume():F2}";
    }
}
