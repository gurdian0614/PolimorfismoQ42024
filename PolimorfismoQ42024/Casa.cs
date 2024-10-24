
namespace PolimorfismoQ42024
{
    public class Casa : Inmueble
    {
        public void Vender(string ubicacion)
        {
            Console.WriteLine($"Casa, con ubicación en {ubicacion}, con un área de {AreaTerreno} mts2 ha sido vendido por el precio de L {Precio}");
        }
    }
}
