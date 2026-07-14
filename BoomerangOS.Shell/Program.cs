using BoomerangOS.Shell.Engine;

namespace BoomerangOS.Shell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine.Engine engine = new();

            engine.Run();
        }
    }
}
