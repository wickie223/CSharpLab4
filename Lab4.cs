using System;
					
public class Program
{
	public static void Main( string[] args)
	{
		Console.WriteLine("Problem 1");
		String[] months = new String[12];
		months[0] = ("January");
		months[1] = ("February");
		months[2] = ("March");
		months[3] = ("April");
		months[4] = ("May");
		months[5] = ("June");
		months[6] = ("July");
		months[7] = ("August");
		months[8] = ("September");
		months[9] = ("October");
		months[10] = ("November");
		months[11] = ("December");	
		for (int i = 0; i < months.Length; i++)
		{
			Console.WriteLine(months[i]);
		}
		
		Console.WriteLine("\nProblem 2");
		String[] seasons = new String[] {"Spring", "Summer", "Fall", "Winter"};
		int j=0;
		while (j < 4)
		{
			Console.WriteLine(seasons[j]);
			j++;
		}
		
		Console.WriteLine("\nProblem 3");
		String[] names = new String[] {"Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford"}; 
		for (int k = 0; k < names.Length; k++)
		{
			Console.WriteLine(names[k]);
		}
		
		Console.WriteLine("\nProblem 4");
		String[] names2 = new String[] {"Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford"}; 
		foreach (String m in names2)
		{
			Console.WriteLine(m);
		}
		
		Console.WriteLine("\nProblem 5");
		int[] numbers = new int[20];
		Random random = new Random();
		int randomNumber;
		for (int x = 0; x<numbers.Length; x++) 
		{	
			randomNumber = random.Next(0, 100);
			numbers[x] = randomNumber;
		}
		foreach (int y in numbers)
		{
			Console.WriteLine(y);
		}
	}
}