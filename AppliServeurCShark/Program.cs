using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServeurCShark;
using System.ServiceModel;

namespace AppliServeurCShark
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Uri baseAddress = new Uri("http://localhost:53942");
            
            var serveur = new Service1();
            var host = new ServiceHost(serveur);
            */
            // en cas de pb d'accès à l'url au lancement sous windows, ouvrir la console en admin et entrer la commande:
            // netsh http add urlacl url=http://+:53942/ delegate=yes user=le nom de l'user windows
            using (ServiceHost host = new ServiceHost(typeof(Service1)))
            {
                host.Open();

                Console.WriteLine("Server is running");
                Console.ReadKey();

                host.Close();
            }

        }
    }
}
