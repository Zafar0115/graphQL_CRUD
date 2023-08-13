using DemoGrapQL.Data;
using DemoGrapQL.GraphQL;
using Microsoft.EntityFrameworkCore;

namespace DemoGrapQL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<MutationType>();




            var app = builder.Build();

            app.MapGraphQL();
            app.UseGraphQLVoyager(path:"/graphql-voyager");


            app.Run();
        }
    }
}