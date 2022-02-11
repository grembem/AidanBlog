#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AidanBlog.Models;

namespace AidanBlog.Data
{
    public class AidanBlogContext : DbContext
    {
        public AidanBlogContext (DbContextOptions<AidanBlogContext> options)
            : base(options)
        {
        }

        public DbSet<AidanBlog.Models.Post> Post { get; set; }
    }
}
