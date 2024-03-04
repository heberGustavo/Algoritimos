using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     * https://www.hackerrank.com/challenges/three-month-preparation-kit-time-conversion/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=three-month-preparation-kit&playlist_slugs%5B%5D=three-month-week-one
     */

    const string AM = "AM";
    const string PM = "PM";

    public static string timeConversion(string s)
    {
        var hourResult = ConverteStringParaTimeSpan(s);

        return hourResult;
    }

    public static string ConverteStringParaTimeSpan(string hourString)
    {
        var hourFormated = string.Empty;
        var resultHour = hourString.Split(":", StringSplitOptions.RemoveEmptyEntries);
        var hour = resultHour[0];
        var minute = resultHour[1];
        var second = resultHour[2].Substring(0,2);
        var timeZone = resultHour[2].Substring(resultHour[2].Count() - 2);

        if (timeZone.Contains(AM))
        {
            if (Int32.Parse(hour) == 12)
                hour = "00";

            hourFormated = ReturnFormatHour(hour, minute, second);
        }
        else if(timeZone.Contains(PM)) {
            if (Int32.Parse(hour) == 12)
                hour = "12";
            else
                hour = (Int32.Parse(hour) + 12).ToString();

            hourFormated = ReturnFormatHour(hour, minute, second);
        }

        return hourFormated;
    }

    public static string ReturnFormatHour(string hour, string minute, string second)
    {
        return $"{hour.PadLeft(2, '0')}:{minute.PadLeft(2, '0')}:{second.PadLeft(2, '0')}";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
