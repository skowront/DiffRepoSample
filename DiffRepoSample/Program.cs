namespace DiffRepoSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app2 = builder.Build();
            var x23 = 10;
            app2.MapGet("/", () => "Hello World!");

            app2.Run();
        }
    }
}
