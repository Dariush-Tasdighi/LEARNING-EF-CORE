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
	Dtat
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
	->

	Role.cs
	User.cs
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
			- We use Fluent API for indexing instead of 'Index' attribute!
**************************************************

**************************************************
**************************************************
*** Session 20 ***********************************
**************************************************
**************************************************
1- Fluent API
	- In 'Data' class library:
		- DatabaseContext
			- DbSet<Domain.Role> Roles { get; set; }
			- OnModelCreating
		- In 'Configurations' Folder:
			- RoleConfiguration.cs
				- 'Index' Techniques
				- 'One To Many' Techniques
					- Convention Naming in two Models (Navigation Properties)
					- HasMany
					- WithOne
					- HasForeignKey
					- OnDelete
				- Seed Data with 'HasData'
2- In 'Application' project:
	- Program.cs
**************************************************
Convention Naming in two Models (Navigation Properties):

[Role]					[User]

Guid Id					Guid Id
						Guid RoleId

IList<User> Users		Role Role
**************************************************
ادامه دوره

ASP.NET Core Razor Pages: CRUD Template
ASP.NET Core Security   : User And The Other Models
**************************************************

**************************************************
**************************************************
*** Session 21 ***********************************
**************************************************
**************************************************
1- Role.cs

	- DefaultRoleId

	- Constructor

		//SetUpdateDateTime();
		UpdateDateTime = InsertDateTime;

2- User.cs

	// **********
	- SuperUserId
	// **********

	// **********
	- Constructor

		UserLogins =
			new System.Collections.Generic.List<UserLogin>();
	// **********

	// **********
	// نکته مهم: نباید دستور ذیل نوشته شود
	//[System.ComponentModel.DataAnnotations.Required
	//	(ErrorMessageResourceType = typeof(Resources.Messages.Validations),
	//	ErrorMessageResourceName = nameof(Resources.Messages.Validations.Required))]
	public virtual Role? Role { get; set; }
	// **********

	// **********
	public bool IsProgrammer { get; set; }
	// **********

	// **********
	public bool IsProfilePublic { get; set; }
	// **********

	// **********
	Note: Username is nullable!
	Note: Password is nullable!
	// **********

	// **********
	[System.ComponentModel.DataAnnotations.MinLength
		(length: SeedWork.Constant.FixedLength.DatabasePassword,
		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
		ErrorMessageResourceName = nameof(Resources.Messages.Validations.MinLength))]

	[System.ComponentModel.DataAnnotations.MaxLength
		(length: SeedWork.Constant.FixedLength.DatabasePassword,
		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
		ErrorMessageResourceName = nameof(Resources.Messages.Validations.MaxLength))]

	// نکته مهم: دستور ذیل نباید نوشته شود
	// ها می‌باشد ViewModel دستور ذیل مربوط به
	//[System.ComponentModel.DataAnnotations.RegularExpression
	//	(pattern: SeedWork.Constant.RegularExpression.Password,
	//	ErrorMessageResourceType = typeof(Resources.Messages.Validations),
	//	ErrorMessageResourceName = nameof(Resources.Messages.Validations.Password))]
	public string? Password { get; set; }
	// **********

	// **********
	[System.ComponentModel.DataAnnotations.RegularExpression
		(pattern: SeedWork.Constant.RegularExpression.EmailAddress,
		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
		ErrorMessageResourceName = nameof(Resources.Messages.Validations.EmailAddress))]
	public string EmailAddress { get; set; }
	// **********

	// **********
	public System.Guid EmailAddressVerificationKey { get; [private] set; }
	// **********

	// **********
	[System.ComponentModel.DataAnnotations.MaxLength
		(length: SeedWork.Constant.FixedLength.CellPhoneNumber,
		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
		ErrorMessageResourceName = nameof(Resources.Messages.Validations.MaxLength))]

	[System.ComponentModel.DataAnnotations.RegularExpression
		(pattern: SeedWork.Constant.RegularExpression.CellPhoneNumber,
		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
		ErrorMessageResourceName = nameof(Resources.Messages.Validations.CellPhoneNumber))]
	public string? CellPhoneNumber { get; set; }
	// **********

	// **********
	[System.ComponentModel.DataAnnotations.MinLength
		(length: SeedWork.Constant.MinLength.CellPhoneNumberVerificationKey,
		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
		ErrorMessageResourceName = nameof(Resources.Messages.Validations.MinLength))]

	[System.ComponentModel.DataAnnotations.MaxLength
		(length: SeedWork.Constant.MaxLength.CellPhoneNumberVerificationKey,
		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
		ErrorMessageResourceName = nameof(Resources.Messages.Validations.MaxLength))]
	public string? CellPhoneNumberVerificationKey { get; private set; }
	// **********

	// **********
	public virtual System.Collections.Generic.IList<UserLogin> UserLogins { get; private set; }
	// **********

3- UserConfiguration.cs

	// **********
	- Index / Unique null fields!
	// **********

	// **********
	Password =
		Dtat.Hashing.GetSha256(text: "1234512345"),
	// **********

4- UserLogin.cs

5- UserLoginConfiguration.cs

6- DatabaseContext.cs

		public Microsoft.EntityFrameworkCore.DbSet<Domain.User> Users { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Domain.UserLogin> UserLogins { get; set; }

7- Program.cs
**************************************************
