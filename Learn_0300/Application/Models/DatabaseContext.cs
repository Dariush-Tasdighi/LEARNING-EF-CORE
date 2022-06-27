using Microsoft.EntityFrameworkCore;

namespace Models
{
	public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext
	{
		//public DatabaseContext() : base()
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public DatabaseContext() : base()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		{
			// **************************************************
			Database.EnsureCreated();
			// **************************************************
		}

		public Microsoft.EntityFrameworkCore.DbSet<Category01> Categories01 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category02> Categories02 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category03> Categories03 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category04> Categories04 { get; set; }

		//public Microsoft.EntityFrameworkCore.DbSet<Category05> Categories05 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category06> Categories06 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category07> Categories07 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category08> Categories08 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category09> Categories09 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category10> Categories10 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category11> Categories11 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category12> Categories12 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category13> Categories13 { get; set; }

		protected override void OnConfiguring
			(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
		{
			var connectionString =
				"Server=.;Database=LEARNING_EF_CORE_0300;MultipleActiveResultSets=true;User ID=sa;Password=1234512345;";

			// UseSqlServer() -> using Microsoft.EntityFrameworkCore;
			optionsBuilder.UseSqlServer(connectionString: connectionString);
		}
	}
}
