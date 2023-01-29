namespace Solid_Principles.src.classes.Features.Basic
{
    interface IHaveHealth
    {
        public int health { get; set; }
        public void print()
        {
            Console.WriteLine(health.ToString());
        }
    }
}
