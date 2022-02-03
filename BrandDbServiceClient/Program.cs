using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrandDbServiceClient.ServiceReference1;

namespace BrandDbServiceClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BrandInfoServiceClient client = new BrandInfoServiceClient();
            Console.WriteLine("Hello!\nEnter car brand name for detailed information:");
            string carBrandName = Console.ReadLine();
            CarBrand carBrand = client.GetData(carBrandName);
            if (carBrand != null)
            {
                Console.WriteLine($"Detailed information about {carBrand.Name}:");
                Console.WriteLine($"\tCountry - {carBrand.Country}");
                Console.WriteLine($"\tYear of foundation - {carBrand.FoundedIn}");
                Console.WriteLine($"\tNumber of employees - {carBrand.NumberOfEmployees}");
            }
            else
            {
                Console.WriteLine($"No information about {carBrandName}");
            }
            Console.ReadLine();
        }
    }
}
