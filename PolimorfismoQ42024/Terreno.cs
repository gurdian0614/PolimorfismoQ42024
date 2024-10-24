
namespace PolimorfismoQ42024
{
    public class Terreno : Inmueble
    {
        public Terreno() { }

        public Terreno(string TipoInmueble) {
            this.TipoInmueble = TipoInmueble;
        }

        public Terreno(string TipoInmueble, string Ubicacion)
        {
            this.TipoInmueble = TipoInmueble;
            this.Ubicacion = Ubicacion;
        }

        public Terreno(string TipoInmueble, string Ubicacion, double AreaTerreno)
        {
            this.TipoInmueble = TipoInmueble;
            this.Ubicacion = Ubicacion;
            this.AreaTerreno = AreaTerreno;
        }

        public Terreno(string TipoInmueble, string Ubicacion, double AreaTerreno, double Precio)
        {
            this.TipoInmueble = TipoInmueble;
            this.Ubicacion = Ubicacion;
            this.AreaTerreno = AreaTerreno;
            this.Precio = Precio;
        }

        public void Vender(string ubicacion, double areaTerreno, double precio)
        {
            Console.WriteLine($"Terreno, con ubicación en {ubicacion}, con un área de {areaTerreno} mts2 ha sido vendido por el precio de L {precio}");
        }
    }
}
