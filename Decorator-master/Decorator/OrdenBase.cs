namespace Decorator
{
    public abstract class OrdenBase
    {
        protected List<Producto> productos = new List<Producto>
     {
      new Producto {Nombre = "Telefono" , Precio = 800},
      new Producto {Nombre = "Tablet" , Precio = 1000},
      new Producto {Nombre = "PC Gamer" , Precio = 1800},
     };

        public abstract double Calculototal();

    }
}
