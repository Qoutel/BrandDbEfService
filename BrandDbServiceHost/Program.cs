using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using BrandDbServiceLib;

namespace BrandDbServiceHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8733/BrandDbService");
            ServiceHost server = new ServiceHost(typeof(BrandInfoService), baseAddress);
            server.AddServiceEndpoint(typeof(IBrandInfoService), new WSHttpBinding(), "BrandInfoService");
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            server.Description.Behaviors.Add(smb);
            server.Open();

            Console.WriteLine("BrandDbService is started...");
            Console.ReadLine();

            server.Close();
        }
    }
}
