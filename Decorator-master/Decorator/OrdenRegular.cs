namespace Decorator
{
    public class OrdenRegular : OrdenBase 
    {
        public override double Calculototal()
        {
            Console.WriteLine("Calculo del precio total de un pedido normal");
            return productos.Sum(x => x.Precio);

        }

    }
}
