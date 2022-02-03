using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BrandDbServiceLib
{
    [ServiceContract]
    public interface IBrandInfoService
    {
        [OperationContract]
        CarBrand GetData(string name);
    }
    [DataContract]
    public class CarBrand
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int FoundedIn { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public int NumberOfEmployees { get; set; }
    }
}
