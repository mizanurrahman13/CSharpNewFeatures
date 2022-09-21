namespace CSharp8
{
    public struct Rectangle
    {
        public double Length { get; set; }
        private double _height;
        public double Height
        {
            readonly get { return _height; }
            set { _height = value; }
        }

        public readonly double Area()
        {
            return Length * Height;
        }
    }
}
