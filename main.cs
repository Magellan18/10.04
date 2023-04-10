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

}
