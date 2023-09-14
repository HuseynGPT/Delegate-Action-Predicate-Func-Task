using Delegate_Action_Predicate_Func;
using System.Threading.Channels;

internal class Program
{
     public delegate void func(string str);
    private static void Main(string[] args)
    {
        Console.Write("Enter a text: ");
        string a = Console.ReadLine();
        MyClass myClass = new();

        func funcc = myClass.Space;
        funcc += myClass.Reverse;
        Run run = new();
        run.runFunc(funcc, a);







    }
}