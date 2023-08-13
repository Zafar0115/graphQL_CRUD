using DemoGrapQL.Data;
using DemoGrapQL.Models;

namespace DemoGrapQL.GraphQL
{
    public class MutationType
    {
        public async Task<Platform> AddPlatformAsync([Service]ApplicationDbContext context,
            Platform newPlatform)
        {
            context.Platforms.Add(newPlatform);
            await context.SaveChangesAsync();
            return newPlatform;
        }

        public async Task<Platform> UpdatePlatformAsync([Service] ApplicationDbContext context,
            Platform updatePlatform)
        {
            context.Platforms.Update(updatePlatform);
            await context.SaveChangesAsync();
            return updatePlatform;
        }

        public async Task<bool> DeletePlatformAsync([Service]ApplicationDbContext context,int id)
        {
            Platform? deletePlatform = await context.Platforms.FindAsync(id);

            if(deletePlatform is null)
                return false;

            context.Platforms.Remove(deletePlatform);
            await context.SaveChangesAsync();
            return true;
        }
    }
}
