namespace Decorator 
{
    public class Progam
    {
        private static void Main (string[] args)
        {
            var OrdeRregular = new OrdenRegular();
            Console.WriteLine(OrdeRregular.Calculototal());
            Console.WriteLine();

            var PreOrden = new PreOrden ();
            Console.WriteLine(PreOrden.Calculototal());
            Console.WriteLine();

            var OrdenPremiun = new OrdenPremiun(PreOrden);
            Console.WriteLine(OrdenPremiun.Calculototal());
            Console.WriteLine ();


        }

    }
}