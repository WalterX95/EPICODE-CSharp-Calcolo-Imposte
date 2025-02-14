using CalcoloImposte.Models;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Title = "Calcolo Imposte - EPICODE";

string? nomePersona;
string? cognomePersona;
string? sessoPersona;
string? dateTime;
string? comunePersona;
string? provinciaPersona;
string? reddito;

string? scelta;
bool ciclo = true;

while(ciclo)
{
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
    Console.WriteLine("Inserisci Provincia (Solo le Iniziali del Comune Es: Napoli bisogna scrivere NA per Roma = RM");
    provinciaPersona = Console.ReadLine();
    Console.WriteLine("Inserisci il Reddito ");
    reddito = Console.ReadLine();

    Contribuente RedditoCalcolato = new Contribuente(nomePersona, cognomePersona, Convert.ToDateTime(dateTime), sessoPersona, comunePersona, provinciaPersona, Convert.ToDecimal(reddito));

    RedditoCalcolato.CalcoloImposte();
    Console.Write("Vuoi effettuare un nuovo calcolo imposte ? Y/N : ");
    scelta = Console.ReadLine();
    if(scelta == null || scelta.ToUpper() == "N")
    {
        ciclo = false;
        
    }  
    else
    {
        Console.Clear();
    }
}

Environment.Exit(0);




