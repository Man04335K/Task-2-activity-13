using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> multiples = new List<int>();

        for (int i = 1; i <= 100; i++)
        {
            if (i % 4 == 0 || i % 6 == 0)
            {
                multiples.Add(i);
            }
        }

        Console.WriteLine("Multiples of 4 or 6 from 1 to 100:");
        foreach (int number in multiples)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine(); // for spacing
    }
}
///Psudocode
///Start
///Initialize an empty list called "multiples"
///FOR i = 1 to 100 DO
///    IF i MOD 4 == 0 OR i MOD 6 == 0 THEN
///        Add i to "multiples"
///    ENDIF
///ENDFOR
///Display "Multiples of 4 or 6:"
///FOR each number in "multiples"
///    Display number
///ENDFOR
///End
