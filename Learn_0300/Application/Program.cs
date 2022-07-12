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
			// **************************************************
			await CreateCategoryAsync();

			await DisplayCategoriesAsync();

			await UpdateTheFirstCategoryAsync();

			await DisplayCategoriesAsync();

			await UpdateSomeCategoriesAsync();

			await DisplayCategoriesAsync();

			await DeleteTheFirstCategoryAsync();

			await DisplayCategoriesAsync();

			await DeleteSomeCategoriesAsync();

			await DisplayCategoriesAsync();
			// **************************************************

			// **************************************************
			await CreateCategory13Async();

			await DisplayCategories13Async();
			// **************************************************

			// **************************************************
			await CreateCategory21Async();
			// **************************************************

			// **************************************************
			await CreateCategory23Async();
			// **************************************************

			// **************************************************
			await CreateCategory25Async();
			// **************************************************

			// **************************************************
			await CreateUser03Async();
			// **************************************************

			// **************************************************
			await CreateUser04Async();
			// **************************************************

			// **************************************************
			await CreateUser05Async();
			// **************************************************
		}

		private static async System.Threading.Tasks.Task CreateCategoryAsync()
		{
			Models.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				var category =
					new Models.Category01
					{
						Name = "My Category",
					};

				var entityEntry =
					await databaseContext.AddAsync(entity: category);

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

				var categories =
					await
					databaseContext.Categories01
					.Where(predicate: current => current.Id <= 100)
					.OrderBy(keySelector: current => current.Id)
					.ToListAsync()
					;

				foreach (var item in categories)
				{
					string message =
						$"Id: {item.Id} - Name: {item.Name}";

					System.Console.WriteLine(value: message);
				}
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

		private static async System.Threading.Tasks.Task UpdateTheFirstCategoryAsync()
		{
			Models.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				var category =
					await
					databaseContext.Categories01
					.Where(predicate: current => current.Id <= 100)
					.OrderBy(keySelector: current => current.Id)
					.FirstOrDefaultAsync();

				if (category == null)
				{
					System.Console.WriteLine
						(value: "There is not any category!");

					return;
				}

				category.Name =
					$"{category.Name}_{category.Id}";

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

		private static async System.Threading.Tasks.Task UpdateSomeCategoriesAsync()
		{
			Models.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				var categories =
					await
					databaseContext.Categories01
					.Where(predicate: current => current.Id <= 100)
					.OrderBy(keySelector: current => current.Id)
					.ToListAsync();

				foreach (var item in categories)
				{
					item.Name =
						$"{item.Name}_{item.Id}";
				}

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

		private static async System.Threading.Tasks.Task DeleteTheFirstCategoryAsync()
		{
			Models.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				var category =
					await
					databaseContext.Categories01
					.Where(predicate: current => current.Id <= 100)
					.OrderBy(keySelector: current => current.Id)
					.FirstOrDefaultAsync();

				if (category == null)
				{
					System.Console.WriteLine
						(value: "There is not any category!");

					return;
				}

				var entityEntry =
					databaseContext.Remove(entity: category);

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

		private static async System.Threading.Tasks.Task DeleteSomeCategoriesAsync()
		{
			Models.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				var categories =
					await
					databaseContext.Categories01
					.ToListAsync()
					;

				databaseContext.RemoveRange(entities: categories);

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



		private static async System.Threading.Tasks.Task CreateCategory13Async()
		{
			Models.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				var category =
					new Models.Category13(name: "My Category");

				var entityEntry =
					await
					databaseContext.AddAsync(entity: category);

				int affectedRows =
					await databaseContext.SaveChangesAsync();

				var id =
					category.Id;
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

		private static async System.Threading.Tasks.Task DisplayCategories13Async()
		{
			Models.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				var categories =
					await
					databaseContext.Categories13
					.Where(current => current.Id <= 100)
					.OrderBy(current => current.Id)
					.ToListAsync()
					;

				System.Console.WriteLine
					(value: $"{nameof(DisplayCategories13Async)}:");

				foreach (var item in categories)
				{
					string message =
						$"Id: {item.Id} - Name: {item.Name}";

					System.Console.WriteLine(value: message);
				}
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



		private static async System.Threading.Tasks.Task CreateCategory21Async()
		{
			Models.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				var category =
					new Models.Category21(name: "My Category");

				var id = category.Id;

				var entityEntry =
					await
					databaseContext.AddAsync(entity: category);

				// آی‌دی را محاسبه کرده و ارسال می‌کند SaveChanges دقت کنید که قبل از
				id = category.Id;

				int affectedRows =
					await databaseContext.SaveChangesAsync();

				id = category.Id;
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



		private static async System.Threading.Tasks.Task CreateCategory23Async()
		{
			Models.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				var category =
					new Models.Category23(name: "My Category");

				var id = category.Id;
				var code = category.Code;

				var entityEntry =
					await
					databaseContext.AddAsync(entity: category);

				id = category.Id;

				// صدق نمی‌کند Code دقت کنید که نکته تابع قبل در خصوص
				code = category.Code;

				int affectedRows =
					await databaseContext.SaveChangesAsync();

				id = category.Id;
				code = category.Code;
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



		private static async System.Threading.Tasks.Task CreateCategory25Async()
		{
			Models.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				var category =
					new Models.Category25(name: "My Category");

				var entityEntry =
					await
					databaseContext.AddAsync(entity: category);

				int affectedRows =
					await databaseContext.SaveChangesAsync();

				var id = category.Id;
				var code = category.Code;

				var displayName =
					category.DisplayName;

				var insertPersianDate =
					category.InsertPersianDate;

				var insertPersianDateTime =
					category.InsertPersianDateTime;
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



		private static async System.Threading.Tasks.Task CreateUser03Async()
		{
			Models.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				var user =
					new Models.User03(username: "dariush_0123456789_0123456789")
					{
						Ordering = -10,
						FirstName = "Dariush_0123456789_0123456789",
						LastName = "Tasdighi_0123456789_0123456789_0123456789",
					};

				var isValid =
					Models.ValidationHelper.IsValid(entity: user);

				var results =
					Models.ValidationHelper.GetValidationResults(entity: user);

				// The field Ordering must be between 1 and 100000.
				// The field Username must be a string or array type with a maximum length of '20'.
				// The field FirstName must be a string or array type with a maximum length of '20'.
				// The field LastName must be a string or array type with a maximum length of '30'.

				if (isValid)
				{
					var entityEntry =
						await
						databaseContext.AddAsync(entity: user);

					int affectedRows =
						await databaseContext.SaveChangesAsync();
				}
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



		private static async System.Threading.Tasks.Task CreateUser04Async()
		{
			Models.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				var user =
					new Models.User04(username: "dariush_0123456789_0123456789")
					{
						Ordering = -10,
						FirstName = "Dariush_0123456789_0123456789",
						LastName = "Tasdighi_0123456789_0123456789_0123456789",
					};

				var isValid =
					Models.ValidationHelper.IsValid(entity: user);

				var results =
					Models.ValidationHelper.GetValidationResults(entity: user);

				// The field Ordering must be between 1 and 100000.
				// ->
				// The Ordering value should be between 1 and 100000!

				// The field Username must be a string or array type with a maximum length of '20'.

				// The field FirstName must be a string or array type with a maximum length of '20'.
				// ->
				// The First Name value must be a string with a maximum length of '20'!

				// The field LastName must be a string or array type with a maximum length of '30'.

				if (isValid)
				{
					var entityEntry =
						await
						databaseContext.AddAsync(entity: user);

					int affectedRows =
						await databaseContext.SaveChangesAsync();
				}
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



		private static async System.Threading.Tasks.Task CreateUser05Async()
		{
			//var cultureInfo =
			//	new System.Globalization.CultureInfo(name: "en-US");

			var cultureInfo =
				new System.Globalization.CultureInfo(name: "fa-IR");

			System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
			System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;

			Models.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				//var user =
				//	new Models.User05(username: null)

				var user =
					new Models.User05(username: "dariush_0123456789_0123456789")
					{
						Ordering = -10,
						FirstName = "Dariush_0123456789_0123456789",
						LastName = "Tasdighi_0123456789_0123456789_0123456789",
					};

				var isValid =
					Models.ValidationHelper.IsValid(entity: user);

				var results =
					Models.ValidationHelper.GetValidationResults(entity: user);

				// مقدار فیلد 'چیدمان' باید بین '1' و '100000' باشد
				// تکمیل فیلد 'شناسه‌کاربری' الزامی است
				// طول متن فیلد 'نام' باید حداکثر '20' کاراکتر باشد
				// طول متن فیلد 'نام خانوادگی' باید حداکثر '30' کاراکتر باشد

				if (isValid)
				{
					var entityEntry =
						await
						databaseContext.AddAsync(entity: user);

					int affectedRows =
						await databaseContext.SaveChangesAsync();
				}
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
