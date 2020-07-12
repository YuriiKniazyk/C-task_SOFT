namespace Lecture2Type
{
    public struct RGBStructure
    {
        public byte red;
        public byte green;
        public byte blue;

        public override string ToString()
        {
            return $"{red}, {green}, {blue}";
        }
    }
}