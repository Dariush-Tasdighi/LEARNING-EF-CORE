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

		public Microsoft.EntityFrameworkCore.DbSet<Category14> Categories14 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category15> Categories_15 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category16> Categories16 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category17> Categories17 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category18> Categories18 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category19> Categories19 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category20> Categories20 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category21> Categories21 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category22> Categories22 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category23> Categories23 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category24> Categories24 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category25> Categories25 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category26> Categories26 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Category27> Categories27 { get; set; }

		//public Microsoft.EntityFrameworkCore.DbSet<UserInGroup01> UsersInGroups01 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<UserInGroup02> UsersInGroups02 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<User01> Users01 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<User02> Users02 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<User03> Users03 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<User04> Users04 { get; set; }

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
