namespace BookApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //add services
            builder.Services.AddControllers();

            var app = builder.Build();

            //add Mapping
            app.MapControllers()
           // app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
