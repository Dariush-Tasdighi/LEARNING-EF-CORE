// **************************************************
// Solution (0)
// **************************************************
//namespace Application
//{
//	internal static class Program : object
//	{
//		static Program()
//		{
//		}

//		private static void Main()
//		{
//			System.Console.WriteLine
//				(value: $"Max Value of 'int': {int.MaxValue:#,##0}");

//			System.Console.WriteLine
//				(value: $"Max Value of 'long': {long.MaxValue:#,##0}");
//		}
//	}
//}
// **************************************************
// /Solution (0)
// **************************************************

// **************************************************
// Solution (1)
// **************************************************
//namespace Application
//{
//	internal static class Program : object
//	{
//		static Program()
//		{
//		}

//		private static void Main()
//		{
//			CreateCategory();
//		}

//		/// <summary>
//		/// CRUD:
//		/// C -> Create | U -> Update | D -> Delete | R -> Retrieve
//		///
//		/// Retrieve:
//		///		Zero or One : FirstOrDefault()
//		///		Zero Or Many: ToList()
//		/// </summary>
//		private static void CreateCategory()
//		{
//			Models.DatabaseContext databaseContext = new Models.DatabaseContext();

//			Models.Category category = new Models.Category();

//			category.Name = "My Category";

//			databaseContext.Categories.Add(entity: category);

//			databaseContext.SaveChanges();
//		}
//	}
//}
// **************************************************
// /Solution (1)
// **************************************************

// **************************************************
// Solution (2)
// **************************************************
//namespace Application
//{
//	internal static class Program : object
//	{
//		static Program()
//		{
//		}

//		private static void Main()
//		{
//			CreateCategory();
//		}

//		private static void CreateCategory()
//		{
//			// **************************************************
//			//Models.DatabaseContext databaseContext = new Models.DatabaseContext();
//			var databaseContext = new Models.DatabaseContext();
//			// **************************************************

//			// **************************************************
//			//int x = 1;

//			//int x;
//			//x = 1;

//			//var x = 1;

//			//var x; // Compile Error!
//			//x = 1;

//			//var x = null; // Compile Error!
//			// **************************************************

//			// **************************************************
//			// **************************************************
//			// **************************************************
//			//Models.Category category = new Models.Category();

//			//category.Name = "My Category";
//			// **************************************************

//			// **************************************************
//			//Models.Category category =
//			//	new Models.Category() { Name = "My Category" };
//			// **************************************************

//			// **************************************************
//			//Models.Category category =
//			//	new Models.Category { Name = "My Category" };
//			// **************************************************

//			// **************************************************
//			//Models.Category category =
//			//	new() { Name = "My Category" };
//			// **************************************************

//			// **************************************************
//			//var category =
//			//	new Models.Category { Name = "My Category" };
//			// **************************************************

//			// **************************************************
//			//var category =
//			//	new Models.Category
//			//	{
//			//		Name = "My Category"
//			//	};
//			// **************************************************

//			// **************************************************
//			var category =
//				new Models.Category
//				{
//					Name = "My Category",
//				};
//			// **************************************************

//			databaseContext.Categories.Add(entity: category);

//			databaseContext.SaveChanges();
//		}
//	}
//}
// **************************************************
// /Solution (2)
// **************************************************

// **************************************************
// Solution (3)
// **************************************************
//namespace Application
//{
//	internal static class Program : object
//	{
//		static Program()
//		{
//		}

//		private static void Main()
//		{
//			CreateCategory();
//		}

//		private static void CreateCategory()
//		{
//			using (var databaseContext = new Models.DatabaseContext())
//			{
//				var category =
//					new Models.Category
//					{
//						Name = "My Category",
//					};

//				databaseContext.Categories.Add(entity: category);

//				databaseContext.SaveChanges();
//			}
//		}
//	}
//}
// **************************************************
// /Solution (3)
// **************************************************

// **************************************************
// Solution (4)
// **************************************************
//namespace Application
//{
//	internal static class Program : object
//	{
//		static Program()
//		{
//		}

//		private static void Main()
//		{
//			CreateCategory();
//		}

//		private static void CreateCategory()
//		{
//			using var databaseContext =
//				new Models.DatabaseContext();

//			var category =
//				new Models.Category
//				{
//					Name = "My Category",
//				};

