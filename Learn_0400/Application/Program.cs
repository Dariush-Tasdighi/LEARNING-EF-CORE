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
			await CreateRoleAsync();
			// **************************************************

			// **************************************************
			await CreateUserAsync();
			// **************************************************

			// **************************************************
			await CreateSomeUserLoginsAsync();
			// **************************************************

			// **************************************************
			await DeleteUserAsync();
			// **************************************************
		}

		private static async System.Threading.Tasks.Task CreateRoleAsync()
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

				if (foundedRole != null)
				{
					System.Console.WriteLine
						(value: $"This role [{roleName}] already exists!");

					return;
				}

				var role =
					new Domain.Role(name: roleName)
					{
						IsActive = true,
					};

				var isValid =
					Domain.SeedWork.ValidationHelper.IsValid(entity: role);

				var results =
					Domain.SeedWork.ValidationHelper.GetValidationResults(entity: role);

				if (isValid)
				{
					var entityEntry =
						await
						databaseContext.AddAsync(entity: role);

					var affectedRows =
						await
						databaseContext.SaveChangesAsync();
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

		private static async System.Threading.Tasks.Task CreateUserAsync()
		{
			Data.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Data.DatabaseContext();

				//var defaultRole =
				//	await
				//	databaseContext.Roles
				//	.Where(current => current.Id == Domain.Role.DefaultRoleId)
				//	.FirstOrDefaultAsync();

				//if (defaultRole == null)
				//{
				//	System.Console.WriteLine
				//		(value: $"There is not any default role!");

				//	return;
				//}

				var emailAddress =
					"DariushTasdighi@GMail.com";

				var foundedUser =
					await
					databaseContext.Users
					.Where(current => current.EmailAddress.ToLower() == emailAddress.ToLower())
					.FirstOrDefaultAsync();

				if (foundedUser != null)
				{
					System.Console.WriteLine
						(value: $"This user [{emailAddress}] already exists!");

					return;
				}

				//var user =
				//	new Domain.User(emailAddress: emailAddress, roleId: Domain.Role.DefaultRoleId)

				var user =
					new Domain.User(emailAddress: emailAddress)
					{
						IsActive = true,
						IsEmailAddressVerified = true,

						CellPhoneNumber = "09121086174",

						Password =
							Dtat.Hashing.GetSha256(text: "1234512345"),
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
						await
						databaseContext.SaveChangesAsync();
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

		private static async System.Threading.Tasks.Task CreateSomeUserLoginsAsync()
		{
			Data.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Data.DatabaseContext();

				var emailAddress =
					"DariushTasdighi@GMail.com";

				var foundedUser =
					await
					databaseContext.Users
					.Where(current => current.EmailAddress.ToLower() == emailAddress.ToLower())
					.FirstOrDefaultAsync();

				if (foundedUser == null)
				{
					System.Console.WriteLine
						(value: $"There is not such as user [{emailAddress}]!");

					return;
				}

				for (int index = 1; index <= 5; index++)
				{
					var usesrIP =
						$"{index}.{index}.{index}.{index}";

					var userLogin =
						new Domain.UserLogin(userId: foundedUser.Id, userIP: usesrIP);

					var isValid =
						Domain.SeedWork.ValidationHelper.IsValid(entity: userLogin);

					var results =
						Domain.SeedWork.ValidationHelper.GetValidationResults(entity: userLogin);

					if (isValid)
					{
						var entityEntry =
							await
							databaseContext.AddAsync(entity: userLogin);

						var affectedRows =
							await
							databaseContext.SaveChangesAsync();
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

		private static async System.Threading.Tasks.Task DeleteUserAsync()
		{
			Data.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Data.DatabaseContext();

				var emailAddress =
					"DariushTasdighi@GMail.com";

				var foundedUser =
					await
					databaseContext.Users
					.Where(current => current.EmailAddress.ToLower() == emailAddress.ToLower())
					.FirstOrDefaultAsync();

				if (foundedUser == null)
				{
					System.Console.WriteLine
						(value: $"There is not such as user [{emailAddress}]!");

					return;
				}

				var entityEntry =
					databaseContext.Remove(entity: foundedUser);

				var affectedRows =
					await
					databaseContext.SaveChangesAsync();
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
