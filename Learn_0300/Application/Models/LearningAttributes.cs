// **************************************************
// **************************************************
// *** Session 13 ***********************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 01 **********************************
// **************************************************
namespace Models
{
	/// <summary>
	/// POCO -> Plain Old CLR Objects
	/// </summary>
	public class Category01 : object
	{
		public Category01() : base()
		{
		}

		// **********
		public int Id { get; set; }
		// **********

		// **********
		public string? Name { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 02 **********************************
// **************************************************
namespace Models
{
	public class Category02 : object
	{
		public Category02() : base()
		{
		}

		// **********
		public int ID { get; set; }
		// **********

		// **********
		public string? Name { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 03 **********************************
// **************************************************
namespace Models
{
	public class Category03 : object
	{
		public Category03() : base()
		{
		}

		// **********
		public int Category03Id { get; set; }
		// **********

		// **********
		public string? Name { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 04 **********************************
// **************************************************
namespace Models
{
	public class Category04 : object
	{
		public Category04() : base()
		{
		}

		// **********
		public int Category04ID { get; set; }
		// **********

		// **********
		public string? Name { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 05 **********************************
// **************************************************
//namespace Models
//{
//	public class Category05 : object
//	{
//		public Category05() : base()
//		{
//		}

//		// **********
//		/// <summary>
//		/// خطا می‌دهد
//		/// </summary>
//		public int Key { get; set; }
//		// **********

//		// **********
//		public string? Name { get; set; }
//		// **********
//	}
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 06 **********************************
// **************************************************
namespace Models
{
	public class Category06 : object
	{
		public Category06() : base()
		{
		}

		// **********
		/// <summary>
		/// این ویژگی فقط مربوط به بانک‌اطلاعاتی می‌شود
		/// 
		/// داریم Key چون در اسکیوال کلمه
		/// می‌شود [Key] تبدیل به
		/// </summary>
		[System.ComponentModel.DataAnnotations.Key]
		public int Key { get; set; }
		// **********

		// **********
		public string? Name { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 07 **********************************
// **************************************************
namespace Models
{
	public class Category07 : object
	{
		public Category07() : base()
		{
		}

		// **********
		public int Id { get; set; }
		// **********

		// **********
		/// <summary>
		/// این ویژگی هم مربوط به برنامه می‌شود
		/// و هم مربوط به بانک اطلاعاتی می‌شود
		/// </summary>
		[System.ComponentModel.DataAnnotations.MaxLength
			(length: 100)]
		public string? Name { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 08 **********************************
// **************************************************
namespace Models
{
	public class Category08 : object
	{
		public Category08() : base()
		{
		}

		// **********
		public int Id { get; set; }
		// **********

		// **********
		/// <summary>
		/// این ویژگی فقط مربوط به برنامه می‌شود
		/// </summary>
		[System.ComponentModel.DataAnnotations.MinLength
			(length: 3)]

		/// <summary>
		/// این ویژگی هم مربوط به برنامه می‌شود
		/// و هم مربوط به بانک اطلاعاتی می‌شود
		/// </summary>
		[System.ComponentModel.DataAnnotations.MaxLength
			(length: 100)]
		public string? Name { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 09 **********************************
// **************************************************
namespace Models
{
	public class Category09 : object
	{
		public Category09() : base()
		{
		}

		// **********
		public int Id { get; set; }
		// **********

		// **********
		/// <summary>
		/// این ویژگی هم مربوط به برنامه می‌شود
		/// و هم مربوط به بانک اطلاعاتی می‌شود
		/// </summary>
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100)]
		public string? Name { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 10 **********************************
// **************************************************
namespace Models
{
	public class Category10 : object
	{
		public Category10() : base()
		{
		}

		// **********
		public int Id { get; set; }
		// **********

		// **********
		/// <summary>
		/// بخشی از این ویژگی هم مربوط به برنامه می‌شود
		/// و هم مربوط به بانک اطلاعاتی می‌شود
		/// 
		/// و بخشی از آن صرفا مربوط به برنامه می‌شود
		/// </summary>
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100, MinimumLength = 3)]
		public string? Name { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 11 **********************************
// **************************************************
namespace Models
{
	public class Category11 : object
	{
		public Category11() : base()
		{
		}

		// **********
		public int Id { get; set; }
		// **********

		// **********
		/// <summary>
		/// این ویژگی هم مربوط به برنامه می‌شود
		/// و هم مربوط به بانک اطلاعاتی می‌شود
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100, MinimumLength = 3)]
		public string? Name { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 12 **********************************
// **************************************************
namespace Models
{
	public class Category12 : object
	{
		public Category12() : base()
		{
		}

		// **********
		public int Id { get; set; }
		// **********

		// **********
		/// <summary>
		/// بخشی از این ویژگی هم مربوط به برنامه می‌شود
		/// و هم مربوط به بانک اطلاعاتی می‌شود
		/// 
		/// و بخشی از آن صرفا مربوط به برنامه می‌شود
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100, MinimumLength = 3)]
		public string? Name { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 13 **********************************
// **************************************************
// See:
// CreateCategory13Async() Function
// and
// DisplayCategories13Async() Function
// **************************************************
namespace Models
{
	/// <summary>
	/// طراحی هوشمندانه که در نسخه قبل امکان‌پذیر نبود
	/// </summary>
	public class Category13 : object
	{
		/// <summary>
		/// را می‌نوشتیم Default Constructor در نسخه قدیم باید حتما
		/// </summary>
		//public Category13() : base()
		//{
		//}

		public Category13(string name) : base()
		{
			Name = name;
		}

		// **********
		/// <summary>
		/// Note: private set;
		/// </summary>
		public int Id { get; private set; }
		// **********

		// **********
		/// <summary>
		/// Note: string? -> string
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100, MinimumLength = 3)]
		public string Name { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// *** Session 14 ***********************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 14 **********************************
// **************************************************
namespace Models
{
	public class Category14 : object
	{
		public Category14(string name) : base()
		{
			Name = name;
			//Ordering = 10000;
			Ordering = 10_000;
		}

		// **********
		public int Id { get; private set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100, MinimumLength = 3)]
		public string Name { get; set; }
		// **********

		// **********
		/// <summary>
		/// این ویژگی فقط مربوط به برنامه می‌شود
		/// 
		/// ها Validator در
		/// تعبیر به شرط آن است که در
		/// درون متغیر مقداری نوشته شده باشد
		/// </summary>
		//[System.ComponentModel.DataAnnotations.Range
		//	(minimum: 1, maximum: 100000)]
		[System.ComponentModel.DataAnnotations.Range
			(minimum: 1, maximum: 100_000)]
		public int Ordering { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 15 **********************************
// **************************************************
namespace Models
{
	/// <summary>
	/// In Classic EF: Automatically: Country -> Countries Based on Model Name
	/// In EF Core: Automatically: Country -> Countries Based on DbSet Property Name
	/// 
	/// Example: Categories_15
	/// </summary>
	public class Category15 : object
	{
		public Category15(string name) : base()
		{
			Name = name;
		}

		// **********
		public int Id { get; private set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100, MinimumLength = 3)]
		public string Name { get; set; }
		// **********

		// **********
		/// <summary>
		/// این ویژگی فقط مربوط به برنامه می‌شود
		/// </summary>

		//[System.ComponentModel.DataAnnotations.RegularExpression
		//	(pattern: "^\\d$")]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(pattern: "^\\d{10}$")]

		//[System.ComponentModel.DataAnnotations.RegularExpression
		//	(pattern: "^\\d{3,8}$")]
		public string? PostalCode { get; set; }
		// **********

		public bool ValidatePostalCode()
		{
			if (string.IsNullOrEmpty(value: PostalCode))
			{
				return true;
			}

			bool result =
				System.Text.RegularExpressions.Regex
				.IsMatch(input: PostalCode, pattern: "^\\d{10}$");

			return result;
		}
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 16 **********************************
// **************************************************
namespace Models
{
	[System.ComponentModel.DataAnnotations.Schema.Table
		(name: "CountriesTable")]
	public class Category16 : object
	{
		public Category16(string name) : base()
		{
			Name = name;
		}

		// **********
		[System.ComponentModel.DataAnnotations.Schema.Column
			(name: "CountryId")]
		public int Id { get; private set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100, MinimumLength = 3)]

		[System.ComponentModel.DataAnnotations.Schema.Column
			(name: "CountryName")]
		public string Name { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 17 **********************************
// **************************************************
namespace Models
{
	[System.ComponentModel.DataAnnotations.Schema.Table
		(name: "TABLE_001")]
	public class Category17 : object
	{
		public Category17(string name) : base()
		{
			Name = name;
		}

		// **********
		[System.ComponentModel.DataAnnotations.Schema.Column
			(name: "FIELD_001")]
		public int Id { get; private set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100, MinimumLength = 3)]

		[System.ComponentModel.DataAnnotations.Schema.Column
			(name: "FIELD_002")]
		public string Name { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 18 **********************************
// **************************************************
namespace Models
{
	/// <summary>
	/// Multiple Schema does not work in Sqlite!
	/// Schema does not work in SQL Server Compact Edition at all!
	/// </summary>
	[System.ComponentModel.DataAnnotations.Schema.Table
		(name: "Categories", Schema = "Cms")]
	public class Category18 : object
	{
		public Category18(string name) : base()
		{
			Name = name;
		}

		// **********
		public int Id { get; private set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100, MinimumLength = 3)]
		public string Name { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 19 **********************************
// **************************************************
namespace Models
{
	/// <summary>
	/// متاسفانه هیچ‌یک از سه دستور ذیل کار نمی‌کند
	/// </summary>

	//[System.ComponentModel.DataAnnotations.Schema.Table
	//	(Schema = "Cms")]

	//[System.ComponentModel.DataAnnotations.Schema.Table
	//	(name: null, Schema = "Cms")]

	//[System.ComponentModel.DataAnnotations.Schema.Table
	//	(name: "", Schema = "Cms")]
	public class Category19 : object
	{
		public Category19(string name) : base()
		{
			Name = name;
		}

		// **********
		public int Id { get; private set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100, MinimumLength = 3)]
		public string Name { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 20 **********************************
// **************************************************
namespace Models
{
	/// <summary>
	/// Id:
	/// 
	/// In C#				In SQL Server Database
	/// 
	/// int					int
	/// long				long
	/// System.Guid			uniqueidentifier
	/// </summary>
	public class Category20 : object
	{
		public Category20(string name) : base()
		{
			Name = name;
		}

		// **********
		//[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
		//	(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]

		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
		public int Id { get; private set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100, MinimumLength = 3)]
		public string Name { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// *** Session 15 ***********************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 21 **********************************
// **************************************************
// See:
// CreateCategory21Async() Function
// **************************************************
namespace Models
{
	public class Category21 : object
	{
		public Category21(string name) : base()
		{
			Name = name;
		}

		// **********
		/// <summary>
		/// بانک اطلاعاتی مقدار آن را
		/// تولید می‌کند و به سمت برنامه ارسال می‌کند
		/// </summary>
		public System.Guid Id { get; private set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100, MinimumLength = 3)]
		public string Name { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 22 **********************************
// **************************************************
namespace Models
{
	public class Category22 : object
	{
		public Category22(string name) : base()
		{
			Name = name;

			// دستور ذیل صحیح نمی‌باشد
			//Id = new System.Guid();

			Id = System.Guid.NewGuid();
		}

		// **********
		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
		public System.Guid Id { get; private set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100, MinimumLength = 3)]
		public string Name { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 23 **********************************
// **************************************************
// See:
// CreateCategory23Async() Function
// **************************************************
namespace Models
{
	public class Category23 : object
	{
		public Category23(string name) : base()
		{
			Name = name;

			Id = System.Guid.NewGuid();
		}

		// **********
		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
		public System.Guid Id { get; private set; }
		// **********

		// **********
		/// <summary>
		/// Note: private set;
		/// </summary>
		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
		public int Code { get; private set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100, MinimumLength = 3)]
		public string Name { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 24 **********************************
// **************************************************
namespace Models
{
	public class Category24 : object
	{
		public Category24(string name) : base()
		{
			Name = name;

			Id = System.Guid.NewGuid();
		}

		// **********
		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
		public System.Guid Id { get; private set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
		public int Code1 { get; private set; }
		// **********

		// **********
		/// <summary>
		/// only one column per table can be configured as 'Identity'.
		/// 
		/// تعریف نمایید Sequence بعدا یاد خواهید گرفت که چیزی به نام
		/// </summary>
		//[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
		//	(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
		//public int Code2 { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100, MinimumLength = 3)]
		public string Name { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// *** Session 16 ***********************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 25 **********************************
// **************************************************
// See:
// CreateCategory25Async() Function
// **************************************************
namespace Models
{
	public class Category25 : object
	{
		public Category25(string name) : base()
		{
			Name = name;

			//InsertDateTime =
			//	System.DateTime.Now;

			InsertDateTime =
				Dtat.Utility.Now;

			Id = System.Guid.NewGuid();
		}

		// **********
		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
		public System.Guid Id { get; private set; }
		// **********

		// **********
		/// <summary>
		/// Note: private set;
		/// </summary>
		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
		public int Code { get; private set; }
		// **********

		// **********
		// **********
		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100, MinimumLength = 3)]
		public string Name { get; set; }
		// **********

		// **********
		public string DisplayName
		{
			get
			{
				var result =
					$"{Code} - {Name}";

				return result;
			}
		}
		// **********
		// **********
		// **********

		// **********
		// **********
		// **********
		public System.DateTime InsertDateTime { get; private set; }
		// **********

		// **********
		/// <summary>
		/// Set ای که Property
		/// نداشته باشد تبدیل به فیلد در بانک اطلاعاتی نمی‌شود
		/// </summary>
		public Dtat.PersianDate InsertPersianDate
		{
			get
			{
				var result =
					new Dtat.PersianDate(dateTime: InsertDateTime);

				return result;
			}
		}
		// **********

		// **********
		public Dtat.PersianDate InsertPersianDateTime
		{
			get
			{
				var result =
					new Dtat.PersianDateTime(dateTime: InsertDateTime);

				return result;
			}
		}
		// **********
		// **********
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 26 **********************************
// **************************************************
namespace Models
{
	public class Category26 : object
	{
		public Category26(string name) : base()
		{
			Name = name;

			InsertDateTime =
				Dtat.Utility.Now;

			Id = System.Guid.NewGuid();
		}

		// **********
		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
		public System.Guid Id { get; private set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100)]
		public string Name { get; set; }
		// **********

		// **********
		// **********
		// **********
		public System.DateTime InsertDateTime { get; private set; }
		// **********

		// **********
		public Dtat.PersianDate InsertPersianDateTime
		{
			get
			{
				var result =
					new Dtat.PersianDateTime(dateTime: InsertDateTime);

				return result;
			}
		}
		// **********
		// **********
		// **********

		// **********
		// **********
		// **********
		/// <summary>
		/// تبدیل به فیلد می‌شود
		/// </summary>
		public int MyProperty11 { get; set; }
		// **********

		// **********
		/// <summary>
		/// تبدیل به فیلد می‌شود
		/// </summary>
		public int MyProperty12 { get; private set; }
		// **********

		// **********
		/// <summary>
		/// تبدیل به فیلد می‌شود
		/// </summary>
		public int MyProperty13 { get; protected set; }
		// **********

		// **********
		/// <summary>
		/// تبدیل به فیلد می‌شود
		/// </summary>
		public int MyProperty14 { get; internal set; }
		// **********

		// **********
		/// <summary>
		/// تبدیل به فیلد می‌شود
		/// </summary>
		public int MyProperty15 { get; private protected set; }
		// **********

		// **********
		/// <summary>
		/// تبدیل به فیلد می‌شود
		/// </summary>
		public int MyProperty16 { get; protected internal set; }
		// **********
		// **********
		// **********

		// **********
		// **********
		// **********
		/// <summary>
		/// !تبدیل به فیلد نمی‌شود
		/// </summary>
		public int MyProperty21 { get; }
		// **********
		// **********
		// **********

		// **********
		// **********
		// **********
		/// <summary>
		/// !تبدیل به فیلد نمی‌شود
		/// </summary>
		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		public int MyProperty22 { get; set; }
		// **********
		// **********
		// **********

		// **********
		// **********
		// **********
		/// <summary>
		/// !تبدیل به فیلد نمی‌شود
		/// </summary>
		private int MyProperty23 { get; set; }
		// **********

		// **********
		/// <summary>
		/// !تبدیل به فیلد نمی‌شود
		/// </summary>
		protected int MyProperty24 { get; set; }
		// **********

		// **********
		/// <summary>
		/// !تبدیل به فیلد نمی‌شود
		/// </summary>
		internal int MyProperty25 { get; set; }
		// **********

		// **********
		/// <summary>
		/// !تبدیل به فیلد نمی‌شود
		/// </summary>
		private protected int MyProperty26 { get; set; }
		// **********

		// **********
		/// <summary>
		/// !تبدیل به فیلد نمی‌شود
		/// </summary>
		protected internal int MyProperty27 { get; set; }
		// **********
		// **********
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Category 27 **********************************
// **************************************************
namespace Models
{
	public class Category27 : object
	{
		public Category27(string name) : base()
		{
			Name = name;

			InsertDateTime =
				Dtat.Utility.Now;

			Id = System.Guid.NewGuid();
		}

		// **********
		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
		public System.Guid Id { get; private set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100)]
		public string Name { get; set; }
		// **********

		// **********
		// **********
		// **********
		public System.DateTime InsertDateTime { get; private set; }
		// **********

		// **********
		public Dtat.PersianDateTime InsertPersianDateTime
		{
			get
			{
				var result =
					new Dtat.PersianDateTime(dateTime: InsertDateTime);

				return result;
			}
		}
		// **********
		// **********
		// **********

		// **********
		/// <summary>
		/// Order is Zero based!
		/// Note: Using TypeName is not recommended!
		/// </summary>
		[System.ComponentModel.DataAnnotations.Schema.Column
			(Order = 0, TypeName = "Char")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100)]
		public string Description { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// *** Session 17 ***********************************
// **************************************************
// **************************************************

// **************************************************
// *** UserInGroup 01 *******************************
// **************************************************
//namespace Models
//{
//	/// <summary>
//	/// ضمن آن‌که تفکر ذیل را اصلا توصیه نمی‌کنم، باید دقت داشته باشید
//	/// کار نمی‌کند EF Core کار می‌کند ولی در EF روش ذیل در
//	/// 
//	/// Error:
//	/// The entity type 'UserInGroup01' has multiple properties with the [Key] attribute.
//	/// Composite primary keys can only be set using 'HasKey' in 'OnModelCreating'.
//	/// </summary>
//	public class UserInGroup01 : object
//	{
//		public UserInGroup01(System.Guid userId, System.Guid groupId) : base()
//		{
//			UserId = userId;
//			GroupId = groupId;
//		}

//		// **********
//		[System.ComponentModel.DataAnnotations.Key]
//		[System.ComponentModel.DataAnnotations.Schema.Column(Order = 0)]
//		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
//			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
//		public System.Guid UserId { get; private set; }
//		// **********

//		// **********
//		[System.ComponentModel.DataAnnotations.Key]
//		[System.ComponentModel.DataAnnotations.Schema.Column(Order = 1)]
//		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
//			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
//		public System.Guid GroupId { get; private set; }
//		// **********
//	}
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** UserInGroup 02 *******************************
// **************************************************
namespace Models
{
	public class UserInGroup02 : object
	{
		public UserInGroup02(System.Guid userId, System.Guid groupId) : base()
		{
			UserId = userId;
			GroupId = groupId;
			Id = System.Guid.NewGuid();
		}

		// **********
		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
		public System.Guid Id { get; private set; }
		// **********

		// **********
		/// <summary>
		/// Foreign Key
		/// 
		/// دستور ذیل، ناقص است! انشاءالله در قسمت روابط
		/// یک به چند و چند به چند به این موضوع به طور کامل می‌پردازیم
		/// </summary>
		public System.Guid UserId { get; private set; }
		// **********

		// **********
		/// <summary>
		/// Foreign Key
		/// 
		/// دستور ذیل، ناقص است! انشاءالله در قسمت روابط
		/// یک به چند و چند به چند به این موضوع به طور کامل می‌پردازیم
		/// </summary>
		public System.Guid GroupId { get; private set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** User 01 **************************************
// **************************************************
namespace Models
{
	public class User01 : object
	{
		public User01(string username) : base()
		{
			Username = username;
			Id = System.Guid.NewGuid();
		}

		// **********
		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
		public System.Guid Id { get; private set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: 20)]

		// کار نمی‌کند EF Core کار می‌کند و در EF دستور ذیل فقط در
		//[System.ComponentModel.DataAnnotations.Schema.Index
		//	(IsUnique = false)]
		public string Username { get; private set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** User 02 **************************************
// **************************************************
namespace Models
{
	/// <summary>
	/// نکته بسیار مهم
	/// 
	/// تعریف کرد Index هستند VarChar, NVarChar نمی‌توان برای فیلدهایی که از جنس
	/// </summary>
	//[Microsoft.EntityFrameworkCore.Index
	//	("Username", IsUnique = true)]

	// Index Name: IX_Users02_Username
	//[Microsoft.EntityFrameworkCore.Index
	//	(nameof(Username), IsUnique = true)]

	[Microsoft.EntityFrameworkCore.Index
		(nameof(Username), IsUnique = true, Name = "Googooli")]

	[Microsoft.EntityFrameworkCore.Index
		(nameof(FirstName), nameof(LastName), IsUnique = false)]

	// با اجرای دستور ذیل اتفاق جالبی رخ می‌دهد
	// nvarchar(450)
	// صورت می‌گیرد EF Core این عمل به طور اتوماتیک توسط
	[Microsoft.EntityFrameworkCore.Index
		(nameof(Description))]
	public class User02 : object
	{
		public User02(string username) : base()
		{
			Username = username;
			Id = System.Guid.NewGuid();
		}

		// **********
		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
		public System.Guid Id { get; private set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: 20)]
		public string Username { get; private set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.MaxLength
			(length: 20)]
		public string? FirstName { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.MaxLength
			(length: 30)]
		public string? LastName { get; set; }
		// **********

		// **********
		public string? Description { get; set; }
		// **********
	}
}
// **************************************************
// **************************************************
// **************************************************
