namespace CW5Interface
{
    public class Plane : IFlyable
    {
        public string Mark { get; set; }
        public bool HighFly { get; set; }

        public Plane(string name, bool canFly)
        {
            Mark = name;
            HighFly = canFly;
        }

        public bool Fly(bool iFly)
        {
            return iFly;
        }
    }
}