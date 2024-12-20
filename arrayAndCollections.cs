using System;

public class arrayAndCollections
{
	public arrayAndCollections()
	{
	}
	public static void array()
	{
		int a = new int ();
		Console.WriteLine(a); // we cant use unassigned values 

		string[] array = new string[4];
        // default values of array variables 
        // bool - false 
        // int = float = 0
        // char = ' '
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(array[i]);
        }


        int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		
	}
}
