// **************************************************
// Solution (9)
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
	}
}
// **************************************************
// /Solution (1)
// **************************************************
