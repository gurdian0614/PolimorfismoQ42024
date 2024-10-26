
using PolimorfismoQ42024;

string tipoInmueble, ubicacion;
double areaTerreno, precio;

Console.WriteLine("Tipo de inmueble:");
tipoInmueble = Console.ReadLine();

Console.WriteLine("Ubicación:");
ubicacion = Console.ReadLine();

Console.WriteLine("Area:");
areaTerreno = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Precio:");
precio = Convert.ToDouble(Console.ReadLine());

Casa casa = new Casa();
casa.TipoInmueble = tipoInmueble;
casa.Ubicacion = ubicacion;
casa.AreaTerreno = areaTerreno;
casa.Precio = precio;

Departamento departamento = new Departamento();
departamento.TipoInmueble = tipoInmueble;
departamento.Ubicacion = ubicacion;
departamento.AreaTerreno = areaTerreno;
departamento.Precio = precio;

Console.WriteLine();
casa.Vender();
casa.Vender(ubicacion);

Console.WriteLine();
departamento.Vender(areaTerreno, precio);
departamento.Vender(ubicacion, areaTerreno, precio);

Console.WriteLine();
Terreno terreno = new Terreno(tipoInmueble, ubicacion, areaTerreno, precio);
terreno.Vender(tipoInmueble, ubicacion, areaTerreno, precio);
terreno.Vender(ubicacion, areaTerreno, precio);