using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone - OK

Nokia nokia = new Nokia("83998341258", "Nokia 13", "123456789ABC", 10000);

Iphone iphone = new Iphone("83998341257", "Iphone XR", "123564XYZ", 20000);

nokia.InstalarAplicativo("WhatsApp");

iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine($"Número: {nokia.Numero}, Memória: {nokia.Memoria}, IMEI: {nokia.IMEI}, Modelo: {nokia.Modelo}");

Console.WriteLine($"Número: {iphone.Numero}, Memória: {iphone.Memoria}, IMEI: {iphone.IMEI}, Modelo: {iphone.Modelo}");


nokia.Ligar();
nokia.ReceberLigacao();

iphone.Ligar();
iphone.ReceberLigacao();