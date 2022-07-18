**************************************************
**************************************************
*** Session 19 ***********************************
**************************************************
**************************************************

**************************************************
*** (1) ******************************************
**************************************************
References:
**************************************************
Domain (Models)
	Dtat
	Resources

	Nuget(s): -

Data (DAL, Dal, DataAccess, Data, Persistence)

	Domain

	Nuget(s):
		Microsoft.EntityFrameworkCore.SqlServer

Application

	Data
	Domain
	Resources

	Nuget(s):
		Microsoft.EntityFrameworkCore.SqlServer
**************************************************

**************************************************
*** (2) ******************************************
**************************************************
Domain (Class Library)

	Aggregates (Folder)

		Roles (Folder)

			Role.cs (Aggregate Root)

		Users (Folder)

			User.cs (Aggregate Root)
**************************************************

**************************************************
*** (3) ******************************************
**************************************************
3.1- SeedWork (Base)
3.2- IEntity.cs
3.3- Entity.cs
		- abstract
		- Id { get; [protected] set; }
		- InsertDateTime { get; [private] set; }
3.4- IEntity...cs
3.5- ValidationHelper.cs
3.6- Role.cs
		- region / endregion
		- Constructor: Role(string name)
		- UpdateDateTime { get; private set; }
		- SetId(System.Guid id) -> برای اطلاعات اولیه
			- Seed
		- IList<User> Users { get; private set; }
			- Navigation Property
			- 'new' in Constructor!
			- Relation One to Many (Role -> User)
			- public static readonly System.Guid UserRoleId =
				new(g: "2A533503-E7E1-4E08-98DD-33973A69AE15");
			- We do not use 'Index' attribute! Instead we use in Fluent API
3.7- Fluent API
	- In 'Data' class library:
		- DatabaseContext
			- DbSet<Domain.Role> Roles { get; set; }
			- OnModelCreating
		- In 'Configurations' Folder:
			- RoleConfiguration.cs
				- 'Index' Techniques
				- 'One To Many' Techniques
				- Seed Data with 'HasData'
3.8- In 'Application' project:
	- Program.cs
**************************************************
