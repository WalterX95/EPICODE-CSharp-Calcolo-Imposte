using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcoloImposte.Models;
using CodiceFiscaleUtility;

namespace CalcoloImposte.Models
{
    internal class Contribuente
    {
        private string Nome {  get; set; } = String.Empty;
        private string Cognome { get; set;} = String.Empty;
        private DateTime DataNascita { get; set; }
        private string Sesso {  get; set; } = String.Empty;
        private string ComuneResidenza {  get; set; } = String.Empty;

        private string Provincia {  get; set; } = String.Empty;
        private decimal RedditoAnnuale { get; set; } 

        private decimal RedditoImposte { get; set; }
       
        /*Costruzione di un Costruttore per caloclare un reddito */

        public Contribuente(string nome, string cognome, DateTime dataNascita, string sesso, string comuneResidenza, string provincia ,decimal redditoAnnuale )
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
            Sesso = sesso;
            Provincia = provincia;
            ComuneResidenza = comuneResidenza;
            RedditoAnnuale = redditoAnnuale;

        }

        public string ComponiCodiceFiscale()
        {
            int LivelloOmocodia = 1;
            var cf = new CodiceFiscale(Cognome, Nome, Sesso, DataNascita, ComuneResidenza, Provincia, LivelloOmocodia);
            return cf.CodiceNormalizzato;
        }
         public decimal CalcoloImposte() {
            switch(RedditoAnnuale)
            {
                case <= 15.000m :
                    RedditoImposte = RedditoAnnuale * 23 / 100;
                    break;
                case <= 28.000m :
                    RedditoImposte = RedditoAnnuale * 27 / 100;
                    break;
                case <= 38.000m:
                    RedditoImposte = RedditoAnnuale * 38 / 100;
                    break;
                case <= 55.000m:
                    RedditoImposte = RedditoAnnuale * 41 / 100;
                    break;
                case >= 75.000m:
                    RedditoImposte = RedditoAnnuale * 41 / 100;
                    break;
            }
            Console.WriteLine("==================================================");
            Console.WriteLine("Contribuente :"+Nome);
            Console.WriteLine("Nato il "+DataNascita.Date+" ("+Sesso+")");
            Console.WriteLine("Codice Fiscale :"+ComponiCodiceFiscale());
            Console.WriteLine("Reddito Dichiarato :" + RedditoAnnuale.ToString("C", new System.Globalization.CultureInfo("it-IT")));
            Console.WriteLine("Imposta da Versare :" + RedditoImposte.ToString("C", new System.Globalization.CultureInfo("it-IT")));

            return RedditoAnnuale;
        }
    }
}
