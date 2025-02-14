using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcoloImposte.Models
{
    internal static class ControlloCampo
    {
        private static string MyCampo {  get; set; } = String.Empty;

        public static string ControllaCampi(string? campoDiControllo)
        {
            if (campoDiControllo.Length == 0 || String.IsNullOrEmpty(campoDiControllo))
            {
                Console.WriteLine("Questo Campo Non è valido !");
                Console.WriteLine("Riscrivi il valore del campo");
                campoDiControllo = Console.ReadLine();
            }

            else if(campoDiControllo.Length == 2 && campoDiControllo.StartsWith(campoDiControllo))
            {
                campoDiControllo.ToUpper();
            }
            return campoDiControllo;
        }
    }
}
