namespace Models
{
	/// <summary>
	/// POCO -> Plain Old CLR Objects
	/// </summary>
	public class Category : object
	//public class Category : Base.Entity, IHasIsActive
	{
		public Category() : base()
		{
		}

		// **********
		public int Id { get; set; }

		//public long Id { get; set; }

		//public System.Guid Id { get; set; }
		// **********

		// **********
		public string? Name { get; set; }
		// **********
	}
}
