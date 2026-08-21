namespace RocketApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RocketSimulation rs = new RocketSimulation();
            rs.InitRocket();
            rs.DescendRocket();
            rs.LandingComplete();
        }
    }
}
