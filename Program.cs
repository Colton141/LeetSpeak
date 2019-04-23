using System;
using System.Collections.Generic;


class MainClass
{
  static void Main()
  {
    Console.WriteLine("Enter a Word: ");
    string input = Console.ReadLine();

    char[] array = input.ToCharArray();
    List<char> letters = new List<char>();


    for (int i = 0; i < array.Length; i++)
    {
      if (array[i] == 'e')
      {
        letters.Add('3');
      }
      else if (array[i] == 'o')
      {
        letters.Add('0');
      }
      else if (array[i] == 'I')
      {
        letters.Add('1');
      }
      else if (array[i] == 't')
      {
        letters.Add('7');
      }
      else if (array[i] == 's' && array[i] != array[0])
      {
        letters.Add('z');
      }
      else
      {
        letters.Add(array[i]);
      }

    }
    string result = string.Join("", letters);
    Console.WriteLine(result);
  }
}