//			databaseContext.Categories.Add(entity: category);

//			databaseContext.SaveChanges();
//		}
//	}
//}
// **************************************************
// /Solution (4)
// **************************************************

// **************************************************
// Solution (5)
// **************************************************
//namespace Application
//{
//	internal static class Program : object
//	{
//		static Program()
//		{
//		}

//		private static void Main()
//		{
//			CreateCategory();
//		}

//		private static void CreateCategory()
//		{
//			Models.DatabaseContext? databaseContext = null;

//			try
//			{
//				databaseContext =
//					new Models.DatabaseContext();

//				var category =
//					new Models.Category
//					{
//						Name = "My Category",
//					};

//				databaseContext.Categories.Add(entity: category);

//				databaseContext.SaveChanges();
//			}
//			catch (System.Exception ex)
//			{
//				// Log Error!

//				System.Console.WriteLine(value: ex.Message);
//			}
//			finally
//			{
//				if (databaseContext != null)
//				{
//					databaseContext.Dispose();
//					//databaseContext = null;
//				}
//			}
//		}
//	}
//}
// **************************************************
// /Solution (5)
// **************************************************

// **************************************************
// Solution (6)
// **************************************************
//namespace Application
//{
//	internal static class Program : object
//	{
//		static Program()
//		{
//		}

//		private static void Main()
//		{
//			CreateCategory();
//		}

//		private static void CreateCategory()
//		{
//			Models.DatabaseContext? databaseContext = null;

//			try
//			{
//				databaseContext =
//					new Models.DatabaseContext();

//				var category =
//					new Models.Category
//					{
//						Name = "My Category",
//					};

//				//databaseContext.Categories.Add(entity: category);

//				// Type: Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry
//				//var entityEntry =
//				//	databaseContext.Categories.Add(entity: category);

//				// New in EF Core
//				//databaseContext.Add(entity: category);

//				// New in EF Core
//				// Type: Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry
//				var entityEntry =
//					databaseContext.Add(entity: category);

//				// OR

//				entityEntry =
//					databaseContext.Entry(entity: category);

//				switch (entityEntry.State)
//				{
//					case Microsoft.EntityFrameworkCore.EntityState.Detached:
//					{
//						break;
//					}

//					case Microsoft.EntityFrameworkCore.EntityState.Unchanged:
//					{
//						break;
//					}

//					case Microsoft.EntityFrameworkCore.EntityState.Added:
//					{
//						break;
//					}

//					case Microsoft.EntityFrameworkCore.EntityState.Modified:
//					{
//						break;
//					}

//					case Microsoft.EntityFrameworkCore.EntityState.Deleted:
//					{
//						break;
//					}
//				}

//				int id =
//					category.Id;

//				// خطا می‌دهد EF Core در
//				// مشکلی نداشت و صرفا توجهی به مقدار ما نمی‌کرد EF ولی در
//				//category.Id = 12345;

//				databaseContext.SaveChanges();

//				//var affectedRows =
//				//	databaseContext.SaveChanges();

//				id =
//					category.Id;
//			}
//			catch (System.Exception ex)
//			{
//				// Log Error!

//				//ex.InnerException.Message

//				// Cannot insert explicit value for identity column
//				// in table 'Categories' when IDENTITY_INSERT is set
//				// to OFF.

//				System.Console.WriteLine(value: ex.Message);
//			}
//			finally
//			{
//				if (databaseContext != null)
//				{
//					databaseContext.Dispose();
//				}
//			}
//		}
//	}
//}
// **************************************************
// /Solution (6)
// **************************************************

// **************************************************
// Solution (7)
// **************************************************
//namespace Application
//{
//	internal static class Program : object
//	{
//		static Program()
//		{
//		}

//		// Note: 'MainAsync' does not work!
//		//public static async System.Threading.Tasks.Task MainAsync()
//		public static async System.Threading.Tasks.Task Main()
//		{
//			await CreateCategoryAsync();
//		}

//		private static async System.Threading.Tasks.Task CreateCategoryAsync()
//		{
//			Models.DatabaseContext? databaseContext = null;

//			try
//			{
//				databaseContext =
//					new Models.DatabaseContext();

//				var category =
//					new Models.Category
//					{
//						Name = "My Category",
//					};

//				var entityEntry =
//					databaseContext.Add(entity: category);

