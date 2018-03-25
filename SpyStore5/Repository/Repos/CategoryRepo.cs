using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Repository.EF;
using Repository.Repos.Base;
using Domain.Entities;

namespace Repository.Repos 
{
    public class CategoryRepo : RepoBase<Category>
    {
		public CategoryRepo(DbContextOptions<StoreContext> options) : base(options)
		{

		}

		public CategoryRepo()
		{

		}

		
	}
}
