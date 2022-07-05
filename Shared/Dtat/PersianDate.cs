namespace Dtat
{
	public class PersianDate : object
	{
		static PersianDate()
		{
			PersianCalendar =
				new System.Globalization.PersianCalendar();
		}

		protected static System.Globalization.PersianCalendar PersianCalendar { get; }

		public static string ConvertToDate(System.DateTime time)
		{
			var persianDate =
				new PersianDate(time: time);

			var result =
				persianDate.ToString();

			return result;
		}

		public PersianDate(System.DateTime time) : base()
		{
			Time = time;

			Day =
				PersianCalendar.GetDayOfMonth(time: time);

			Month =
				PersianCalendar.GetMonth(time: time);

			Year =
				PersianCalendar.GetYear(time: time);
		}

		public int Day { get; }

		public int Month { get; }

		public int Year { get; }

		public System.DateTime Time { get; }

		public override string ToString()
		{
			var dayString =
				Day.ToString()
				.PadLeft(totalWidth: 2, paddingChar: '0');

			var monthString =
				Month.ToString()
				.PadLeft(totalWidth: 2, paddingChar: '0');

			var result =
				$"{Year}/{monthString}/{dayString}";

			return result;
		}
	}
}
