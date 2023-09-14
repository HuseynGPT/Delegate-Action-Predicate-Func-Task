namespace Delegate_Action_Predicate_Func;

internal class MyClass
{

    public void Space(string str)
    {
        char[] arr = str.ToCharArray();
        for (int i = 0; i < str.Length; i++)
        {
            Console.Write($"{arr[i]}_");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }

    public void Reverse(string str)
    {
        char[] arr = str.ToCharArray();

        for (int i = str.Length-1; i >= 0; i--)
        {
            Console.Write(arr[i]) ;
        }

        Console.WriteLine();
        Console.WriteLine();
    }
}
