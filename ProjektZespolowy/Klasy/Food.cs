using Newtonsoft.Json;
using System.Collections.Generic;


namespace ProjektZespolowy.Klasy
{
   public class Food
    {
		public int Id { get; set; }

		public string Title { get; set; }

		public string Ingredients { get; set; }

		public string ImageLink { get; set; }

		public string Difficulty { get; set; }

		public string PreparationTime { get; set; }

		public int CalorificValue { get; set; }

		public string PreparingMethod { get; set; }

		public string Cathegory { get; set; }

		public override string ToString()
		{
			return "Id: " + Id + "\n" +
				"Title: " + Title + "\n" +
				"Ingredients: " + Ingredients + "\n" +
				"ImageLink: " + ImageLink + "\n" +
				"Difficulty: " + Difficulty + "\n" +
				"PreparationTime: " + PreparationTime + "\n" +
				"CalorificValue: " + CalorificValue + "\n" +
				"PreparingMethod: " + PreparingMethod + "\n" +
				"Cathegory: " + Cathegory + "\n";
		}
		public string ShowTitle()
        {
			return Title;

        }
	}
}
