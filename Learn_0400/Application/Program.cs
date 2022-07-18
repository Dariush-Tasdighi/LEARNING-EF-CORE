﻿using System.Linq;
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
			await CreateRole01Async();
			// **************************************************
		}

		private static async System.Threading.Tasks.Task CreateRole01Async()
		{
			Data.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Data.DatabaseContext();

				var roleName = "مدیر";

				var foundedRole =
					await
					databaseContext.Roles
					.Where(current => current.Name.ToLower() == roleName.ToLower())
					.FirstOrDefaultAsync();

				if (foundedRole == null)
				{
					var user =
						new Domain.Role(name: "مدیر")
						{
							IsActive = true,
						};

					var isValid =
						Domain.SeedWork.ValidationHelper.IsValid(entity: user);

					var results =
						Domain.SeedWork.ValidationHelper.GetValidationResults(entity: user);

					if (isValid)
					{
						var entityEntry =
							await
							databaseContext.AddAsync(entity: user);

						var affectedRows =
							await databaseContext.SaveChangesAsync();
					}
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