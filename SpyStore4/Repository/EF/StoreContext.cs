using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Domain.Entities;

namespace Repository.EF
{
    public class StoreContext : DbContext
    {
		public StoreContext()
		{

		}

		public StoreContext(DbContextOptions options) : base(options)
		{

		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(
					@"Server=(LAPTOP-JB2L8FSV)\SQLEXPRESS;Database=SpyStoreDatabase;Trusted_Connectin=True;MultipleActive
					RelultSets = true;", options => options.ExecutionStrategy(c => new MyExecutionStrategy(c)));
			}
		}
		
		public DbSet<Category> Categories { get; set; }
    }
}
