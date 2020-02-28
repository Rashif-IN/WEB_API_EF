using System;
using Microsoft.EntityFrameworkCore;
using WEBAPIEF.Model;

namespace WEBAPIEF
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions<PostContext> options) : base(options) { }
        public DbSet<Post> postsss { get; set; }

    }
}
