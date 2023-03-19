class Cuboid : Rectangle
{
    public int Height;

    public Cuboid(int length, int width, int height) : base(length, width)
    {
        Height = height;
    }

    public int Volume()
    {
        return Length * Width * Height;
    }

    public override int Area()
    {
        int area = 2 * (Length * Width + Length * Height + Width * Height);
        return area;
    }

    public override int Perimeter()
    {
        int perimeter = 4 * (Width + Length + Height);
        return perimeter;
    }

    public override string Info()
    {
        return $"{base.Info()}; Height: {Height}";
    }
}