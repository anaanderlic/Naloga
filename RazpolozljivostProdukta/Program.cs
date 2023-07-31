using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazpolozljivostProdukta
{
    internal class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {

            // TESTNI PRIMERI

            Console.WriteLine("Testni podatki za preverjanje razpoložljivosti izdelka:");
            Console.WriteLine();

            // Primer izdelka z availability FALSE
            Izdelek izdelek1 = new Izdelek(1111, new DateTime(2024,2,21), DateTime.Today, "approved");
            Console.WriteLine(izdelek1 + " ima availability " + izdelek1.Availability() + ".");
            log.Info($"Iskan je bil izdelek z id-jem {izdelek1.Id} - status razpoložljivosti je bil {izdelek1.Availability()}.");

            // Primer izdelka z availability TRUE
            Izdelek izdelek2 = new Izdelek(2222, new DateTime(2023, 2, 21), new DateTime(2024, 2, 21), "approved");
            Console.WriteLine(izdelek2 + " ima availability " + izdelek2.Availability() + ".");
            log.Info($"Iskan je bil izdelek z id-jem {izdelek2.Id} - status razpoložljivosti je bil {izdelek2.Availability()}.");

            // Primer izdelka z availability FALSE
            Izdelek izdelek3 = new Izdelek(3333, new DateTime(2023, 2, 21), new DateTime(2024, 2, 21), "");
            Console.WriteLine(izdelek3 + " ima availability " + izdelek3.Availability() + ".");
            log.Info($"Iskan je bil izdelek z id-jem {izdelek3.Id} - status razpoložljivosti je bil {izdelek3.Availability()}.");

            // Primer izdelka z availability TRUE
            Izdelek izdelek4 = new Izdelek(4444, "approved");
            Console.WriteLine(izdelek4 + " ima availability " + izdelek4.Availability() + ".");
            log.Info($"Iskan je bil izdelek z id-jem {izdelek4.Id} - status razpoložljivosti je bil {izdelek4.Availability()}.");

            // Primer izdelka z availability FALSE
            Izdelek izdelek5 = new Izdelek(5555, "");
            Console.WriteLine(izdelek5 + " ima availability " + izdelek5.Availability() + ".");
            log.Info($"Iskan je bil izdelek z id-jem {izdelek5.Id} - status razpoložljivosti je bil {izdelek5.Availability()}.");

            Console.WriteLine();
        }

    }
}
