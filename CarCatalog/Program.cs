using System;

namespace CarCatalog
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			AddToCatelog addToCatelog = new AddToCatelog ();


			string[] Arr = new string[]
				{ "add", "list", "quit" };
			Console.WriteLine ("======Welcome to Ginatech Auto Shop====");



			bool correct = false;
			int i = 1;
			while (!correct) {
				i++;
				Console.WriteLine ("Enter one  of the options below \n\n.add \n\n.List\n\n.quit");
				string input = Console.ReadLine ().ToLower ();

				
				if (input.Equals (Arr [0])) {
					addToCatelog.listMethod ();
				
				}
				if (input.Equals (Arr [1])) {
					Console.WriteLine ("There are currently no cars in the catalog.");	
				}          
				if (input.Equals (Arr [2])) {
					break;
				} else {
					
					Console.WriteLine ("Sorry, but " + input + " is not a valid command. Please try again. ");
					continue;

				}

			}





		}



	}
}
