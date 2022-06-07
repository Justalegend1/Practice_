using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Practice_1.Data
{
    public class ApplicationDbIdentityContext:IdentityDbContext
    {
        public ApplicationDbIdentityContext(DbContextOptions<ApplicationDbIdentityContext> options)
            :base(options)
        { 
        
        }
    }
}
