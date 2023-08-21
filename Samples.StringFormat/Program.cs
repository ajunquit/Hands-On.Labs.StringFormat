// See https://aka.ms/new-console-template for more information
Console.WriteLine("******** Formatos numéricos ********");

int number = 123456789;

Console.WriteLine("Formato C: " + string.Format("{0:C}", number)); // Moneda
Console.WriteLine("Formato D: " + string.Format("{0:D}", 123));   // Entero
Console.WriteLine("Formato E: " + string.Format("{0:E}", number)); // Notación científica
Console.WriteLine("Formato F: " + string.Format("{0:F2}", number));// Punto flotante con 2 decimales
Console.WriteLine("Formato G: " + string.Format("{0:G}", number)); // Formato general
Console.WriteLine("Formato N: " + string.Format("{0:N0}", number)); // Número con separadores
Console.WriteLine("Formato P: " + string.Format("{0:P}", 0.456));   // Porcentaje
Console.WriteLine("Formato X: " + string.Format("{0:X}", 255));    // Hexadecimal
Console.WriteLine();


Console.WriteLine("******** Formatos de Fecha ********");

DateTime now = DateTime.Now;

Console.WriteLine("Formato d: " + string.Format("{0:d}", now));   // Fecha corta
Console.WriteLine("Formato D: " + string.Format("{0:D}", now));   // Fecha y hora larga
Console.WriteLine("Formato f: " + string.Format("{0:f}", now));   // Fecha y hora larga (sin segundos)
Console.WriteLine("Formato F: " + string.Format("{0:F}", now));   // Fecha y hora larga
Console.WriteLine("Formato g: " + string.Format("{0:g}", now));   // Fecha y hora general
Console.WriteLine("Formato G: " + string.Format("{0:G}", now));   // Fecha y hora general (sin segundos)
Console.WriteLine("Formato m: " + string.Format("{0:m}", now));   // Mes y día
Console.WriteLine("Formato M: " + string.Format("{0:M}", now));   // Mes y día con nombre
Console.WriteLine("Formato o: " + string.Format("{0:o}", now));   // Formato ISO 8601
Console.WriteLine("Formato R: " + string.Format("{0:R}", now));   // Formato RFC1123
Console.WriteLine("Formato s: " + string.Format("{0:s}", now));   // Formato sortable
Console.WriteLine("Formato t: " + string.Format("{0:t}", now));   // Hora corta
Console.WriteLine("Formato T: " + string.Format("{0:T}", now));   // Hora larga
Console.WriteLine("Formato u: " + string.Format("{0:u}", now));   // Formato universal ISO 8601
Console.WriteLine("Formato U: " + string.Format("{0:U}", now));   // Formato universal con nombre de día y mes
Console.WriteLine("Formato y: " + string.Format("{0:y}", now));   // Mes y año
Console.WriteLine("Formato Y: " + string.Format("{0:Y}", now));   // Mes y año con nombre completo
