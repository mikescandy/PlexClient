using System;
using System.Reflection;
using System.Linq;

namespace PlexAPI
{
	public static class Utils
	{
		public static DateTime GetDateTimeFromTimestamp (string timestamp)
		{
			// First make a System.DateTime equivalent to the UNIX Epoch.
			System.DateTime dateTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);

			// Add the number of seconds in UNIX timestamp to be converted.
			return dateTime.AddSeconds(Double.Parse(timestamp));
		}
        // TODO remove
        // T2 otherObject is being passed in null.     VVVVVVVVVVVVVV
		public static T1 CopyFrom<T1, T2>(this T1 obj, T2 otherObject)
			where T1: class
			where T2: class
		{
			PropertyInfo[] srcFields = otherObject.GetType().GetProperties(
				BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty);

			PropertyInfo[] destFields = obj.GetType().GetProperties(
				BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty);

			foreach (var property in srcFields) {
				var dest = destFields.FirstOrDefault(x => x.Name == property.Name);
				if (dest != null && dest.CanWrite)
					dest.SetValue(obj, property.GetValue(otherObject, null), null);
			}

			return obj;
		}
	}
}

