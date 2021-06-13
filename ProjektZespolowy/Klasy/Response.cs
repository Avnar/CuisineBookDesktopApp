using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProjektZespolowy.Klasy
{
   public  class Response
    {
		[JsonProperty("pageNumber")]
		public static int PageNumber { get; set; }

		[JsonProperty("pageSize")]
		public static int PageSize { get; set; }

		[JsonProperty("totalPages")]
		public static int TotalPages { get; set; }

		[JsonProperty("totalRecords")]
		public static int TotalRecords { get; set; }

		[JsonProperty("nextPage")]
		public static bool NextPage { get; set; }

		[JsonProperty("previousPage")]
		public static bool PreviousPage { get; set; }

		[JsonProperty("data")]
		public static List<Food> Data { get; set; } = new List<Food>();

		[JsonProperty("succeeded")]
		public static bool Succeeded { get; set; }

		[JsonProperty("message")]
		public static string Message { get; set; }

		[JsonProperty("errors")]
		public static List<string> Errors { get; set; } = new List<string>();

		public override string ToString()
		{
			return "PageNumber: " + PageNumber.ToString() + "\n" +
				"PageSize: " + PageSize.ToString() + "\n" +
				"TotalPages: " + TotalPages.ToString() + "\n" +
				"TotalRecords: " + TotalRecords.ToString() + "\n" +
				"NextPage: " + NextPage.ToString() + "\n" +
				"PreviousPage: " + PreviousPage.ToString() + "\n" +
				"Data: " + Data + "\n" +
				"Succeeded: " + Succeeded.ToString() + "\n" +
				"Errors: " + Errors.ToString() + "\n";
		}
	}
}
