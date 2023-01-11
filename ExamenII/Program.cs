internal class Program
{
    private static void Main(string[] args)
    {
        comercial c1 = new comercial("Mario", 32, 500, 200);
        comercial c2 = new comercial("Carlos", 23, 500, 0);
        c1.toString();
        c2.toString();
        repartidor r1 = new repartidor("Jose", 35, 450, "Zona 1");
        repartidor r2 = new repartidor("Juan", 21, 450, "Zona 3");
        r1.toString();
        r2.toString();
    }
}