//				// New in EF Core
//				var affectedRows =
//					await
//					databaseContext.SaveChangesAsync();

//				System.Console.WriteLine
//					(value: $"{nameof(affectedRows)}: {affectedRows}");
//			}
//			catch (System.Exception ex)
//			{
//				// Log Error!

//				System.Console.WriteLine(value: ex.Message);
//			}
//			finally
//			{
//				if (databaseContext != null)
//				{
//					//databaseContext.Dispose();
//					await databaseContext.DisposeAsync();
//				}
//			}
//		}
//	}
//}
// **************************************************
// /Solution (7)
// **************************************************

// **************************************************
// Solution (8)
// **************************************************
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Application
{
	internal static class Program : object
	{
		static Program()
		{
		}

		public static async System.Threading.Tasks.Task Main()
		{
			await CreateCategoryAsync();
			await DisplayCategoriesAsync();
		}

		private static async System.Threading.Tasks.Task CreateCategoryAsync()
		{
			Models.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				var category =
					new Models.Category
					{
						Name = "My Category",
					};

				var entityEntry =
					databaseContext.Add(entity: category);

				var affectedRows =
					await databaseContext.SaveChangesAsync();
			}
			catch (System.Exception ex)
			{
				// Log Error!

				System.Console.WriteLine(value: ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					await databaseContext.DisposeAsync();
				}
			}
		}

		private static async System.Threading.Tasks.Task DisplayCategoriesAsync()
		{
			Models.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// **************************************************
				// **************************************************
				// **************************************************
				//var categories =
				//	databaseContext.Categories.ToList();
				// **************************************************

				// **************************************************
				//var categories =
				//	databaseContext.Categories
				//	// ToList() -> using System.Linq;
				//	.ToList()
				//	;
				// **************************************************

				// **************************************************
				//var categories =
				//	await
				//	databaseContext.Categories
				//	// New in EF Core
				//	// ToListAsync() -> using Microsoft.EntityFrameworkCore;
				//	.ToListAsync()
				//	;
				// **************************************************
				// SELECT * FROM Categories
				// **************************************************

				// **************************************************
				//var categories =
				//	await
				//	databaseContext.Categories
				//	// Where() -> using System.Linq
				//	.Where(current => current.Id <= 100)
				//	.ToListAsync()
				//	;
				// **************************************************
				// SELECT * FROM Categories WHERE Id <= 100
				// **************************************************

				// **************************************************
				//var categories =
				//	await
				//	databaseContext.Categories
				//	// OrderBy() -> using System.Linq
				//	.OrderBy(current => current.Id)
				//	.ToListAsync()
				//	;
				// **************************************************
				// SELECT * FROM Categories ORDER BY Name
				// OR
				// SELECT * FROM Categories ORDER BY Name ASC
				// **************************************************

				// **************************************************
				//var categories =
				//	await
				//	databaseContext.Categories
				//	// OrderByDescending() -> using System.Linq
				//	.OrderByDescending(current => current.Id)
				//	.ToListAsync()
				//	;
				// **************************************************
				// SELECT * FROM Categories ORDER BY Name DESC
				// **************************************************

				// **************************************************
				// اهمیت داشت، ولی در این نسخه اهمیتی ندارد Where and OrderBy در نسخه قدیم ترتیب نوشتن
				// ولی اصولا عادت کنید که به شکل و به ترتیب ذیل بنویسید
				// **************************************************
				var categories =
					await
					databaseContext.Categories
					.Where(current => current.Id <= 100)
					.OrderBy(current => current.Id)
					.ToListAsync()
					;

				foreach (var item in categories)
				{
					string message =
						$"Id: {item.Id} - Name: {item.Name}";

					System.Console.WriteLine(value: message);
				}
				// **************************************************
				// SELECT * FROM Categories WHERE Id <= 100 ORDER BY Name
				// **************************************************
				// **************************************************
				// **************************************************

				// **************************************************
				//string? name = "My Category";
				// **************************************************

				// **************************************************
				// **************************************************
				// **************************************************
				//var categories =
				//	await
				//	databaseContext.Categories
				//	.Where(current => current.Name == name)
				//	.ToListAsync()
				//	;
				// **************************************************
				// SELECT * FROM Categories WHERE Name = 'My Category'
				// **************************************************

				// **************************************************
				// کلاسیک کار می‌کرد ولی در نسخه جدید کار نمی‌کند EF دقت کنید که دستور ذیل در نسخه
				// از آن استفاده نمی‌کنیم EF Core لذا در نسخه
				//var categories =
				//	await
				//	databaseContext.Categories
				//	.Where(current => string.Compare(current.Name, name, true) == 0)
				//	.ToListAsync()
				//	;
				// **************************************************

				// **************************************************
				// باشد به خطا خواهد خورد null ،name دستور ذیل در شرایطی که
				//var categories =
				//	await
				//	databaseContext.Categories
				//	.Where(current => current.Name!.ToLower() == name.ToLower())
				//	.ToListAsync()
				//	;
				// **************************************************

				// **************************************************
				//if (name != null)
				//{
				//	var categories =
				//		await
				//		databaseContext.Categories
				//		.Where(current => current.Name!.ToLower() == name.ToLower())
				//		.ToListAsync()
				//		;
				//}
				// **************************************************
				// **************************************************
				// **************************************************

				// **************************************************
				//name = "My";

				//if (name != null)
				//{
				//	var categories =
				//		await
				//		databaseContext.Categories
				//		.Where(current => current.Name!.ToLower().StartsWith(name.ToLower()))
				//		.ToListAsync()
				//		;

				//	foreach (var item in categories)
				//	{
				//		string message =
				//			$"Id: {item.Id} - Name: {item.Name}";

				//		System.Console.WriteLine(value: message);
				//	}
				//}
				// **************************************************
				// SELECT * FROM Categories WHERE Name LIKE 'My%'
				// **************************************************

				// **************************************************
				//name = "Category";

				//if (name != null)
				//{
				//	var categories =
				//		await
				//		databaseContext.Categories
				//		.Where(current => current.Name!.ToLower().EndsWith(name.ToLower()))
				//		.ToListAsync()
				//		;

				//	foreach (var item in categories)
				//	{
				//		string message =
				//			$"Id: {item.Id} - Name: {item.Name}";

				//		System.Console.WriteLine(value: message);
				//	}
				//}
				// **************************************************
				// SELECT * FROM Categories WHERE Name LIKE '%Category'
				// **************************************************

				// **************************************************
				//name = "Gory";

				//if (name != null)
				//{
				//	var categories =
				//		await
				//		databaseContext.Categories
				//		.Where(current => current.Name!.ToLower().Contains(name.ToLower()))
				//		.ToListAsync()
				//		;

				//	foreach (var item in categories)
				//	{
				//		string message =
				//			$"Id: {item.Id} - Name: {item.Name}";

				//		System.Console.WriteLine(value: message);
				//	}
				//}
				// **************************************************
				// SELECT * FROM Categories WHERE Name LIKE '%Gory%'
				// **************************************************
			}
			catch (System.Exception ex)
			{
				// Log Error!

				System.Console.WriteLine(value: ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					await databaseContext.DisposeAsync();
				}
			}
		}
	}
}
// **************************************************
// /Solution (8)
// **************************************************

