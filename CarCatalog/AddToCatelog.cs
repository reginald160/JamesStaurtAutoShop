using System;
using System.Diagnostics.PerformanceData;
using System.Collections.Generic;

namespace CarCatalog
{
	public class AddToCatelog
	{
		public string Make { get; set; }

		public string Model { get; set; }

		public int Year { get; set; }

		public decimal SalePrice{ get; set; }


		public AddToCatelog ()
		{
			


		}


		string[] Catelog = new string [20];

		int[] price = new int[20];
		List <AddToCatelog> cars = new List <AddToCatelog> ();

		public void listMethod ()
		{
			

			for (int i = 1; i <= Catelog.Length - 1; i++) {
				
				Console.WriteLine ("Enter the make");
				Make = Console.ReadLine ();
				Console.WriteLine ("Enter the model");
				Model = Console.ReadLine ();

				Console.WriteLine ("Enter the Year");
				Year = Convert.ToInt32 (Console.ReadLine ());

				Console.WriteLine ("Enter price");
				SalePrice = Convert.ToDecimal (Console.ReadLine ());

				AddToCatelog newcar = new AddToCatelog ();
				cars.Add (newcar);
				Console.WriteLine ("Enter: [QUIT] to quit or [LIST] to view all cars or [ADD] to contiue");
				string output = Console.ReadLine ();
				string check = output.ToLower ();



			}


		}


	}
}

