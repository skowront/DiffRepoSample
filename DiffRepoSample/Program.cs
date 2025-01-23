namespace DiffRepoSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            var x2 = 10;
            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
