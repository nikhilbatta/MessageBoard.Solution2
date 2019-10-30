using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MessageBoard.Models
{
    public class MessageBoardContext : IdentityDbContext<ApplicationUser>
    {
      // Don't change code in here.
      public DbSet<Post> allPosts {get;set;}
      public DbSet<Group> allGroups {get;set;}
      public MessageBoardContext(DbContextOptions options) : base(options) {}
    }
}