namespace Dtat
{
	public class PersianDateTime : PersianDate
	{
		public static string ConvertToDateTime(System.DateTime time)
		{
			var persianDateTime =
				new PersianDateTime(time: time);

			var result =
				persianDateTime.ToString();

			return result;
		}

		public PersianDateTime(System.DateTime time) : base(time: time)
		{
			Hour = time.Hour;
			Minute = time.Minute;
			Second = time.Second;
		}

		public int Hour { get; }

		public int Minute { get; }

		public int Second { get; }

		public override string ToString()
		{
			var hourString =
				Hour.ToString()
				.PadLeft(totalWidth: 2, paddingChar: '0');

			var minuteString =
				Minute.ToString()
				.PadLeft(totalWidth: 2, paddingChar: '0');

			var secondString =
				Second.ToString()
				.PadLeft(totalWidth: 2, paddingChar: '0');

			var result =
				$"{base.ToString()} - {hourString}:{minuteString}:{secondString}";

			return result;
		}
	}
}
