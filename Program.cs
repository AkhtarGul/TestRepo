// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool equal = Calclutors.AreEqual(1,2);

if (equal)
{
    Console.WriteLine("Equal");
}
else
{
    Console.WriteLine("Not Equal");
}
public   class Calclutors
{
    public static bool AreEqual<T>(T r1,T r2)
    {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        return r1.Equals(r2);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }
}