// **************************************************
// Solution (9)
// **************************************************
//using System.Linq;
//using Microsoft.EntityFrameworkCore;

//namespace Application
//{
//	internal static class Program : object
//	{
//		static Program()
//		{
//		}

//		public static async System.Threading.Tasks.Task Main()
//		{
//			await CreateCategoryAsync();
//			await DisplayCategoriesAsync();

//			// New
//			await UpdateTheFirstCategoryAsync();

//			await DisplayCategoriesAsync();

//			// New
//			await UpdateSomeCategoriesAsync();

//			await DisplayCategoriesAsync();

//			// New
//			await DeleteTheFirstCategoryAsync();

//			await DisplayCategoriesAsync();

//			// New
//			await DeleteAllCategoriesAsync();

//			await DisplayCategoriesAsync();
//		}

//		private static async System.Threading.Tasks.Task CreateCategoryAsync()
//		{
//			Models.DatabaseContext? databaseContext = null;

//			try
//			{
//				databaseContext =
//					new Models.DatabaseContext();

//				var category =
//					new Models.Category
//					{
//						Name = "My Category",
//					};

//				var entityEntry =
//					databaseContext.Add(entity: category);

//				var affectedRows =
//					await databaseContext.SaveChangesAsync();
//			}
//			catch (System.Exception ex)
//			{
//				// Log Error!

