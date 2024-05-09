

using ConsoleClasesC_.Garage;
using ConsoleClasesC_.Modelo;

coche MiCitroen = new coche();
MiCitroen.matricula = "asfasf";
MiCitroen.cabe = true;

coche MiSeat = new ();

MiSeat.matricula = "asfasf";
MiSeat.cabe = true;

var MiMercedes = new coche ();

MiMercedes.matricula = "asfasf";
MiMercedes.cabe = true;

var MiFiat = new coche () { matricula = "afasfa", cabe = true};

var MiPorche = new coche("hola");

Console.WriteLine(MiCitroen.ToString());
Console.WriteLine(MiSeat.ToString());
Console.WriteLine(MiMercedes.ToString());
Console.WriteLine(MiFiat.ToString());
Console.WriteLine(MiPorche.ToString());

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------

var Coche1 = new Vehiculo();
var Coche2 = new Vehiculo();

Console.WriteLine("Introduce la potencia del coche 1");
Coche1.Potencia = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce el número de ruedas del coche 1");
Coche1.NumRuedas = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce la velocidad del coche 1");
Coche1.Velocidad = double.Parse(Console.ReadLine());

Console.WriteLine("Introduce la potencia del coche 2");
Coche2.Potencia = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce el número de ruedas del coche 2");
Coche2.NumRuedas = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce la velocidad del coche 2");
Coche2.Velocidad = double.Parse(Console.ReadLine());

Console.WriteLine(Coche1.ToString());
Console.WriteLine(Coche2.ToString());

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------

var CocheAlq1 = new ConsoleClasesC_.Garage.Coche() { Identificador = "hola", PrecioHora = 5, Tiempo = 7}; // Esta es la forma buena de instanciar un objeto en C#
ConsoleClasesC_.Garage.Coche CocheAlq2 = new();
var CocheAlq3 = new ConsoleClasesC_.Garage.Coche();
CocheAlq1.Visor = new VisionadorConsola();
Console.WriteLine(CocheAlq1.ToString());

IAlquilable FurgonetaAlq1 = new ConsoleClasesC_.Garage.Furgoneta() { Identificador = "adios", PrecioHora = 8, Tiempo = 10 }; // Esta es la forma buena de instanciar un objeto en C#

Console.WriteLine(FurgonetaAlq1.ToString());

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------

// Crear un objeto furgoneta y otro cohe con el patron simple factory

IFactoryAlquilable Factory = new AgregableFactory01();

var CocheFactory = Factory.DameElemento(EnumTipos.Coche, "Hola", 50);

var FurgonetaFactory = Factory.DameElemento(EnumTipos.Furgoneta, "Adios", 80);

(CocheFactory as Coche).Visor = new VisionadorConsola();

CocheFactory.ToString();
Console.WriteLine(FurgonetaFactory.ToString());
