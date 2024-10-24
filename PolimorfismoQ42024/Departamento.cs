
namespace PolimorfismoQ42024
{
    public class Departamento : Inmueble
    {
        public void Vender(string ubicacion, double areaTerreno, double precio)
        {
            Console.WriteLine($"Departamento, con ubicación en {ubicacion}, con un área de {areaTerreno} mts2 ha sido vendido por el precio de L {precio}");
        }
    }
}
