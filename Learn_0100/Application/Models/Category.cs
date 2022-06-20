//namespace Application.Models
namespace Models
{
	public class Category : object
	{
		public Category() : base()
		{
		}

		// **********
		public int Id { get; set; }
		//public int ID { get; set; }

		//public int CategoryId { get; set; }

		//public int CategoryID { get; set; }

		//[System.ComponentModel.DataAnnotations.Key]
		//public int Key { get; set; }
		// **********

		// **********
		public string? Name { get; set; }
		// **********
	}
}
