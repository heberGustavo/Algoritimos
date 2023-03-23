using System;

namespace Time_Convertion
{
    class Program
    {
        static void Main(string[] args)
        {
            Result.timeConversion("07:05:45PM");
        }
    }

    class Result
    {
        public static string timeConversion(string s)
        {

            var hourConvert = ConvertHours(s);

            var hours = s.Split(":");
            hours[0] = hourConvert;

            var newHour = string.Empty;

            for (int i = 0; i < hours.Length; i++)
            {
                if (i == (hours.Length - 1 ))
                    newHour += hours[i];
                else
                    newHour += hours[i] + ":";
            }

            //REMOVER PM OU AM
            return newHour.Substring(newHour.Length - 2);

        }

        public static string ConvertHours(string s)
        {
            const string FormatAM = "AM";
            const string FormatPM = "PM";

            var format = s.Substring(s.Length - 2);
            var hour = s.Split(":")[0];

            var returnHour = string.Empty;

            if (format.Equals(FormatAM))
                returnHour = (Convert.ToInt32(hour) - 12).ToString();
            else if (format.Equals(FormatPM))
                returnHour = (Convert.ToInt32(hour) + 12).ToString();

            return returnHour;
        }

    }
}