//				System.Console.WriteLine(value: ex.Message);
//			}
//			finally
//			{
//				if (databaseContext != null)
//				{
//					await databaseContext.DisposeAsync();
//				}
//			}
//		}

//		private static async System.Threading.Tasks.Task DisplayCategoriesAsync()
//		{
//			Models.DatabaseContext? databaseContext = null;

//			try
//			{
//				databaseContext =
//					new Models.DatabaseContext();

//				var categories =
//					await
//					databaseContext.Categories
//					.Where(current => current.Id <= 100)
//					.OrderBy(current => current.Id)
//					.ToListAsync()
//					;

//				foreach (var item in categories)
//				{
//					string message =
//						$"Id: {item.Id} - Name: {item.Name}";

//					System.Console.WriteLine(value: message);
//				}
//			}
//			catch (System.Exception ex)
//			{
//				// Log Error!

//				System.Console.WriteLine(value: ex.Message);
//			}
//			finally
//			{
//				if (databaseContext != null)
//				{
//					await databaseContext.DisposeAsync();
//				}
//			}
//		}

//		/// <summary>
//		/// New
//		/// </summary>
//		private static async System.Threading.Tasks.Task UpdateTheFirstCategoryAsync()
//		{
//			Models.DatabaseContext? databaseContext = null;

//			try
//			{
//				databaseContext =
//					new Models.DatabaseContext();

//				//var category =
//				//	databaseContext.Categories
//				//	.FirstOrDefault();

//				// New in EF Core
//				//var category =
//				//	await
//				//	databaseContext.Categories
//				//	.FirstOrDefaultAsync();

//				// خیلی توصیه نمی‌کنم
//				//var category =
//				//	await
//				//	databaseContext.Categories
//				//	.FirstOrDefaultAsync(current => current.Id <= 100);

//				//var category =
//				//	await
//				//	databaseContext.Categories
//				//	.Where(current => current.Id <= 100)
//				//	.FirstOrDefaultAsync();

//				var category =
//					await
//					databaseContext.Categories
//					.Where(current => current.Id <= 100)
//					.OrderBy(current => current.Id)
//					.FirstOrDefaultAsync();

//				if (category == null)
//				{
//					System.Console.WriteLine
//						(value: "There is not any category!");

//					return;
//				}

//				category.Name =
//					$"{category.Name}_{category.Id}";

//				var affectedRows =
//					await databaseContext.SaveChangesAsync();

//				//var theCategory =
//				//	databaseContext.Categories
//				//	.LastOrDefault();

//				// New in EF Core
//				//var theCategory =
//				//	await
//				//	databaseContext.Categories
//				//	.LastOrDefaultAsync();

//				// اگر چند تا پیدا کند، اولین آن را برمی‌گرداند
//				// ولی اگر پیدا نکند خطا می‌دهد
//				//var theCategory =
//				//	databaseContext.Categories
//				//	.First();

//				// New in EF Core
//				//var theCategory =
//				//	await
//				//	databaseContext.Categories
//				//	.FirstAsync();

//				// اگر چند تا پیدا کند، آخرین آن را برمی‌گرداند
//				// ولی اگر پیدا نکند خطا می‌دهد
//				//var theCategory =
//				//	databaseContext.Categories
//				//	.Last();

//				// New in EF Core
//				//var theCategory =
//				//	databaseContext.Categories
//				//	.LastAsync();

//				// اگر فقط یکی پیدا کند، آن‌را برمی‌گرداند
//				// اگر چند تا پیدا کند، خطا می‌دهد
//				// اگر هم پیدا نکند، خطا می‌دهد
//				//var theCategory =
//				//	databaseContext.Categories
//				//	.Single();

//				// New in EF Core
//				//var theCategory =
//				//	databaseContext.Categories
//				//	.SingleAsync();

//				// اگر فقط یکی پیدا کند، آن‌را برمی‌گرداند
//				// اگر پیدا نکند، نال برمی‌گرداند
//				// اگر چند تا پیدا کند، خطا می‌دهد
//				//var theCategory =
//				//	databaseContext.Categories
//				//	.SingleOrDefault();

//				// New in EF Core
//				//var theCategory =
//				//	databaseContext.Categories
//				//	.SingleOrDefaultAsync();
//			}
//			catch (System.Exception ex)
//			{
//				// Log Error!

