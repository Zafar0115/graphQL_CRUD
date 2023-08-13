using DemoGrapQL.Data;
using DemoGrapQL.Models;

namespace DemoGrapQL.GraphQL
{
    public class Query
    {
        public IQueryable<Platform> GetPlatform([Service]ApplicationDbContext dbContext)
        {
            return dbContext.Platforms;
        }
    }
}
