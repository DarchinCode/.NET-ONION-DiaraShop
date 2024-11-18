﻿using BlogManagement.Domain.ArticleCategoryAgg;
using BlogManagement.Infrastructure.EfCore.Mappings;
using Microsoft.EntityFrameworkCore;

namespace BlogManagement.Infrastructure.EfCore;

public class BlogContext : DbContext
{
    public DbSet<ArticleCategory> ArticleCategories { get; set; }
    public BlogContext(DbContextOptions<BlogContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var assembly = typeof(BlogContext).Assembly;
        modelBuilder.ApplyConfigurationsFromAssembly(assembly);
        base.OnModelCreating(modelBuilder);
    }
}