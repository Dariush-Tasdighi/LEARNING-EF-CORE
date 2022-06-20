**************************************************
https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/

Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 6.0.6

Install-Package Microsoft.EntityFrameworkCore.SqlServer

<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.6" />
**************************************************

**************************************************
protected override void OnConfiguring
	(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
{
}
**************************************************

**************************************************
https://www.connectionstrings.com/sql-server/

Server=.;Database=LEARNING_EF_CORE_0200;MultipleActiveResultSets=true;Trusted_Connection=True;

Server=.;Database=LEARNING_EF_CORE_0200;MultipleActiveResultSets=true;User ID=sa;Password=1234512345;

Connect Timeout or Connection Timeout: Default (15 Seconds)
**************************************************

**************************************************
Database.EnsureDeleted();

Note: Should be before 'OnConfiguring' method!
**************************************************
