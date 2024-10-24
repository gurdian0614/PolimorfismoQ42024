
namespace PolimorfismoQ42024
{
    public class Inmueble
    {
        public string TipoInmueble { get; set; }
        public string Ubicacion { get; set; }
        public double AreaTerreno { get; set; }
        public double Precio { get; set; }

        public Inmueble() { }

        public Inmueble(string TipoInmueble, string Ubicacion, double AreaTerreno, double Precio)
        {
            this.TipoInmueble = TipoInmueble;
            this.Ubicacion = Ubicacion;
            this.AreaTerreno = AreaTerreno;
            this.Precio = Precio;
        }

        public void Vender()
        {
            Console.WriteLine($"{TipoInmueble}, con ubicación en {Ubicacion}, con un área de {AreaTerreno} mts2 ha sido vendido por el precio de L {Precio}");
        }

        public void Vender(double areaTerreno)
        {
            Console.WriteLine($"{TipoInmueble}, con ubicación en {Ubicacion}, con un área de {areaTerreno}mts2 ha sido vendido por el precio de L {Precio}");
        }

        public void Vender(double areaTerreno, double precio)
        {
            Console.WriteLine($"{TipoInmueble}, con ubicación en {Ubicacion}, con un área de {areaTerreno} mts2 ha sido vendido por el precio de L {precio}");
        }

        public void Vender(string tipoInmueble, string ubicacion, double areaTerreno, double precio)
        {
            Console.WriteLine($"{tipoInmueble}, con ubicación en {ubicacion}, con un área de {areaTerreno} mts2 ha sido vendido por el precio de L {precio}");
        }
    }
}
