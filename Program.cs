class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine($"Halo {nama}");
    }
}

class Program
{
    static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Fizryan");
    }
}