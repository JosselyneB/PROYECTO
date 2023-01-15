namespace Decorator
{
    public class OrdenPremiun : Decorador
    {
       public OrdenPremiun(OrdenBase orden) : base(orden)
        {

        }

        public override double Calculototal()
        {
            Console.WriteLine("Calculo total precio orden premiun");
            var precioOrdenPrecio = base.Calculototal();
            return precioOrdenPrecio * 0.9; ;
        }

    }
}
