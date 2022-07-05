namespace Dtat
{
	public static class Utility
	{
		static Utility()
		{
		}

		public static System.DateTime Now
		{
			get
			{
				var currentCulture =
					System.Threading.Thread.CurrentThread.CurrentCulture;

				var currentUICulture =
					System.Threading.Thread.CurrentThread.CurrentUICulture;

				var newCulture =
					new System.Globalization.CultureInfo(name: "en-US");

				System.Threading.Thread.CurrentThread.CurrentCulture = newCulture;
				System.Threading.Thread.CurrentThread.CurrentUICulture = newCulture;

				var result =
					System.DateTime.Now;

				System.Threading.Thread.CurrentThread.CurrentCulture = currentCulture;
				System.Threading.Thread.CurrentThread.CurrentUICulture = currentUICulture;

				return result;
			}
		}
	}
}
