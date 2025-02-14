using CalcoloImposte.Models;
Console.OutputEncoding = System.Text.Encoding.UTF8;

string? nomePersona;
string? cognomePersona;
string? sessoPersona;
string? dateTime;
string? comunePersona;
string? provinciaPersona;
string? reddito;

Console.WriteLine("=============  CALCOLO REDDITO  =====================");
Console.WriteLine("Inserire il Nome ");
nomePersona = Console.ReadLine();
Console.WriteLine("Inserire il Cognome ");
cognomePersona = Console.ReadLine();
Console.WriteLine("Inserire la Data Di Nascita ");
dateTime = Console.ReadLine();
Console.WriteLine("Inserire il Sesso ");
sessoPersona = Console.ReadLine();
Console.WriteLine("Inserisci Comune ");
comunePersona = Console.ReadLine();
Console.WriteLine("Inserisci Provincia ");
provinciaPersona = Console.ReadLine();
Console.WriteLine("Inserisci il Reddito ");
reddito = Console.ReadLine();

Contribuente RedditoCalcolato = new Contribuente(nomePersona, cognomePersona, Convert.ToDateTime(dateTime),sessoPersona,comunePersona,provinciaPersona,Convert.ToDecimal(reddito));

RedditoCalcolato.CalcoloImposte();



