using System;

class MyClass
{
    static void Main()
    {
        string[] src = new string[5] {"This", "is", "arr", "of", "words"};
        string[] dst = new string[src.Length];
        ArrayFilter(src, dst);
        ArrayPrint(dst);
    }

    static void ArrayFilter(string[] src, string[] dst)
    {
        int count = 0; 
        for (int i = 0; i < src.Length; i++)
            if (src[i].Length <= 3) 
            {
                dst[count] = src[i];
                count++;
            }
    }

    static void ArrayPrint(string[] array)
    {
        for (int i = 0; i < array.Length; i++) 
            Console.Write($"{array[i]} "); 
        Console.WriteLine();
    }
}
