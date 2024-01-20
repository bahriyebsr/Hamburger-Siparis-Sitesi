using HamburgerSitesi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerSitesi.Data.Context
{
	public class HamburgerSitesiContext:DbContext
	{
		public HamburgerSitesiContext(DbContextOptions<HamburgerSitesiContext> options) : base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new UserConfiguration());
			modelBuilder.ApplyConfiguration(new CategoryConfiguration());
			modelBuilder.ApplyConfiguration(new ProductConfiguration());
			base.OnModelCreating(modelBuilder);
		}
		public DbSet<UserEntity> Users => Set<UserEntity>();
		public DbSet<CategoryEntity> Categories => Set<CategoryEntity>();
		public DbSet<ProductEntity> Products => Set<ProductEntity>();
	}
}