//				System.Console.WriteLine(value: ex.Message);
//			}
//			finally
//			{
//				if (databaseContext != null)
//				{
//					await databaseContext.DisposeAsync();
//				}
//			}
//		}

//		/// <summary>
//		/// New
//		/// </summary>
//		private static async System.Threading.Tasks.Task UpdateSomeCategoriesAsync()
//		{
//			Models.DatabaseContext? databaseContext = null;

//			try
//			{
//				databaseContext =
//					new Models.DatabaseContext();

//				var categories =
//					await
//					databaseContext.Categories
//					.Where(current => current.Id <= 100)
//					.OrderBy(current => current.Id)
//					.ToListAsync();

//				foreach (var item in categories)
//				{
//					item.Name =
//						$"{item.Name}_{item.Id}";

//					//var affectedRows =
//					//	await databaseContext.SaveChangesAsync();
//				}

//				var affectedRows =
//					await databaseContext.SaveChangesAsync();
//			}
//			catch (System.Exception ex)
//			{
//				// Log Error!

//				System.Console.WriteLine(value: ex.Message);
//			}
//			finally
//			{
//				if (databaseContext != null)
//				{
//					await databaseContext.DisposeAsync();
//				}
//			}
//		}

//		/// <summary>
//		/// New
//		/// </summary>
//		private static async System.Threading.Tasks.Task DeleteTheFirstCategoryAsync()
//		{
//			Models.DatabaseContext? databaseContext = null;

//			try
//			{
//				databaseContext =
//					new Models.DatabaseContext();

//				var category =
//					await
//					databaseContext.Categories
//					.Where(current => current.Id <= 100)
//					.OrderBy(current => current.Id)
//					.FirstOrDefaultAsync();

//				if (category == null)
//				{
//					System.Console.WriteLine
//						(value: "There is not any category!");

//					return;
//				}

//				databaseContext.Categories.Remove(entity: category);

//				//var entityEntry =
//				//	databaseContext.Categories.Remove(entity: category);

//				//databaseContext.Categories.RemoveRange(entities: category);

//				// دقت کنید که تابع ذیل، خروجی ندارد
//				//databaseContext.Categories.RemoveRange(entities: category);

//				// New in .NET Core
//				//databaseContext.Remove(entity: category);

//				// New in .NET Core
//				//var entityEntry =
//				//	databaseContext.Remove(entity: category);

//				// New in .NET Core
//				// دقت کنید که تابع ذیل، خروجی ندارد
//				//databaseContext.RemoveRange(entities: category);

//				var affectedRows =
//					await databaseContext.SaveChangesAsync();
//			}
//			catch (System.Exception ex)
//			{
//				// Log Error!

//				System.Console.WriteLine(value: ex.Message);
//			}
//			finally
//			{
//				if (databaseContext != null)
//				{
//					await databaseContext.DisposeAsync();
//				}
//			}
//		}

//		/// <summary>
//		/// New
//		/// </summary>
//		private static async System.Threading.Tasks.Task DeleteAllCategoriesAsync()
//		{
//			Models.DatabaseContext? databaseContext = null;

//			try
//			{
//				databaseContext =
//					new Models.DatabaseContext();

//				var categories =
//					await
//					databaseContext.Categories
//					.ToListAsync()
//					;

//				// **************************************************
//				// **************************************************
//				// **************************************************
//				foreach (var item in categories)
//				{
//					databaseContext.Categories.Remove(item);

//					//var affectedRows =
//					//	await databaseContext.SaveChangesAsync();
//				}
//				// **************************************************

//				// OR

//				// **************************************************
//				//databaseContext.RemoveRange(entities: categories);
//				// **************************************************

//				// OR

//				// **************************************************
//				//databaseContext.Categories.RemoveRange(entities: categories);
//				// **************************************************
//				// **************************************************
//				// **************************************************

//				var affectedRows =
//					await databaseContext.SaveChangesAsync();
//			}
//			catch (System.Exception ex)
//			{
//				// Log Error!

//				System.Console.WriteLine(value: ex.Message);
//			}
//			finally
//			{
//				if (databaseContext != null)
//				{
//					await databaseContext.DisposeAsync();
//				}
//			}
//		}
//	}
//}
// **************************************************
// /Solution (9)
// **************************************************
