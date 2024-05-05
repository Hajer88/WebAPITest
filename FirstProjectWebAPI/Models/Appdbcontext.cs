using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FirstProjectWebAPI.Models
{
	public class Appdbcontext : IdentityDbContext
	{
		public Appdbcontext(DbContextOptions options)
			:base(options)
		{
		}
		public DbSet<Categorie> categories { get; set; }
	}
}

