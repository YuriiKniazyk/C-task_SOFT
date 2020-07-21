namespace CW5Interface
{
    public class Bird : IFlyable
    {
        public string Name { get; set; }
        public bool CanFly { get; set; }

        public Bird(string name, bool canFly)
        {
            Name = name;
            CanFly = canFly;
        }


        public bool Fly(bool iFly)
        {
            return iFly;
        }
    }
}