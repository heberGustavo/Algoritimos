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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

	public static void miniMaxSum(List<int> arr)
	{
		var arrMin = arr.OrderBy(x => x).SkipLast(1);
		var arrMax = arr.OrderByDescending(x => x).SkipLast(1);

		var minValue = SumValues(arrMin);
		var maxValue = SumValues(arrMax);

		Console.WriteLine(string.Concat(minValue, " ", maxValue));
	}

	public static long SumValues(IEnumerable<int> arr)
	{
		long sumValues = 0;
		foreach (var item in arr)
			sumValues += item;

		return sumValues;
	}

}

class Solution
{
	public static void Main(string[] args)
	{

		List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

		Result.miniMaxSum(arr);
	}
}
