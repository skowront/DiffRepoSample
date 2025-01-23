namespace DiffRepoSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app2 = builder.Build();
            var x3 = 10;

            app2.Run();
        }
    }
}
