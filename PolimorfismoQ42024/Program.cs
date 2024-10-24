
using PolimorfismoQ42024;

string tipoInmueble, ubicacion;
double areaTerreno, precio;

Casa casa = new Casa();
Departamento departamento = new Departamento();
Terreno terreno = new Terreno();

Console.WriteLine("Tipo de inmueble:");
tipoInmueble = Console.ReadLine();

Console.WriteLine("Ubicación:");
ubicacion = Console.ReadLine();

Console.WriteLine("Area:");
areaTerreno = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Precio:");
precio = Convert.ToDouble(Console.ReadLine());

casa.TipoInmueble = tipoInmueble;
casa.Ubicacion = ubicacion;
casa.AreaTerreno = areaTerreno;
casa.Precio = precio;

departamento.TipoInmueble = tipoInmueble;
departamento.Ubicacion = ubicacion;
departamento.AreaTerreno = areaTerreno;
departamento.Precio = precio;

terreno.TipoInmueble = tipoInmueble;
terreno.Ubicacion = ubicacion;
terreno.AreaTerreno = areaTerreno;
terreno.Precio = precio;

Console.WriteLine();
casa.Vender();
casa.Vender(ubicacion);

Console.WriteLine();
departamento.Vender(areaTerreno, precio);
departamento.Vender(ubicacion, areaTerreno, precio);

Console.WriteLine();
terreno.Vender(tipoInmueble, ubicacion, areaTerreno, precio);
terreno.Vender(ubicacion, areaTerreno, precio);